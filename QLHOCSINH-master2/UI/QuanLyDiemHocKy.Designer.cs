namespace UI
{
    partial class QuanLyDiemHocKy
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
            this.IDLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDHocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiLe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDLop,
            this.IDHocKy,
            this.SoLuongDat,
            this.TiLe});
            this.dataGridView1.Location = new System.Drawing.Point(12, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(711, 337);
            this.dataGridView1.TabIndex = 7;
            // 
            // IDLop
            // 
            this.IDLop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDLop.HeaderText = "Lớp";
            this.IDLop.Name = "IDLop";
            // 
            // IDHocKy
            // 
            this.IDHocKy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDHocKy.HeaderText = "Học kỳ";
            this.IDHocKy.Name = "IDHocKy";
            // 
            // SoLuongDat
            // 
            this.SoLuongDat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoLuongDat.HeaderText = "Số lượng đạt";
            this.SoLuongDat.Name = "SoLuongDat";
            // 
            // TiLe
            // 
            this.TiLe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TiLe.HeaderText = "Tỉ lệ";
            this.TiLe.Name = "TiLe";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(127, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 83);
            this.button2.TabIndex = 10;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 83);
            this.button1.TabIndex = 9;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(648, 72);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "Refresh";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // QuanLyDiemHocKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "QuanLyDiemHocKy";
            this.Text = "Quản lý điểm học kỳ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDHocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiLe;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
    }
}