namespace PRL
{
    partial class QuanLyKhachHangfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyKhachHangfrm));
            dataGridView_kh = new DataGridView();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            txt_sdt = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_tenkh = new TextBox();
            txt_diemtichluy = new TextBox();
            groupBox2 = new GroupBox();
            pictureBox_kh = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView_kh).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_kh).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_kh
            // 
            dataGridView_kh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_kh.Location = new Point(0, 321);
            dataGridView_kh.Name = "dataGridView_kh";
            dataGridView_kh.RowHeadersWidth = 51;
            dataGridView_kh.Size = new Size(1114, 504);
            dataGridView_kh.TabIndex = 2;
            dataGridView_kh.CellClick += dataGridView_kh_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(128, 255, 128);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Dock = DockStyle.Right;
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(1120, 315);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(333, 510);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chúc Năng";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(6, 317);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Tìm Kiếm ở Đây";
            textBox1.Size = new Size(315, 41);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button5
            // 
            button5.BackgroundImage = Properties.Resources.close;
            button5.BackgroundImageLayout = ImageLayout.Zoom;
            button5.Location = new Point(95, 422);
            button5.Name = "button5";
            button5.Size = new Size(145, 51);
            button5.TabIndex = 0;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources.clear;
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.Location = new Point(197, 187);
            button4.Name = "button4";
            button4.Size = new Size(93, 51);
            button4.TabIndex = 0;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.delete;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Location = new Point(48, 187);
            button3.Name = "button3";
            button3.Size = new Size(93, 51);
            button3.TabIndex = 0;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.update;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(197, 45);
            button2.Name = "button2";
            button2.Size = new Size(93, 51);
            button2.TabIndex = 0;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.add;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(48, 45);
            button1.Name = "button1";
            button1.Size = new Size(93, 51);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(693, 23);
            label1.Name = "label1";
            label1.Size = new Size(106, 23);
            label1.TabIndex = 0;
            label1.Text = "Khách Hàng";
            // 
            // txt_sdt
            // 
            txt_sdt.Location = new Point(561, 72);
            txt_sdt.Name = "txt_sdt";
            txt_sdt.Size = new Size(638, 30);
            txt_sdt.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(417, 76);
            label2.Name = "label2";
            label2.Size = new Size(121, 23);
            label2.TabIndex = 0;
            label2.Text = "Số Điện Thoại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(417, 147);
            label3.Name = "label3";
            label3.Size = new Size(138, 23);
            label3.TabIndex = 0;
            label3.Text = "Tên Khách Hàng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(417, 229);
            label4.Name = "label4";
            label4.Size = new Size(122, 23);
            label4.TabIndex = 0;
            label4.Text = "Điểm tích lũy ";
            // 
            // txt_tenkh
            // 
            txt_tenkh.Location = new Point(561, 145);
            txt_tenkh.Name = "txt_tenkh";
            txt_tenkh.Size = new Size(638, 30);
            txt_tenkh.TabIndex = 1;
            // 
            // txt_diemtichluy
            // 
            txt_diemtichluy.Location = new Point(561, 224);
            txt_diemtichluy.Name = "txt_diemtichluy";
            txt_diemtichluy.Size = new Size(638, 30);
            txt_diemtichluy.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(128, 255, 128);
            groupBox2.Controls.Add(pictureBox_kh);
            groupBox2.Controls.Add(txt_diemtichluy);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txt_tenkh);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txt_sdt);
            groupBox2.Controls.Add(label2);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1453, 315);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông Tin";
            // 
            // pictureBox_kh
            // 
            pictureBox_kh.BackgroundImage = (Image)resources.GetObject("pictureBox_kh.BackgroundImage");
            pictureBox_kh.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox_kh.Location = new Point(113, 116);
            pictureBox_kh.Name = "pictureBox_kh";
            pictureBox_kh.Size = new Size(80, 79);
            pictureBox_kh.TabIndex = 7;
            pictureBox_kh.TabStop = false;
            // 
            // QuanLyKhachHangfrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1453, 825);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView_kh);
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "QuanLyKhachHangfrm";
            Text = "QuanLyKhachHangfrm";
            Load += QuanLyKhachHangfrm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_kh).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_kh).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView_kh;
        private GroupBox groupBox1;
        private TextBox txt_diemtichluy;
        private Button button3;
        private TextBox txt_tenkh;
        private Button button2;
        private Button button1;
        private TextBox txt_sdt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private Button button5;
        private Button button4;
        private PictureBox pictureBox_kh;
    }
}