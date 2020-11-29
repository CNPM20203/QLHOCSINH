
namespace UI
{
    partial class GiaoDien
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
            this.btnQLHS = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnQLL = new System.Windows.Forms.Button();
            this.btnQLD = new System.Windows.Forms.Button();
            this.btnDHK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQLHS
            // 
            this.btnQLHS.Location = new System.Drawing.Point(143, 69);
            this.btnQLHS.Margin = new System.Windows.Forms.Padding(2);
            this.btnQLHS.Name = "btnQLHS";
            this.btnQLHS.Size = new System.Drawing.Size(125, 30);
            this.btnQLHS.TabIndex = 4;
            this.btnQLHS.Text = "Quản lý học sinh";
            this.btnQLHS.UseVisualStyleBackColor = true;
            this.btnQLHS.Click += new System.EventHandler(this.btnQLHS_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(165, 342);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 42);
            this.button2.TabIndex = 5;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnQLL
            // 
            this.btnQLL.Location = new System.Drawing.Point(143, 123);
            this.btnQLL.Name = "btnQLL";
            this.btnQLL.Size = new System.Drawing.Size(125, 30);
            this.btnQLL.TabIndex = 6;
            this.btnQLL.Text = "Quản lý lớp";
            this.btnQLL.UseVisualStyleBackColor = true;
            this.btnQLL.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnQLD
            // 
            this.btnQLD.Location = new System.Drawing.Point(143, 184);
            this.btnQLD.Name = "btnQLD";
            this.btnQLD.Size = new System.Drawing.Size(125, 29);
            this.btnQLD.TabIndex = 7;
            this.btnQLD.Text = "Quản lý điểm học tập";
            this.btnQLD.UseVisualStyleBackColor = true;
            this.btnQLD.Click += new System.EventHandler(this.btnQLD_Click);
            // 
            // btnDHK
            // 
            this.btnDHK.Location = new System.Drawing.Point(143, 245);
            this.btnDHK.Name = "btnDHK";
            this.btnDHK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDHK.Size = new System.Drawing.Size(125, 29);
            this.btnDHK.TabIndex = 8;
            this.btnDHK.Text = "Quản lý điểm học kỳ";
            this.btnDHK.UseVisualStyleBackColor = true;
            this.btnDHK.Click += new System.EventHandler(this.btnDHK_Click);
            // 
            // GiaoDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 413);
            this.Controls.Add(this.btnDHK);
            this.Controls.Add(this.btnQLD);
            this.Controls.Add(this.btnQLL);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnQLHS);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GiaoDien";
            this.Text = "Chương trình quản lý";
            this.Load += new System.EventHandler(this.GiaoDien_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnQLHS;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnQLL;
        private System.Windows.Forms.Button btnQLD;
        private System.Windows.Forms.Button btnDHK;
    }
}

