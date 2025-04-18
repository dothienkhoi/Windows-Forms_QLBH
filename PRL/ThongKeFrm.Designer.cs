namespace PRL
{
    partial class ThongKeFrm
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
            panel1 = new Panel();
            label6 = new Label();
            lb_dt_thanh = new Label();
            label4 = new Label();
            lb_sokh_value = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lb_dt_thang_value = new Label();
            lb_dt_ngay_value = new Label();
            panel2 = new Panel();
            btb_thongke = new Button();
            panel3 = new Panel();
            dataGridView_hdtk = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_hdtk).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 255, 128);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(lb_dt_thanh);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lb_sokh_value);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lb_dt_thang_value);
            panel1.Controls.Add(lb_dt_ngay_value);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1453, 372);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1212, 9);
            label6.Name = "label6";
            label6.Size = new Size(131, 23);
            label6.TabIndex = 4;
            label6.Text = "Số Khách Hàng";
            // 
            // lb_dt_thanh
            // 
            lb_dt_thanh.AutoSize = true;
            lb_dt_thanh.Location = new Point(663, 21);
            lb_dt_thanh.Name = "lb_dt_thanh";
            lb_dt_thanh.Size = new Size(196, 23);
            lb_dt_thanh.TabIndex = 4;
            lb_dt_thanh.Text = "Doanh Thu Theo Tháng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(162, 21);
            label4.Name = "label4";
            label4.Size = new Size(188, 23);
            label4.TabIndex = 4;
            label4.Text = "Doanh Thu Theo Ngày";
            // 
            // lb_sokh_value
            // 
            lb_sokh_value.AutoSize = true;
            lb_sokh_value.Location = new Point(1257, 287);
            lb_sokh_value.Name = "lb_sokh_value";
            lb_sokh_value.Size = new Size(40, 23);
            lb_sokh_value.TabIndex = 3;
            lb_sokh_value.Text = "......";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.sokh;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(1112, 54);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(330, 216);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.dtthang;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(596, 54);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(330, 216);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.dtngay;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(91, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(330, 216);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lb_dt_thang_value
            // 
            lb_dt_thang_value.AutoSize = true;
            lb_dt_thang_value.Location = new Point(675, 287);
            lb_dt_thang_value.Name = "lb_dt_thang_value";
            lb_dt_thang_value.Size = new Size(40, 23);
            lb_dt_thang_value.TabIndex = 1;
            lb_dt_thang_value.Text = "......";
            // 
            // lb_dt_ngay_value
            // 
            lb_dt_ngay_value.AutoSize = true;
            lb_dt_ngay_value.Location = new Point(170, 287);
            lb_dt_ngay_value.Name = "lb_dt_ngay_value";
            lb_dt_ngay_value.Size = new Size(40, 23);
            lb_dt_ngay_value.TabIndex = 0;
            lb_dt_ngay_value.Text = "......";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 255, 128);
            panel2.Controls.Add(btb_thongke);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 372);
            panel2.Name = "panel2";
            panel2.Size = new Size(286, 453);
            panel2.TabIndex = 1;
            // 
            // btb_thongke
            // 
            btb_thongke.BackgroundImage = Properties.Resources.thongke;
            btb_thongke.BackgroundImageLayout = ImageLayout.Zoom;
            btb_thongke.Location = new Point(97, 188);
            btb_thongke.Name = "btb_thongke";
            btb_thongke.Size = new Size(94, 101);
            btb_thongke.TabIndex = 0;
            btb_thongke.UseVisualStyleBackColor = true;
            btb_thongke.Click += btb_thongke_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView_hdtk);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(286, 372);
            panel3.Name = "panel3";
            panel3.Size = new Size(1167, 453);
            panel3.TabIndex = 2;
            // 
            // dataGridView_hdtk
            // 
            dataGridView_hdtk.BackgroundColor = Color.Silver;
            dataGridView_hdtk.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_hdtk.Location = new Point(6, 6);
            dataGridView_hdtk.Name = "dataGridView_hdtk";
            dataGridView_hdtk.RowHeadersWidth = 51;
            dataGridView_hdtk.Size = new Size(1149, 444);
            dataGridView_hdtk.TabIndex = 0;
            // 
            // ThongKeFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1453, 825);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ThongKeFrm";
            Text = "ThongKeFrm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_hdtk).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label lb_dt_thang_value;
        private Label lb_dt_ngay_value;
        private Panel panel2;
        private Label lb_sokh_value;
        private Label label6;
        private Label lb_dt_thanh;
        private Label label4;
        private Panel panel3;
        private DataGridView dataGridView_hdtk;
        private Button btb_thongke;
    }
}