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

namespace Client
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

        //Properties
        private string _username;
        public string UserName
        {
            get { return _username; }
            set { _username = value; }

        }

        //Ngắt kết nối khi thoát
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Gửi thông báo đã thoát đến server
            client.Send(Serialize(this.UserName + " Quit"));
            Close();
        }


        IPEndPoint IP;
        Socket client;

        //Kết nối server
        void Connect()
        {

            // IP là địa chỉ server
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 3333);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            try
            {
                client.Connect(IP);
            }
            catch
            {

                MessageBox.Show("Không thể kết nối với server", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;


            }


            Thread listen = new Thread(MyReceive);
            listen.IsBackground = true;
            listen.Start();


        }

        //Ngắt kết nối
        void Close()
        {
            client.Close();
        }

        //Gửi
        void MySend() //Hàm Send tự tạo
        {
            if (textMessage.Text != string.Empty)
            {
                string s = this.UserName + " : " + textMessage.Text;
                client.Send(Serialize(s)); //Đây là hàm Send có sẵn

            }
        }

        //Nhận
        string keynhansv = "/,v";
        void MyReceive() // Hàm Receive tự tạo
        {
            try
            {

                while (true)
                {
                    byte[] data = new byte[1024 * 5];
                    client.Receive(data);//Hàm Receive có sẵn
                    string mess = Deserialize(data).ToString();
                    AddMessageReceive(mess);

                    object objd = Deserialize(data);
                    /**/


                    if (objd.GetType().ToString() == "System.String")
                    {
                        string message = (string)Deserialize(data);

                        AddMessageSend(message);
                    }

                    if (objd.GetType().ToString() == "System.Drawing.Bitmap")
                    {
                       
                        keynhansv = keynhansv + "c3d2";

                        Image img = (Image)Deserialize(data);
                        imageList3.ImageSize = new Size(40, 40);
                        imageList3.Images.Add(keynhansv, img);
                        listMessage.LargeImageList = imageList3;
                        var listViewItem = listMessage.Items.Add("");
                        listViewItem.ImageKey = keynhansv;                      
                    }
                }
            }
            catch
            {
                Close();

            }
        }

        //Hiện tin nhắn lên khung chat
        void AddMessageSend(string s)
        {
            string time = DateTime.Now.ToString("hh:mm");
            string temp = time + " " + this.UserName + " : " + s;
            listMessage.Items.Add(temp);
          
            textMessage.Clear();
        }
        void AddMessageReceive(string s)
        {
            string time = DateTime.Now.ToString("hh:mm");
            listMessage.Items.Add(time + s);           
            textMessage.Clear();
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

        //Thực hiện gửi khi ấn button Send

        private void buttonSend_Click(object sender, EventArgs e)
        {
            MySend();
            AddMessageSend(textMessage.Text);
        }

        private void Client_Load(object sender, EventArgs e)
        {
            //Hiện tên
            label2.Text = this.UserName;
            //Gửi thông báo đã kết nối với server
            client.Send(Serialize(this.UserName));
            //  lsvView.Items.Add(new ListViewItem() { Text = s });
         // txbMessage.Clear();
       
        }

        private void bColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                listMessage.ForeColor = colorDialog.Color;
                textMessage.ForeColor = colorDialog.Color;
            }
        }

        private void bFont_Click(object sender, EventArgs e)
        {

            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                listMessage.Font = fontDialog.Font;
                textMessage.Font = fontDialog.Font;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                listMessage.BackColor = colorDialog.Color;
            }
        }
        
        private void BtnImages_Click(object sender, EventArgs e)
        {
            try
            {
                String path = @"";
                OpenFileDialog open = new OpenFileDialog();
                open.ShowDialog();
                path = open.FileName;
                Image image = Image.FromFile(path);
                byte[] data = new byte[1024 * 5000];
                data = Serialize(image);
                client.Send(data);

                AddImage(path);

            }
            catch (Exception)
            {

            }
        }
        int id= 1;
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
        string keycc = "abc";
        string keyaa = "abdc";
       

        private void btnEmoji_Click(object sender, EventArgs e)
        {
            listView1.Visible = true;

            // xử lý sự kiện select emoji
            listView1.DoubleClick += listView1_DoubleClick;
       
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString("HH:mm");

            if (listView1.FocusedItem == null) return;


            try
            {

                int id = listView1.SelectedIndices[0];
                //add list mih gui
                imageList3.Images.Add(keycc, imageList1.Images[id]);
                listMessage.LargeImageList = imageList3;
                imageList3.ImageSize = new Size(40, 40);
                var listViewItem = listMessage.Items.Add("");
                listViewItem.ImageKey = keycc;
                listView1.SelectedIndices.Clear();
                keycc = keycc + "v";
                // GỬI LÊN SERVER
                client.Send(Serialize(imageList1.Images[id]));
                listView1.SelectedIndices.Clear();
                listView1.SelectedItems.Clear();

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

        private void BtnReceiceFile_Click(object sender, EventArgs e)
        {
            ReceiceFile frm = new ReceiceFile(this);
            frm.ShowDialog();
        }
    }
}
