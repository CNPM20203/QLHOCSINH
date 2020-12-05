
namespace UI
{
    partial class Lop
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
            this.btnPhanPhoi = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.IDLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDKhoiLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDLop,
            this.IDKhoiLop,
            this.SiSo});
            this.dataGridView1.Location = new System.Drawing.Point(183, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(485, 337);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnPhanPhoi
            // 
            this.btnPhanPhoi.Location = new System.Drawing.Point(35, 135);
            this.btnPhanPhoi.Name = "btnPhanPhoi";
            this.btnPhanPhoi.Size = new System.Drawing.Size(112, 55);
            this.btnPhanPhoi.TabIndex = 7;
            this.btnPhanPhoi.Text = "Phân phối học sinh";
            this.btnPhanPhoi.UseVisualStyleBackColor = true;
            this.btnPhanPhoi.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(93, 282);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 64);
            this.button5.TabIndex = 8;
            this.button5.Text = "Refresh";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 55);
            this.button1.TabIndex = 9;
            this.button1.Text = "Them Lop";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(35, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 55);
            this.button2.TabIndex = 10;
            this.button2.Text = "Xoa lop";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // IDLop
            // 
            this.IDLop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDLop.HeaderText = "IDLop";
            this.IDLop.Name = "IDLop";
            // 
            // IDKhoiLop
            // 
            this.IDKhoiLop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDKhoiLop.HeaderText = "Lop";
            this.IDKhoiLop.Name = "IDKhoiLop";
            // 
            // SiSo
            // 
            this.SiSo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SiSo.HeaderText = "SiSo";
            this.SiSo.Name = "SiSo";
            // 
            // Lop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 362);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnPhanPhoi);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Lop";
            this.Text = "Quản lý lớp";
            this.Load += new System.EventHandler(this.Lop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPhanPhoi;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDKhoiLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiSo;
    }
}