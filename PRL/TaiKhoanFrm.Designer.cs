namespace PRL
{
    partial class TaiKhoanFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaiKhoanFrm));
            groupBox1 = new GroupBox();
            textBox_tk_sreach = new TextBox();
            btn_close_tk = new Button();
            clear_tk = new Button();
            btn_mokhoa_tk = new Button();
            btn_khoa_tk = new Button();
            btn_delete_tk = new Button();
            btn_update_tk = new Button();
            btnadd_tk = new Button();
            dataGridView_taik = new DataGridView();
            groupBox2 = new GroupBox();
            pictureBox_tk = new PictureBox();
            comboBox_role = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            txt_mk = new TextBox();
            label1 = new Label();
            txt_tentk = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_taik).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_tk).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(128, 255, 128);
            groupBox1.Controls.Add(textBox_tk_sreach);
            groupBox1.Controls.Add(btn_close_tk);
            groupBox1.Controls.Add(clear_tk);
            groupBox1.Controls.Add(btn_mokhoa_tk);
            groupBox1.Controls.Add(btn_khoa_tk);
            groupBox1.Controls.Add(btn_delete_tk);
            groupBox1.Controls.Add(btn_update_tk);
            groupBox1.Controls.Add(btnadd_tk);
            groupBox1.Dock = DockStyle.Right;
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(1000, 315);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(333, 501);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức Năng";
            // 
            // textBox_tk_sreach
            // 
            textBox_tk_sreach.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_tk_sreach.Location = new Point(6, 317);
            textBox_tk_sreach.Multiline = true;
            textBox_tk_sreach.Name = "textBox_tk_sreach";
            textBox_tk_sreach.PlaceholderText = "Tìm Kiếm ở Đây";
            textBox_tk_sreach.Size = new Size(315, 41);
            textBox_tk_sreach.TabIndex = 1;
            textBox_tk_sreach.TextChanged += textBox_tk_sreach_TextChanged;
            // 
            // btn_close_tk
            // 
            btn_close_tk.BackgroundImage = Properties.Resources.close;
            btn_close_tk.BackgroundImageLayout = ImageLayout.Zoom;
            btn_close_tk.Location = new Point(95, 422);
            btn_close_tk.Name = "btn_close_tk";
            btn_close_tk.Size = new Size(145, 51);
            btn_close_tk.TabIndex = 0;
            btn_close_tk.UseVisualStyleBackColor = true;
            btn_close_tk.Click += btn_close_tk_Click;
            // 
            // clear_tk
            // 
            clear_tk.BackgroundImage = Properties.Resources.clear;
            clear_tk.BackgroundImageLayout = ImageLayout.Zoom;
            clear_tk.Location = new Point(197, 145);
            clear_tk.Name = "clear_tk";
            clear_tk.Size = new Size(93, 51);
            clear_tk.TabIndex = 0;
            clear_tk.UseVisualStyleBackColor = true;
            clear_tk.Click += clear_tk_Click;
            // 
            // btn_mokhoa_tk
            // 
            btn_mokhoa_tk.BackgroundImage = (Image)resources.GetObject("btn_mokhoa_tk.BackgroundImage");
            btn_mokhoa_tk.BackgroundImageLayout = ImageLayout.Zoom;
            btn_mokhoa_tk.Location = new Point(197, 241);
            btn_mokhoa_tk.Name = "btn_mokhoa_tk";
            btn_mokhoa_tk.Size = new Size(93, 51);
            btn_mokhoa_tk.TabIndex = 0;
            btn_mokhoa_tk.UseVisualStyleBackColor = true;
            btn_mokhoa_tk.Click += btn_mokhoa_tk_Click;
            // 
            // btn_khoa_tk
            // 
            btn_khoa_tk.BackgroundImage = (Image)resources.GetObject("btn_khoa_tk.BackgroundImage");
            btn_khoa_tk.BackgroundImageLayout = ImageLayout.Zoom;
            btn_khoa_tk.Location = new Point(48, 241);
            btn_khoa_tk.Name = "btn_khoa_tk";
            btn_khoa_tk.Size = new Size(93, 51);
            btn_khoa_tk.TabIndex = 0;
            btn_khoa_tk.UseVisualStyleBackColor = true;
            btn_khoa_tk.Click += btn_khoa_tk_Click;
            // 
            // btn_delete_tk
            // 
            btn_delete_tk.BackgroundImage = Properties.Resources.delete;
            btn_delete_tk.BackgroundImageLayout = ImageLayout.Zoom;
            btn_delete_tk.Location = new Point(48, 145);
            btn_delete_tk.Name = "btn_delete_tk";
            btn_delete_tk.Size = new Size(93, 51);
            btn_delete_tk.TabIndex = 0;
            btn_delete_tk.UseVisualStyleBackColor = true;
            btn_delete_tk.Click += btn_delete_tk_Click;
            // 
            // btn_update_tk
            // 
            btn_update_tk.BackgroundImage = Properties.Resources.update;
            btn_update_tk.BackgroundImageLayout = ImageLayout.Zoom;
            btn_update_tk.Location = new Point(197, 45);
            btn_update_tk.Name = "btn_update_tk";
            btn_update_tk.Size = new Size(93, 51);
            btn_update_tk.TabIndex = 0;
            btn_update_tk.UseVisualStyleBackColor = true;
            btn_update_tk.Click += btn_update_tk_Click;
            // 
            // btnadd_tk
            // 
            btnadd_tk.BackgroundImage = Properties.Resources.add;
            btnadd_tk.BackgroundImageLayout = ImageLayout.Zoom;
            btnadd_tk.Location = new Point(48, 45);
            btnadd_tk.Name = "btnadd_tk";
            btnadd_tk.Size = new Size(93, 51);
            btnadd_tk.TabIndex = 0;
            btnadd_tk.UseVisualStyleBackColor = true;
            btnadd_tk.Click += btnadd_tk_Click;
            // 
            // dataGridView_taik
            // 
            dataGridView_taik.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_taik.Location = new Point(0, 321);
            dataGridView_taik.Name = "dataGridView_taik";
            dataGridView_taik.RowHeadersWidth = 51;
            dataGridView_taik.Size = new Size(1114, 504);
            dataGridView_taik.TabIndex = 5;
            dataGridView_taik.CellClick += dataGridView_taik_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(128, 255, 128);
            groupBox2.Controls.Add(pictureBox_tk);
            groupBox2.Controls.Add(comboBox_role);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txt_mk);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txt_tentk);
            groupBox2.Controls.Add(label2);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1333, 315);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông Tin";
            // 
            // pictureBox_tk
            // 
            pictureBox_tk.BackgroundImage = (Image)resources.GetObject("pictureBox_tk.BackgroundImage");
            pictureBox_tk.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox_tk.Location = new Point(63, 108);
            pictureBox_tk.Name = "pictureBox_tk";
            pictureBox_tk.Size = new Size(80, 79);
            pictureBox_tk.TabIndex = 7;
            pictureBox_tk.TabStop = false;
            // 
            // comboBox_role
            // 
            comboBox_role.FormattingEnabled = true;
            comboBox_role.Items.AddRange(new object[] { "Không Hoạt Động", "Admin", "Nhân Viên" });
            comboBox_role.Location = new Point(561, 227);
            comboBox_role.Name = "comboBox_role";
            comboBox_role.Size = new Size(638, 31);
            comboBox_role.TabIndex = 2;
            comboBox_role.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(437, 228);
            label4.Name = "label4";
            label4.Size = new Size(107, 23);
            label4.TabIndex = 0;
            label4.Text = "Role(VaiTrò)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(448, 146);
            label3.Name = "label3";
            label3.Size = new Size(87, 23);
            label3.TabIndex = 0;
            label3.Text = "Mật Khẩu";
            // 
            // txt_mk
            // 
            txt_mk.Location = new Point(561, 145);
            txt_mk.Name = "txt_mk";
            txt_mk.Size = new Size(638, 30);
            txt_mk.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(693, 23);
            label1.Name = "label1";
            label1.Size = new Size(88, 23);
            label1.TabIndex = 0;
            label1.Text = "Tài Khoản";
            // 
            // txt_tentk
            // 
            txt_tentk.Location = new Point(561, 72);
            txt_tentk.Name = "txt_tentk";
            txt_tentk.Size = new Size(638, 30);
            txt_tentk.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(435, 76);
            label2.Name = "label2";
            label2.Size = new Size(120, 23);
            label2.TabIndex = 0;
            label2.Text = "Tên Tài Khoản";
            // 
            // TaiKhoanFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1333, 816);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView_taik);
            Controls.Add(groupBox2);
            Name = "TaiKhoanFrm";
            Text = "TaiKhoanFrm";
            Load += TaiKhoanFrm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_taik).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_tk).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox_tk_sreach;
        private Button btn_close_tk;
        private Button clear_tk;
        private Button btn_delete_tk;
        private Button btn_update_tk;
        private Button btnadd_tk;
        private DataGridView dataGridView_taik;
        private GroupBox groupBox2;
        private Label label4;
        private Label label3;
        private TextBox txt_mk;
        private Label label1;
        private TextBox txt_tentk;
        private Label label2;
        private Button btn_khoa_tk;
        private Button btn_mokhoa_tk;
        private ComboBox comboBox_role;
        private PictureBox pictureBox_tk;
    }
}