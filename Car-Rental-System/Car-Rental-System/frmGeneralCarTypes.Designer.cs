namespace Car_Rental_System
{
    partial class frmGeneralCarTypes
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
            this.btnSUV = new System.Windows.Forms.Button();
            this.btnSedan = new System.Windows.Forms.Button();
            this.btnHatchBack = new System.Windows.Forms.Button();
            this.pbHatchBack = new System.Windows.Forms.PictureBox();
            this.pbSedan = new System.Windows.Forms.PictureBox();
            this.pbSUV = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbHatchBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSedan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSUV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSUV
            // 
            this.btnSUV.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnSUV.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSUV.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSUV.Location = new System.Drawing.Point(77, 310);
            this.btnSUV.Name = "btnSUV";
            this.btnSUV.Size = new System.Drawing.Size(117, 34);
            this.btnSUV.TabIndex = 3;
            this.btnSUV.Text = "SUV";
            this.btnSUV.UseVisualStyleBackColor = false;
            this.btnSUV.Click += new System.EventHandler(this.btnSUV_Click);
            // 
            // btnSedan
            // 
            this.btnSedan.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnSedan.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSedan.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSedan.Location = new System.Drawing.Point(345, 310);
            this.btnSedan.Name = "btnSedan";
            this.btnSedan.Size = new System.Drawing.Size(117, 34);
            this.btnSedan.TabIndex = 4;
            this.btnSedan.Text = "Sedan";
            this.btnSedan.UseVisualStyleBackColor = false;
            // 
            // btnHatchBack
            // 
            this.btnHatchBack.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnHatchBack.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHatchBack.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnHatchBack.Location = new System.Drawing.Point(613, 310);
            this.btnHatchBack.Name = "btnHatchBack";
            this.btnHatchBack.Size = new System.Drawing.Size(117, 34);
            this.btnHatchBack.TabIndex = 5;
            this.btnHatchBack.Text = "HatchBack";
            this.btnHatchBack.UseVisualStyleBackColor = false;
            // 
            // pbHatchBack
            // 
            this.pbHatchBack.Image = global::Car_Rental_System.Properties.Resources.HatchBack2;
            this.pbHatchBack.Location = new System.Drawing.Point(584, 120);
            this.pbHatchBack.Name = "pbHatchBack";
            this.pbHatchBack.Size = new System.Drawing.Size(174, 171);
            this.pbHatchBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHatchBack.TabIndex = 2;
            this.pbHatchBack.TabStop = false;
            // 
            // pbSedan
            // 
            this.pbSedan.Image = global::Car_Rental_System.Properties.Resources.Sedan2;
            this.pbSedan.Location = new System.Drawing.Point(316, 120);
            this.pbSedan.Name = "pbSedan";
            this.pbSedan.Size = new System.Drawing.Size(174, 171);
            this.pbSedan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSedan.TabIndex = 1;
            this.pbSedan.TabStop = false;
            // 
            // pbSUV
            // 
            this.pbSUV.Image = global::Car_Rental_System.Properties.Resources.SUV;
            this.pbSUV.Location = new System.Drawing.Point(48, 120);
            this.pbSUV.Name = "pbSUV";
            this.pbSUV.Size = new System.Drawing.Size(174, 171);
            this.pbSUV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSUV.TabIndex = 0;
            this.pbSUV.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(240, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 45);
            this.label1.TabIndex = 6;
            this.label1.Text = "Car Rental System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmGeneralCarTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(821, 478);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHatchBack);
            this.Controls.Add(this.btnSedan);
            this.Controls.Add(this.btnSUV);
            this.Controls.Add(this.pbHatchBack);
            this.Controls.Add(this.pbSedan);
            this.Controls.Add(this.pbSUV);
            this.Name = "frmGeneralCarTypes";
            this.Text = "frmGeneralCarTypes";
            ((System.ComponentModel.ISupportInitialize)(this.pbHatchBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSedan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSUV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSUV;
        private System.Windows.Forms.PictureBox pbSedan;
        private System.Windows.Forms.PictureBox pbHatchBack;
        private System.Windows.Forms.Button btnSUV;
        private System.Windows.Forms.Button btnSedan;
        private System.Windows.Forms.Button btnHatchBack;
        private System.Windows.Forms.Label label1;
    }
}