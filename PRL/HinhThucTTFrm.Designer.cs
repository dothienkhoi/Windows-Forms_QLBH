namespace PRL
{
    partial class HinhThucTTFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HinhThucTTFrm));
            groupBox1 = new GroupBox();
            btn_close_httt = new Button();
            clear_httt = new Button();
            btn_delete_httt = new Button();
            btn_update_httt = new Button();
            btnadd_httt = new Button();
            txt_tenhttt = new TextBox();
            txt_malhttt = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            pictureBox_httt = new PictureBox();
            label8 = new Label();
            comboBox_trangthaihttt = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            dataGridView_httt = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_httt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_httt).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(128, 255, 128);
            groupBox1.Controls.Add(btn_close_httt);
            groupBox1.Controls.Add(clear_httt);
            groupBox1.Controls.Add(btn_delete_httt);
            groupBox1.Controls.Add(btn_update_httt);
            groupBox1.Controls.Add(btnadd_httt);
            groupBox1.Dock = DockStyle.Right;
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(1120, 315);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(333, 510);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức Năng";
            // 
            // btn_close_httt
            // 
            btn_close_httt.BackgroundImage = Properties.Resources.close;
            btn_close_httt.BackgroundImageLayout = ImageLayout.Zoom;
            btn_close_httt.Location = new Point(97, 299);
            btn_close_httt.Name = "btn_close_httt";
            btn_close_httt.Size = new Size(145, 51);
            btn_close_httt.TabIndex = 0;
            btn_close_httt.UseVisualStyleBackColor = true;
            btn_close_httt.Click += btn_close_httt_Click;
            // 
            // clear_httt
            // 
            clear_httt.BackgroundImage = Properties.Resources.clear;
            clear_httt.BackgroundImageLayout = ImageLayout.Zoom;
            clear_httt.Location = new Point(197, 166);
            clear_httt.Name = "clear_httt";
            clear_httt.Size = new Size(93, 51);
            clear_httt.TabIndex = 0;
            clear_httt.UseVisualStyleBackColor = true;
            clear_httt.Click += clear_httt_Click;
            // 
            // btn_delete_httt
            // 
            btn_delete_httt.BackgroundImage = Properties.Resources.delete;
            btn_delete_httt.BackgroundImageLayout = ImageLayout.Zoom;
            btn_delete_httt.Location = new Point(48, 166);
            btn_delete_httt.Name = "btn_delete_httt";
            btn_delete_httt.Size = new Size(93, 51);
            btn_delete_httt.TabIndex = 0;
            btn_delete_httt.UseVisualStyleBackColor = true;
            btn_delete_httt.Click += btn_delete_httt_Click;
            // 
            // btn_update_httt
            // 
            btn_update_httt.BackgroundImage = Properties.Resources.update;
            btn_update_httt.BackgroundImageLayout = ImageLayout.Zoom;
            btn_update_httt.Location = new Point(197, 66);
            btn_update_httt.Name = "btn_update_httt";
            btn_update_httt.Size = new Size(93, 51);
            btn_update_httt.TabIndex = 0;
            btn_update_httt.UseVisualStyleBackColor = true;
            btn_update_httt.Click += btn_update_httt_Click;
            // 
            // btnadd_httt
            // 
            btnadd_httt.BackgroundImage = Properties.Resources.add;
            btnadd_httt.BackgroundImageLayout = ImageLayout.Zoom;
            btnadd_httt.Location = new Point(48, 66);
            btnadd_httt.Name = "btnadd_httt";
            btnadd_httt.Size = new Size(93, 51);
            btnadd_httt.TabIndex = 0;
            btnadd_httt.UseVisualStyleBackColor = true;
            btnadd_httt.Click += btnadd_lstt_Click;
            // 
            // txt_tenhttt
            // 
            txt_tenhttt.Location = new Point(653, 141);
            txt_tenhttt.Name = "txt_tenhttt";
            txt_tenhttt.Size = new Size(384, 30);
            txt_tenhttt.TabIndex = 1;
            // 
            // txt_malhttt
            // 
            txt_malhttt.Location = new Point(653, 59);
            txt_malhttt.Name = "txt_malhttt";
            txt_malhttt.ReadOnly = true;
            txt_malhttt.Size = new Size(384, 30);
            txt_malhttt.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(515, 64);
            label2.Name = "label2";
            label2.Size = new Size(122, 23);
            label2.TabIndex = 0;
            label2.Text = "Mã Hình Thức";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(128, 255, 128);
            groupBox2.Controls.Add(pictureBox_httt);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(comboBox_trangthaihttt);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txt_tenhttt);
            groupBox2.Controls.Add(txt_malhttt);
            groupBox2.Controls.Add(label2);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1453, 315);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông Tin";
            // 
            // pictureBox_httt
            // 
            pictureBox_httt.BackgroundImage = (Image)resources.GetObject("pictureBox_httt.BackgroundImage");
            pictureBox_httt.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox_httt.Location = new Point(1258, 118);
            pictureBox_httt.Name = "pictureBox_httt";
            pictureBox_httt.Size = new Size(80, 79);
            pictureBox_httt.TabIndex = 7;
            pictureBox_httt.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1200, 26);
            label8.Name = "label8";
            label8.Size = new Size(188, 23);
            label8.TabIndex = 4;
            label8.Text = "Hình Thức Thanh Toán";
            // 
            // comboBox_trangthaihttt
            // 
            comboBox_trangthaihttt.FormattingEnabled = true;
            comboBox_trangthaihttt.Items.AddRange(new object[] { "Không Hoạt Động", "Hoạt Động" });
            comboBox_trangthaihttt.Location = new Point(653, 218);
            comboBox_trangthaihttt.Name = "comboBox_trangthaihttt";
            comboBox_trangthaihttt.Size = new Size(384, 31);
            comboBox_trangthaihttt.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(522, 228);
            label4.Name = "label4";
            label4.Size = new Size(95, 23);
            label4.TabIndex = 0;
            label4.Text = "Trạng Thái";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(515, 143);
            label3.Name = "label3";
            label3.Size = new Size(129, 23);
            label3.TabIndex = 0;
            label3.Text = "Tên  Hình Thức";
            // 
            // dataGridView_httt
            // 
            dataGridView_httt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_httt.Location = new Point(0, 321);
            dataGridView_httt.Name = "dataGridView_httt";
            dataGridView_httt.RowHeadersWidth = 51;
            dataGridView_httt.Size = new Size(1114, 504);
            dataGridView_httt.TabIndex = 19;
            dataGridView_httt.CellClick += dataGridView_httt_CellClick;
            // 
            // HinhThucTTFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1453, 825);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(dataGridView_httt);
            Name = "HinhThucTTFrm";
            Text = "HinhThucTTFrm";
            Load += HinhThucTTFrm_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_httt).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_httt).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Button btn_close_httt;
        private Button clear_httt;
        private Button btn_delete_httt;
        private Button btn_update_httt;
        private Button btnadd_httt;
        private TextBox txt_tenhttt;
        private TextBox txt_malhttt;
        private Label label2;
        private GroupBox groupBox2;
        private Label label8;
        private ComboBox comboBox_trangthaihttt;
        private Label label4;
        private Label label3;
        private DataGridView dataGridView_httt;
        private PictureBox pictureBox_httt;
    }
}