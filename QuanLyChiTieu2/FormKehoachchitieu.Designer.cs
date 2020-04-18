namespace QuanLyChiTieu2
{
    partial class FormKehoachchitieu
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
            this.lable4 = new System.Windows.Forms.Label();
            this.lable3 = new System.Windows.Forms.Label();
            this.lable2 = new System.Windows.Forms.Label();
            this.lable1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_xoasukien = new System.Windows.Forms.Button();
            this.bt_themsukien = new System.Windows.Forms.Button();
            this.txt_ghichu = new System.Windows.Forms.TextBox();
            this.txt_sotiensechi = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_tensukien = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonQuaylai = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lable4
            // 
            this.lable4.AutoSize = true;
            this.lable4.Location = new System.Drawing.Point(37, 183);
            this.lable4.Name = "lable4";
            this.lable4.Size = new System.Drawing.Size(57, 17);
            this.lable4.TabIndex = 6;
            this.lable4.Text = "Ghi chú";
            // 
            // lable3
            // 
            this.lable3.AutoSize = true;
            this.lable3.Location = new System.Drawing.Point(37, 129);
            this.lable3.Name = "lable3";
            this.lable3.Size = new System.Drawing.Size(93, 17);
            this.lable3.TabIndex = 3;
            this.lable3.Text = "Số tiền sẽ chi";
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.Location = new System.Drawing.Point(37, 81);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(93, 17);
            this.lable2.TabIndex = 2;
            this.lable2.Text = "Ngày bắt đầu";
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(37, 34);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(82, 17);
            this.lable1.TabIndex = 1;
            this.lable1.Text = "Tên sự kiện";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonQuaylai);
            this.groupBox2.Controls.Add(this.bt_xoasukien);
            this.groupBox2.Controls.Add(this.bt_themsukien);
            this.groupBox2.Controls.Add(this.txt_ghichu);
            this.groupBox2.Controls.Add(this.lable4);
            this.groupBox2.Controls.Add(this.txt_sotiensechi);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.lable3);
            this.groupBox2.Controls.Add(this.lable2);
            this.groupBox2.Controls.Add(this.lable1);
            this.groupBox2.Controls.Add(this.txt_tensukien);
            this.groupBox2.Location = new System.Drawing.Point(12, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(799, 226);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // bt_xoasukien
            // 
            this.bt_xoasukien.Location = new System.Drawing.Point(576, 66);
            this.bt_xoasukien.Name = "bt_xoasukien";
            this.bt_xoasukien.Size = new System.Drawing.Size(142, 46);
            this.bt_xoasukien.TabIndex = 3;
            this.bt_xoasukien.Text = "Xóa sự kiện";
            this.bt_xoasukien.UseVisualStyleBackColor = true;
            this.bt_xoasukien.Click += new System.EventHandler(this.bt_xoasukien_Click);
            // 
            // bt_themsukien
            // 
            this.bt_themsukien.Location = new System.Drawing.Point(576, 21);
            this.bt_themsukien.Name = "bt_themsukien";
            this.bt_themsukien.Size = new System.Drawing.Size(142, 43);
            this.bt_themsukien.TabIndex = 2;
            this.bt_themsukien.Text = "Thêm sự kiện";
            this.bt_themsukien.UseVisualStyleBackColor = true;
            this.bt_themsukien.Click += new System.EventHandler(this.bt_themsukien_Click);
            // 
            // txt_ghichu
            // 
            this.txt_ghichu.Location = new System.Drawing.Point(156, 183);
            this.txt_ghichu.Name = "txt_ghichu";
            this.txt_ghichu.Size = new System.Drawing.Size(606, 22);
            this.txt_ghichu.TabIndex = 7;
            // 
            // txt_sotiensechi
            // 
            this.txt_sotiensechi.Location = new System.Drawing.Point(158, 126);
            this.txt_sotiensechi.Name = "txt_sotiensechi";
            this.txt_sotiensechi.Size = new System.Drawing.Size(282, 22);
            this.txt_sotiensechi.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(156, 76);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(284, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // txt_tensukien
            // 
            this.txt_tensukien.Location = new System.Drawing.Point(156, 31);
            this.txt_tensukien.Name = "txt_tensukien";
            this.txt_tensukien.Size = new System.Drawing.Size(284, 22);
            this.txt_tensukien.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(799, 238);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin kế hoạch chi tiêu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(788, 176);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonQuaylai
            // 
            this.buttonQuaylai.Location = new System.Drawing.Point(576, 117);
            this.buttonQuaylai.Name = "buttonQuaylai";
            this.buttonQuaylai.Size = new System.Drawing.Size(142, 41);
            this.buttonQuaylai.TabIndex = 8;
            this.buttonQuaylai.Text = "Quay lại ";
            this.buttonQuaylai.UseVisualStyleBackColor = true;
            this.buttonQuaylai.Click += new System.EventHandler(this.buttonQuaylai_Click);
            // 
            // FormKehoachchitieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 489);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormKehoachchitieu";
            this.Text = "Lên lịch chi tiêu";
            this.Load += new System.EventHandler(this.FormKehoachchitieu_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lable4;
        private System.Windows.Forms.Label lable3;
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_xoasukien;
        private System.Windows.Forms.Button bt_themsukien;
        private System.Windows.Forms.TextBox txt_ghichu;
        private System.Windows.Forms.TextBox txt_sotiensechi;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txt_tensukien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonQuaylai;
    }
}