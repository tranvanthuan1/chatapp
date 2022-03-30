
namespace Server
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textMessage = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listRoom = new System.Windows.Forms.ListBox();
            this.listNoti = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.listMessage = new System.Windows.Forms.ListView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSend = new System.Windows.Forms.Button();
            this.bFont = new System.Windows.Forms.Button();
            this.bColor = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.BtnImages = new System.Windows.Forms.Button();
            this.BtnSendFile = new System.Windows.Forms.Button();
            this.BtnEmoji = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textMessage
            // 
            this.textMessage.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textMessage.Location = new System.Drawing.Point(215, 394);
            this.textMessage.Multiline = true;
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(483, 42);
            this.textMessage.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.listRoom);
            this.panel2.Controls.Add(this.listNoti);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 465);
            this.panel2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "NOTIFICATIONS";
            // 
            // listRoom
            // 
            this.listRoom.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listRoom.FormattingEnabled = true;
            this.listRoom.Location = new System.Drawing.Point(3, 262);
            this.listRoom.Name = "listRoom";
            this.listRoom.Size = new System.Drawing.Size(191, 199);
            this.listRoom.TabIndex = 25;
            // 
            // listNoti
            // 
            this.listNoti.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listNoti.FormattingEnabled = true;
            this.listNoti.Location = new System.Drawing.Point(3, 30);
            this.listNoti.Name = "listNoti";
            this.listNoti.Size = new System.Drawing.Size(191, 186);
            this.listNoti.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "ROOM";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "beating-heart.png");
            this.imageList1.Images.SetKeyName(1, "astonished-face.png");
            this.imageList1.Images.SetKeyName(2, "blue-heart.png");
            this.imageList1.Images.SetKeyName(3, "broken-heart.png");
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList3
            // 
            this.imageList3.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList3.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // listMessage
            // 
            this.listMessage.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listMessage.ContextMenuStrip = this.contextMenuStrip1;
            this.listMessage.HideSelection = false;
            this.listMessage.Location = new System.Drawing.Point(215, 12);
            this.listMessage.Margin = new System.Windows.Forms.Padding(2);
            this.listMessage.Name = "listMessage";
            this.listMessage.Size = new System.Drawing.Size(527, 344);
            this.listMessage.TabIndex = 0;
            this.listMessage.TileSize = new System.Drawing.Size(400, 40);
            this.listMessage.UseCompatibleStateImageBehavior = false;
            this.listMessage.View = System.Windows.Forms.View.Tile;
            this.listMessage.SelectedIndexChanged += new System.EventHandler(this.listMessage_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(269, 312);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(130, 124);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            this.listView1.Visible = false;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 26);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Image = global::Server.Properties.Resources.send;
            this.buttonSend.Location = new System.Drawing.Point(698, 404);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(41, 23);
            this.buttonSend.TabIndex = 18;
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // bFont
            // 
            this.bFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bFont.Image = global::Server.Properties.Resources.z_file_font;
            this.bFont.Location = new System.Drawing.Point(251, 364);
            this.bFont.Name = "bFont";
            this.bFont.Size = new System.Drawing.Size(27, 28);
            this.bFont.TabIndex = 30;
            this.bFont.UseVisualStyleBackColor = true;
            this.bFont.Click += new System.EventHandler(this.button6_Click);
            // 
            // bColor
            // 
            this.bColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bColor.Image = global::Server.Properties.Resources.color_line;
            this.bColor.Location = new System.Drawing.Point(218, 364);
            this.bColor.Name = "bColor";
            this.bColor.Size = new System.Drawing.Size(27, 28);
            this.bColor.TabIndex = 27;
            this.bColor.UseVisualStyleBackColor = true;
            this.bColor.Click += new System.EventHandler(this.cbColor_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::Server.Properties.Resources.icons;
            this.button2.Location = new System.Drawing.Point(284, 364);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 28);
            this.button2.TabIndex = 23;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = global::Server.Properties.Resources.pin_black__1_1;
            this.button5.Location = new System.Drawing.Point(369, 442);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(30, 39);
            this.button5.TabIndex = 21;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // BtnImages
            // 
            this.BtnImages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImages.Image = global::Server.Properties.Resources.toolbar_pictures;
            this.BtnImages.Location = new System.Drawing.Point(266, 442);
            this.BtnImages.Name = "BtnImages";
            this.BtnImages.Size = new System.Drawing.Size(30, 39);
            this.BtnImages.TabIndex = 20;
            this.BtnImages.UseVisualStyleBackColor = true;
            this.BtnImages.Click += new System.EventHandler(this.BtnImages_Click);
            // 
            // BtnSendFile
            // 
            this.BtnSendFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSendFile.Image = global::Server.Properties.Resources.pin;
            this.BtnSendFile.Location = new System.Drawing.Point(215, 442);
            this.BtnSendFile.Name = "BtnSendFile";
            this.BtnSendFile.Size = new System.Drawing.Size(30, 39);
            this.BtnSendFile.TabIndex = 19;
            this.BtnSendFile.UseVisualStyleBackColor = true;
            this.BtnSendFile.Click += new System.EventHandler(this.BtnSendFile_Click);
            // 
            // BtnEmoji
            // 
            this.BtnEmoji.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BtnEmoji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmoji.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnEmoji.Image = global::Server.Properties.Resources._32_36;
            this.BtnEmoji.Location = new System.Drawing.Point(317, 442);
            this.BtnEmoji.Name = "BtnEmoji";
            this.BtnEmoji.Size = new System.Drawing.Size(35, 39);
            this.BtnEmoji.TabIndex = 17;
            this.BtnEmoji.UseVisualStyleBackColor = false;
            this.BtnEmoji.Click += new System.EventHandler(this.BtnEmoji_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pictureBox1.Location = new System.Drawing.Point(1, 233);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 10);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 518);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listMessage);
            this.Controls.Add(this.bFont);
            this.Controls.Add(this.bColor);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.BtnImages);
            this.Controls.Add(this.BtnSendFile);
            this.Controls.Add(this.BtnEmoji);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Server";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button BtnImages;
        private System.Windows.Forms.Button BtnSendFile;
        private System.Windows.Forms.Button BtnEmoji;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listRoom;
        private System.Windows.Forms.ListBox listNoti;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bColor;
        private System.Windows.Forms.Button bFont;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.ListView listMessage;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
    }
}

