using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace Server
{
    public partial class SendFile : Form
    {
        const int PORT = 3333;

        Form1 f1;
        public SendFile(Form1 frm1)
        {
            InitializeComponent();
            textBox2.Click += textBox2_Click;
            this.f1 = frm1;
        }
        void resetControls()
        {
            textBox1.Enabled = textBox2.Enabled = button1.Enabled = true;
            button1.Text = "GỬI";
            progressBar1.Value = 0;
            progressBar1.Style = ProgressBarStyle.Continuous;
        }

        void textBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox2.Text = ofd.FileName;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = textBox2.Enabled = button1.Enabled = false;
            progressBar1.Style = ProgressBarStyle.Marquee;

            // Parsing
            button1.Text = "CHUẨN BỊ ...";
            IPAddress address;
            FileInfo file;
            FileStream fileStream;
            if (!IPAddress.TryParse(textBox1.Text, out address))
            {
                MessageBox.Show("Lỗi địa chỉ IP !");
                resetControls();
                return;
            }
            try
            {
                file = new FileInfo(textBox2.Text);
                fileStream = file.OpenRead();
            }
            catch
            {
                MessageBox.Show("Lỗi mở file !");
                resetControls();
                return;
            }

            // Connecting
            button1.Text = "Đang kết nối ...";
            TcpClient client = new TcpClient();
            try
            {
                await client.ConnectAsync(address, PORT);
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối đến người nhận !");
                resetControls();
                return;
            }
            NetworkStream ns = client.GetStream();

            // Send file info
            button1.Text = "Thông tin file cần gửi ...";
            { // This syntax sugar is awesome
                byte[] fileName = ASCIIEncoding.ASCII.GetBytes(file.Name);
                byte[] fileNameLength = BitConverter.GetBytes(fileName.Length);
                byte[] fileLength = BitConverter.GetBytes(file.Length);
                await ns.WriteAsync(fileLength, 0, fileLength.Length);
                await ns.WriteAsync(fileNameLength, 0, fileNameLength.Length);
                await ns.WriteAsync(fileName, 0, fileName.Length);
            }

            // Get permissions
            button1.Text = "Đang yêu cầu quyền gửi file ...";
            {
                byte[] permission = new byte[1];
                await ns.ReadAsync(permission, 0, 1);
                if (permission[0] != 1)
                {
                    MessageBox.Show("Từ chối nhận file !");
                    resetControls();
                    return;
                }
            }

            // Sending
            button1.Text = "Đang gửi ...";
            progressBar1.Style = ProgressBarStyle.Continuous;
            int read;
            int totalWritten = 0;
            byte[] buffer = new byte[32 * 1024]; // 32k chunks
            while ((read = await fileStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
            {
                await ns.WriteAsync(buffer, 0, read);
                totalWritten += read;
                progressBar1.Value = (int)((100d * totalWritten) / file.Length);
            }

            fileStream.Dispose();
            client.Close();
            MessageBox.Show("Gửi file thành công !");
            this.Close();
        }

        private void frmSender_Load(object sender, EventArgs e)
        {
            textBox1.Text = f1.Text;
            textBox1.Enabled = false;
        }
    }
}
