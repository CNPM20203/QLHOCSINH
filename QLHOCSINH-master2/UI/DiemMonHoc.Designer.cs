namespace UI
{
    partial class DiemMonHoc
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDHocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diem15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diem1T = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoaDMH = new System.Windows.Forms.Button();
            this.btnThemDMH = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDHocSinh,
            this.HoTen,
            this.NgaySinh,
            this.IDMonHoc,
            this.Diem15,
            this.Diem1T,
            this.DiemTB});
            this.dataGridView1.Location = new System.Drawing.Point(12, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(895, 337);
            this.dataGridView1.TabIndex = 5;
            // 
            // IDHocSinh
            // 
            this.IDHocSinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDHocSinh.HeaderText = "ID";
            this.IDHocSinh.Name = "IDHocSinh";
            // 
            // HoTen
            // 
            this.HoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.Name = "HoTen";
            // 
            // NgaySinh
            // 
            this.NgaySinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // IDMonHoc
            // 
            this.IDMonHoc.HeaderText = "Môn";
            this.IDMonHoc.Name = "IDMonHoc";
            // 
            // Diem15
            // 
            this.Diem15.HeaderText = "15P";
            this.Diem15.Name = "Diem15";
            // 
            // Diem1T
            // 
            this.Diem1T.HeaderText = "1 Tiết";
            this.Diem1T.Name = "Diem1T";
            // 
            // DiemTB
            // 
            this.DiemTB.HeaderText = "TB";
            this.DiemTB.Name = "DiemTB";
            // 
            // btnXoaDMH
            // 
            this.btnXoaDMH.Location = new System.Drawing.Point(140, 29);
            this.btnXoaDMH.Name = "btnXoaDMH";
            this.btnXoaDMH.Size = new System.Drawing.Size(75, 23);
            this.btnXoaDMH.TabIndex = 7;
            this.btnXoaDMH.Text = "Xóa";
            this.btnXoaDMH.UseVisualStyleBackColor = true;
            // 
            // btnThemDMH
            // 
            this.btnThemDMH.Location = new System.Drawing.Point(59, 29);
            this.btnThemDMH.Name = "btnThemDMH";
            this.btnThemDMH.Size = new System.Drawing.Size(75, 23);
            this.btnThemDMH.TabIndex = 6;
            this.btnThemDMH.Text = "Thêm";
            this.btnThemDMH.UseVisualStyleBackColor = true;
            this.btnThemDMH.Click += new System.EventHandler(this.btnThemDMH_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Môn:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(378, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(832, 72);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "Refresh";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // DiemMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXoaDMH);
            this.Controls.Add(this.btnThemDMH);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DiemMonHoc";
            this.Text = "Quản lý điểm học tập";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diem15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diem1T;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemTB;
        private System.Windows.Forms.Button btnXoaDMH;
        private System.Windows.Forms.Button btnThemDMH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button5;
    }
}