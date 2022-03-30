using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();
            ThemEmoji();
            listView1.Visible = false;
        }
        private string[] ListUser = new string[100]; //Danh sách client
        private int n = 0; // số client
      
        //Ngắt kết nối
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        IPEndPoint IP;
        Socket server,client;
        List<Socket> ListClient;
        //Kết nối server
        //Nhan ten
        
        void Connect()
        {

            //Thông báo khi có client connect

            ListClient = new List<Socket>();
            // IP là địa chỉ server
            IP = new IPEndPoint(IPAddress.Any, 3333);

            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            server.Bind(IP);
            // Server đợi kết nối với các client 
            Thread Listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {

                        server.Listen(100);
                        Socket client = server.Accept();

                        ListClient.Add(client);

                        Thread receive = new Thread(UpdateNewUser);
                        receive.IsBackground = true;
                        receive.Start(client);

                        receive = new Thread(MyReceive);
                        receive.IsBackground = true;
                        receive.Start(client);

                    }
     
                     
              }
                catch
                {
                    IP = new IPEndPoint(IPAddress.Any, 3333);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

                }
            });
            Listen.IsBackground = true;
            Listen.Start();


        }
       


        //Ngắt kết nối
        void Close()
        {
            server.Close();
        }

        //Gửi
        void MySend(Socket client) //Hàm Send tự tạo
        {
            string temp = "Server : " + textMessage.Text;
            if (client != null && textMessage.Text != string.Empty)
                client.Send(Serialize(temp)); //Đây là hàm Send có sẵn
        }

        //Hàm hiển thị thông báo và lưu tên khi có client mới kết nối
        void UpdateNewUser(object obj)
        {
            //Nhận thông tin về client mới kết nối
            Socket client = obj as Socket;
            byte[] data = new byte[1024 * 5];
            client.Receive(data);//Hàm Receive có sẵn

            string mess = Deserialize(data).ToString();

            //Hiện thông báo 
            listNoti.Items.Add(mess + " đã kết nối");
            //Hiện người có trong phòng
            listRoom.Items.Add(mess);
            //Lưu tên người mới
            ListUser[n] = mess;
            n++;
        }
        //Nhận
        string keysend = "c";
        void MyReceive(object obj) // Hàm Receive tự tạo
        {
            Socket client = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5];
                    client.Receive(data);//Hàm Receive có sẵn

                    string mess = Deserialize(data).ToString();

                    bool flag = false;
                    //Kiểm tra điều kiện và thông báo có client đã thoát
                    for (int i = 0; i < n; i++)
                        if (mess == ListUser[i] + " Quit")
                        {
                            listNoti.Items.Add(ListUser[i] + " đã thoát");
                            flag = true;

                            ListUser[i] = null; // xóa client

                            //Cập nhật lại danh sách room
                            listRoom.Items.Clear();
                            for (int j = 0; j < n; j++)
                                if (ListUser[j] != null)
                                    listRoom.Items.Add(ListUser[j]);
                            break;

                        }
                    

                        //Nhận tin từ 1 client và gửi cho tất cả các client khác xem
                        if (flag == false)
                        {


                            foreach (Socket item in ListClient)
                            {
                                if (item != null && item != client)
                                    item.Send(Serialize(mess));
                            }
                            //Hiện tin nhắn lên màn hình
                            AddMessage(mess);
                        }
                    object objd = Deserialize(data);


                    if (objd.GetType().ToString() == "System.String")
                    {
                        string message = (string)Deserialize(data);
                        foreach (Socket item in ListClient)
                        {
                            if (item != null && item != client)
                                item.Send(Serialize(message));
                        }
                        AddMessage(message);


                    }

                    if (objd.GetType().ToString() == "System.Drawing.Bitmap")
                    {
                        
                        Image img = (Image)Deserialize(data);

                        imageList3.Images.Add(keysend, img); 
                        imageList3.ImageSize = new Size(40, 40);
                        listMessage.LargeImageList = imageList3; 
                        var listViewItem = listMessage.Items.Add(""); 
                        listViewItem.ImageKey = keysend;

                        keysend = keysend + "c";

                        foreach (Socket item in ListClient)
                        {

                            if (item != null && item != client)
                            {
                                item.Send(Serialize(img));

                            }

                        }
                        
                    }
                   
                }
            }
            catch
            {
                //Ngắt kết nối client
                ListClient.Remove(client);
                client.Close();

            }
        }

        //Hiện tin nhắn lên khung chat
        void AddMessage(string s)
        {
            
            string time = DateTime.Now.ToString("hh:mm");
            listMessage.Items.Add(time + s);
            
          
        }

        //Phân mảnh
        byte[] Serialize(object str)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, str); // Hàm Serialize có sẵn khác với hàm tự tạo
            return stream.ToArray();

            //Giải thích:  hàm này phân tích biến str theo kiểu binary rồi gán vào stream, hàm Serialize  
            //có sẵn sẽ phân mảnh rồi trả về kiểu mảng
        }

        //Gom mảnh
        object Deserialize(byte[] arr)
        {
            MemoryStream stream = new MemoryStream(arr);
            BinaryFormatter formatter = new BinaryFormatter();
            return formatter.Deserialize(stream); // Hàm Deserialize có sẵn khác với hàm tự tạo .ToString()

        }


        // Gửi tin khi nhấn gửi
        private void buttonSend_Click(object sender, EventArgs e)
        {
            foreach (Socket item in ListClient)
            {
                MySend(item);
            }
            //      string time = DateTime.Now.ToString("hh:mm"); time + " "
            string s =  "Server : " + textMessage.Text;
            AddMessage(s);
            textMessage.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                listView1.BackColor = colorDialog.Color;
            }
        }

        private void cbColor_Click(object sender, EventArgs e)
        {

            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                listView1.ForeColor = colorDialog.Color;
                textMessage.ForeColor = colorDialog.Color;
            }
        }



        private void button6_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                listView1.Font = fontDialog.Font;
                textMessage.Font = fontDialog.Font;
            }
        }
        String path = "";
        int id = 0;
        string keyaa = "b";
        private void BtnImages_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog chonAnh = new OpenFileDialog();
            chonAnh.Filter = "Images |*.bmp;*.jpg;*.png;*.gif;*.ico";
            chonAnh.Multiselect = false;
            chonAnh.FileName = "";
            DialogResult result = chonAnh.ShowDialog();
            if (result == DialogResult.OK)
            {
                FileInfo fi = new FileInfo(chonAnh.FileName.ToString());
                if (fi.Length > 1024 * 5000)
                {
                    MessageBox.Show("Kich thuoc anh ko qua 5000");
                    return;
                }
                Image img = Image.FromFile(chonAnh.FileName);
                imageList3.Images.Add(keyaa, img);
                listView1.LargeImageList = imageList3;
                /* imageList3.ImageSize = new Size(80,80);*/

                var listViewItem = listView1.Items.Add("");

               
                listViewItem.ImageKey = keyaa;
                keyaa = keyaa + "1i";
                foreach (Socket item in ListClient)
                {

                    item.Send(Serialize(img));

                }
            }
            else
            {
                return;
            }
           
        }
        void AddImage(string b)
        {
            try
            {
                id++;
                imageList1.Images.Add(Image.FromFile(b));
                listMessage.View = View.SmallIcon;
                imageList1.ImageSize = new Size(60, 60);
                listMessage.LargeImageList = imageList1;
                ListViewItem it = new ListViewItem();
                it.ImageIndex = id;
                listMessage.Items.Add(it);
            }
            catch (Exception)
            {
            }
        }
        string keydd = "a";
        // add emoji khi loa lên form
       void ThemEmoji()
        {
            var files = Directory.GetFiles("icons", ".", SearchOption.AllDirectories);
            int id = 0;
            listView1.LargeImageList = imageList1;
            foreach (string filename in files)
            {
                if (Regex.IsMatch(filename, @".jpg|.png|.gif$"))

                    imageList1.Images.Add(Image.FromFile(filename));
                // đưa lên list view
                listView1.Items.Add("", id);
                id++;
            }

        }
        string name = "";
     
       
        
        private void BtnEmoji_Click(object sender, EventArgs e)
        {
            listView1.Visible = true;
            listView1.DoubleClick += listView1_DoubleClick;

            // xử lý sự kiện select emoji
            
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            
            string time = DateTime.Now.ToString("HH:mm");
            if (listView1.FocusedItem == null) return;
            try
            {
                int id = listView1.SelectedIndices[0];
                // add len list mih gưi
                imageList3.Images.Add(keydd, imageList1.Images[id]);
                listMessage.LargeImageList = imageList3;
                var listViewItem = listMessage.Items.Add("");              
                listViewItem.ImageKey = keydd;
               // GỬI cho client
                foreach (Socket item in ListClient)
                {
                    item.Send(Serialize(imageList1.Images[id]));
                    listView1.SelectedIndices.Clear();
                    listView1.SelectedItems.Clear();
                }
            }
            catch { }

            listView1.Visible = false;
           

        }
        int chon = -1;
        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString("hh:mm");
            if (chon == -1) return;
            listMessage.Items[chon].Text = time + "Đã xóa";
            listMessage.Items[chon].ImageKey = "";
        }

        private void listMessage_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                chon = listMessage.SelectedIndices[0];
                MessageBox.Show(chon + "");

            }
            catch { }
        }


        private void BtnSendFile_Click(object sender, EventArgs e)
        {
            SendFile frm = new SendFile(this);
            System.Text.UTF8Encoding enc = new System.Text.UTF8Encoding();
            byte[] msg = new byte[1500];
            msg = enc.GetBytes("Phát hiện yêu cầu gửi file, vui lòng click 'Nhận File' để bắt đầu quá trình gửi file");
        //    server.Send(msg);
            frm.ShowDialog();
        }
    }
}
