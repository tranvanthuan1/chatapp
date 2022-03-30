
namespace Client
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
            this.textMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listMessage = new System.Windows.Forms.ListView();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonSend = new System.Windows.Forms.Button();
            this.bFont = new System.Windows.Forms.Button();
            this.bColor = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.BtnReceiceFile = new System.Windows.Forms.Button();
            this.btnEmoji = new System.Windows.Forms.Button();
            this.BtnImages = new System.Windows.Forms.Button();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textMessage
            // 
            this.textMessage.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textMessage.Location = new System.Drawing.Point(12, 442);
            this.textMessage.Multiline = true;
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(483, 42);
            this.textMessage.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Tên hiển thị: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(105, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "label2";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // listMessage
            // 
            this.listMessage.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listMessage.ContextMenuStrip = this.contextMenuStrip1;
            this.listMessage.HideSelection = false;
            this.listMessage.Location = new System.Drawing.Point(12, 60);
            this.listMessage.Margin = new System.Windows.Forms.Padding(2);
            this.listMessage.Name = "listMessage";
            this.listMessage.Size = new System.Drawing.Size(512, 342);
            this.listMessage.TabIndex = 1;
            this.listMessage.TileSize = new System.Drawing.Size(400, 40);
            this.listMessage.UseCompatibleStateImageBehavior = false;
            this.listMessage.View = System.Windows.Forms.View.Tile;
            this.listMessage.SelectedIndexChanged += new System.EventHandler(this.listMessage_SelectedIndexChanged);
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
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(59, 349);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(188, 136);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 6;
            this.listView1.TileSize = new System.Drawing.Size(40, 40);
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            this.listView1.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 26);
            // 
            // buttonSend
            // 
            this.buttonSend.Image = global::Client.Properties.Resources.send;
            this.buttonSend.Location = new System.Drawing.Point(495, 452);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(41, 23);
            this.buttonSend.TabIndex = 28;
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // bFont
            // 
            this.bFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bFont.Image = global::Client.Properties.Resources.z_file_font;
            this.bFont.Location = new System.Drawing.Point(45, 408);
            this.bFont.Name = "bFont";
            this.bFont.Size = new System.Drawing.Size(27, 28);
            this.bFont.TabIndex = 37;
            this.bFont.UseVisualStyleBackColor = true;
            this.bFont.Click += new System.EventHandler(this.bFont_Click);
            // 
            // bColor
            // 
            this.bColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bColor.Image = global::Client.Properties.Resources.color_line;
            this.bColor.Location = new System.Drawing.Point(12, 408);
            this.bColor.Name = "bColor";
            this.bColor.Size = new System.Drawing.Size(27, 28);
            this.bColor.TabIndex = 36;
            this.bColor.UseVisualStyleBackColor = true;
            this.bColor.Click += new System.EventHandler(this.bColor_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::Client.Properties.Resources.icons;
            this.button2.Location = new System.Drawing.Point(78, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 28);
            this.button2.TabIndex = 35;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Image = global::Client.Properties.Resources.pin_black__1_;
            this.button5.Location = new System.Drawing.Point(159, 490);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(30, 39);
            this.button5.TabIndex = 31;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // BtnReceiceFile
            // 
            this.BtnReceiceFile.Image = global::Client.Properties.Resources.pin;
            this.BtnReceiceFile.Location = new System.Drawing.Point(12, 490);
            this.BtnReceiceFile.Name = "BtnReceiceFile";
            this.BtnReceiceFile.Size = new System.Drawing.Size(30, 39);
            this.BtnReceiceFile.TabIndex = 29;
            this.BtnReceiceFile.UseVisualStyleBackColor = true;
            this.BtnReceiceFile.Click += new System.EventHandler(this.BtnReceiceFile_Click);
            // 
            // btnEmoji
            // 
            this.btnEmoji.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnEmoji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmoji.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEmoji.Image = global::Client.Properties.Resources._32_19;
            this.btnEmoji.Location = new System.Drawing.Point(108, 491);
            this.btnEmoji.Name = "btnEmoji";
            this.btnEmoji.Size = new System.Drawing.Size(35, 39);
            this.btnEmoji.TabIndex = 27;
            this.btnEmoji.UseVisualStyleBackColor = false;
            this.btnEmoji.Click += new System.EventHandler(this.btnEmoji_Click);
            // 
            // BtnImages
            // 
            this.BtnImages.Image = global::Client.Properties.Resources.toolbar_pictures;
            this.BtnImages.Location = new System.Drawing.Point(59, 490);
            this.BtnImages.Name = "BtnImages";
            this.BtnImages.Size = new System.Drawing.Size(30, 39);
            this.BtnImages.TabIndex = 30;
            this.BtnImages.UseVisualStyleBackColor = true;
            this.BtnImages.Click += new System.EventHandler(this.BtnImages_Click);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Image = global::Client.Properties.Resources.icons8_cut_60;
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 542);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listMessage);
            this.Controls.Add(this.bFont);
            this.Controls.Add(this.bColor);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.BtnReceiceFile);
            this.Controls.Add(this.btnEmoji);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.BtnImages);
            this.Name = "Form1";
            this.Text = "Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Client_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button BtnReceiceFile;
        private System.Windows.Forms.Button btnEmoji;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.Button BtnImages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bFont;
        private System.Windows.Forms.Button bColor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listMessage;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
    }
}

