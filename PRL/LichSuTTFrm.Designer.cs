namespace PRL
{
    partial class LichSuTTFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LichSuTTFrm));
            dataGridView_lstt = new DataGridView();
            label8 = new Label();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            btn_close_lstt = new Button();
            clear_lstt = new Button();
            btn_delete_lstt = new Button();
            label1 = new Label();
            txt_sotien_ls = new TextBox();
            txt_ghichu_ls = new TextBox();
            txt_malstt = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            btn_xuatexcells = new Button();
            groupBox2 = new GroupBox();
            pictureBox_lstt = new PictureBox();
            txt_mahdf = new TextBox();
            txt_mahtf = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView_lstt).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_lstt).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_lstt
            // 
            dataGridView_lstt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_lstt.Location = new Point(0, 321);
            dataGridView_lstt.Name = "dataGridView_lstt";
            dataGridView_lstt.RowHeadersWidth = 51;
            dataGridView_lstt.Size = new Size(1114, 504);
            dataGridView_lstt.TabIndex = 16;
            dataGridView_lstt.CellClick += dataGridView_lstt_CellClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1238, 26);
            label8.Name = "label8";
            label8.Size = new Size(164, 23);
            label8.TabIndex = 4;
            label8.Text = "Lịch Sử Thanh Toán";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(598, 122);
            label7.Name = "label7";
            label7.Size = new Size(73, 23);
            label7.TabIndex = 0;
            label7.Text = "Ghi Chú";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 218);
            label4.Name = "label4";
            label4.Size = new Size(111, 23);
            label4.TabIndex = 0;
            label4.Text = "Mã Hóa Đơn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 133);
            label3.Name = "label3";
            label3.Size = new Size(122, 23);
            label3.TabIndex = 0;
            label3.Text = "Mã Hình Thức";
            // 
            // btn_close_lstt
            // 
            btn_close_lstt.BackgroundImage = Properties.Resources.close;
            btn_close_lstt.BackgroundImageLayout = ImageLayout.Zoom;
            btn_close_lstt.Location = new Point(58, 400);
            btn_close_lstt.Name = "btn_close_lstt";
            btn_close_lstt.Size = new Size(93, 51);
            btn_close_lstt.TabIndex = 0;
            btn_close_lstt.UseVisualStyleBackColor = true;
            btn_close_lstt.Click += btn_close_lstt_Click;
            // 
            // clear_lstt
            // 
            clear_lstt.BackgroundImage = Properties.Resources.clear;
            clear_lstt.BackgroundImageLayout = ImageLayout.Zoom;
            clear_lstt.Location = new Point(189, 400);
            clear_lstt.Name = "clear_lstt";
            clear_lstt.Size = new Size(93, 51);
            clear_lstt.TabIndex = 0;
            clear_lstt.UseVisualStyleBackColor = true;
            clear_lstt.Click += clear_lstt_Click;
            // 
            // btn_delete_lstt
            // 
            btn_delete_lstt.BackgroundImage = Properties.Resources.delete;
            btn_delete_lstt.BackgroundImageLayout = ImageLayout.Zoom;
            btn_delete_lstt.Location = new Point(58, 100);
            btn_delete_lstt.Name = "btn_delete_lstt";
            btn_delete_lstt.Size = new Size(93, 51);
            btn_delete_lstt.TabIndex = 0;
            btn_delete_lstt.UseVisualStyleBackColor = true;
            btn_delete_lstt.Click += btn_delete_lstt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(598, 51);
            label1.Name = "label1";
            label1.Size = new Size(192, 23);
            label1.TabIndex = 0;
            label1.Text = "Số Tiền Đã Thanh Toán";
            // 
            // txt_sotien_ls
            // 
            txt_sotien_ls.Location = new Point(798, 46);
            txt_sotien_ls.Name = "txt_sotien_ls";
            txt_sotien_ls.Size = new Size(384, 30);
            txt_sotien_ls.TabIndex = 1;
            // 
            // txt_ghichu_ls
            // 
            txt_ghichu_ls.Location = new Point(798, 117);
            txt_ghichu_ls.Multiline = true;
            txt_ghichu_ls.Name = "txt_ghichu_ls";
            txt_ghichu_ls.Size = new Size(384, 100);
            txt_ghichu_ls.TabIndex = 1;
            // 
            // txt_malstt
            // 
            txt_malstt.Location = new Point(163, 50);
            txt_malstt.Name = "txt_malstt";
            txt_malstt.ReadOnly = true;
            txt_malstt.Size = new Size(384, 30);
            txt_malstt.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 54);
            label2.Name = "label2";
            label2.Size = new Size(98, 23);
            label2.TabIndex = 0;
            label2.Text = "Mã Lịch Sử";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(128, 255, 128);
            groupBox1.Controls.Add(btn_xuatexcells);
            groupBox1.Controls.Add(btn_close_lstt);
            groupBox1.Controls.Add(clear_lstt);
            groupBox1.Controls.Add(btn_delete_lstt);
            groupBox1.Dock = DockStyle.Right;
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(1120, 315);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(333, 510);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức Năng";
            // 
            // btn_xuatexcells
            // 
            btn_xuatexcells.BackgroundImage = (Image)resources.GetObject("btn_xuatexcells.BackgroundImage");
            btn_xuatexcells.BackgroundImageLayout = ImageLayout.Zoom;
            btn_xuatexcells.Location = new Point(189, 100);
            btn_xuatexcells.Name = "btn_xuatexcells";
            btn_xuatexcells.Size = new Size(93, 51);
            btn_xuatexcells.TabIndex = 2;
            btn_xuatexcells.UseVisualStyleBackColor = true;
            btn_xuatexcells.Click += btn_xuatexcells_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(128, 255, 128);
            groupBox2.Controls.Add(pictureBox_lstt);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txt_sotien_ls);
            groupBox2.Controls.Add(txt_ghichu_ls);
            groupBox2.Controls.Add(txt_mahdf);
            groupBox2.Controls.Add(txt_mahtf);
            groupBox2.Controls.Add(txt_malstt);
            groupBox2.Controls.Add(label2);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1453, 315);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông Tin";
            // 
            // pictureBox_lstt
            // 
            pictureBox_lstt.BackgroundImage = (Image)resources.GetObject("pictureBox_lstt.BackgroundImage");
            pictureBox_lstt.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox_lstt.Location = new Point(1276, 99);
            pictureBox_lstt.Name = "pictureBox_lstt";
            pictureBox_lstt.Size = new Size(80, 79);
            pictureBox_lstt.TabIndex = 7;
            pictureBox_lstt.TabStop = false;
            // 
            // txt_mahdf
            // 
            txt_mahdf.Location = new Point(163, 210);
            txt_mahdf.Name = "txt_mahdf";
            txt_mahdf.ReadOnly = true;
            txt_mahdf.Size = new Size(384, 30);
            txt_mahdf.TabIndex = 1;
            // 
            // txt_mahtf
            // 
            txt_mahtf.Location = new Point(163, 129);
            txt_mahtf.Name = "txt_mahtf";
            txt_mahtf.ReadOnly = true;
            txt_mahtf.Size = new Size(384, 30);
            txt_mahtf.TabIndex = 1;
            // 
            // LichSuTTFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1453, 825);
            Controls.Add(dataGridView_lstt);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "LichSuTTFrm";
            Text = "LichSuTTFrm";
            Load += LichSuTTFrm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_lstt).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_lstt).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_lstt;
        private Label label8;
        private Label label7;
        private Label label4;
        private Label label3;
        private Button btn_close_lstt;
        private Button clear_lstt;
        private Button btn_delete_lstt;
        private Label label1;
        private TextBox txt_sotien_ls;
        private TextBox txt_ghichu_ls;
        private TextBox txt_malstt;
        private Label label2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btn_xuatexcells;
        private TextBox txt_mahdf;
        private TextBox txt_mahtf;
        private PictureBox pictureBox_lstt;
    }
}