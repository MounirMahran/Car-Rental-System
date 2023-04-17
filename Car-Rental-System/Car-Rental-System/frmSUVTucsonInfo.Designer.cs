namespace Car_Rental_System
{
    partial class frmSUVTucsonInfo
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbPhoto5 = new System.Windows.Forms.RadioButton();
            this.rbPhoto4 = new System.Windows.Forms.RadioButton();
            this.rbPhoto3 = new System.Windows.Forms.RadioButton();
            this.rbPhoto2 = new System.Windows.Forms.RadioButton();
            this.rbPhoto1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPice = new System.Windows.Forms.Label();
            this.lblMaxSpeed = new System.Windows.Forms.Label();
            this.lblTransmission = new System.Windows.Forms.Label();
            this.lblHorsePower = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRentJeep = new System.Windows.Forms.Button();
            this.pbTucson = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTucson)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(76, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "2021";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(6, 17);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(59, 23);
            this.lblModel.TabIndex = 0;
            this.lblModel.Text = "Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(75, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "SeaWeed";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbPhoto5);
            this.groupBox2.Controls.Add(this.rbPhoto4);
            this.groupBox2.Controls.Add(this.rbPhoto3);
            this.groupBox2.Controls.Add(this.rbPhoto2);
            this.groupBox2.Controls.Add(this.rbPhoto1);
            this.groupBox2.Location = new System.Drawing.Point(411, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(381, 176);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Photos";
            // 
            // rbPhoto5
            // 
            this.rbPhoto5.AutoSize = true;
            this.rbPhoto5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPhoto5.Location = new System.Drawing.Point(281, 127);
            this.rbPhoto5.Name = "rbPhoto5";
            this.rbPhoto5.Size = new System.Drawing.Size(70, 20);
            this.rbPhoto5.TabIndex = 4;
            this.rbPhoto5.TabStop = true;
            this.rbPhoto5.Text = "Photo 5";
            this.rbPhoto5.UseVisualStyleBackColor = true;
            this.rbPhoto5.CheckedChanged += new System.EventHandler(this.rbPhoto5_CheckedChanged);
            // 
            // rbPhoto4
            // 
            this.rbPhoto4.AutoSize = true;
            this.rbPhoto4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPhoto4.Location = new System.Drawing.Point(281, 47);
            this.rbPhoto4.Name = "rbPhoto4";
            this.rbPhoto4.Size = new System.Drawing.Size(70, 20);
            this.rbPhoto4.TabIndex = 3;
            this.rbPhoto4.TabStop = true;
            this.rbPhoto4.Text = "Photo 4";
            this.rbPhoto4.UseVisualStyleBackColor = true;
            this.rbPhoto4.CheckedChanged += new System.EventHandler(this.rbPhoto4_CheckedChanged);
            // 
            // rbPhoto3
            // 
            this.rbPhoto3.AutoSize = true;
            this.rbPhoto3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPhoto3.Location = new System.Drawing.Point(31, 153);
            this.rbPhoto3.Name = "rbPhoto3";
            this.rbPhoto3.Size = new System.Drawing.Size(70, 20);
            this.rbPhoto3.TabIndex = 2;
            this.rbPhoto3.TabStop = true;
            this.rbPhoto3.Text = "Photo 3";
            this.rbPhoto3.UseVisualStyleBackColor = true;
            this.rbPhoto3.CheckedChanged += new System.EventHandler(this.rbPhoto3_CheckedChanged);
            // 
            // rbPhoto2
            // 
            this.rbPhoto2.AutoSize = true;
            this.rbPhoto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPhoto2.Location = new System.Drawing.Point(31, 88);
            this.rbPhoto2.Name = "rbPhoto2";
            this.rbPhoto2.Size = new System.Drawing.Size(70, 20);
            this.rbPhoto2.TabIndex = 1;
            this.rbPhoto2.TabStop = true;
            this.rbPhoto2.Text = "Photo 2";
            this.rbPhoto2.UseVisualStyleBackColor = true;
            this.rbPhoto2.CheckedChanged += new System.EventHandler(this.rbPhoto2_CheckedChanged);
            // 
            // rbPhoto1
            // 
            this.rbPhoto1.AutoSize = true;
            this.rbPhoto1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPhoto1.Location = new System.Drawing.Point(31, 23);
            this.rbPhoto1.Name = "rbPhoto1";
            this.rbPhoto1.Size = new System.Drawing.Size(70, 20);
            this.rbPhoto1.TabIndex = 0;
            this.rbPhoto1.TabStop = true;
            this.rbPhoto1.Text = "Photo 1";
            this.rbPhoto1.UseVisualStyleBackColor = true;
            this.rbPhoto1.CheckedChanged += new System.EventHandler(this.rbPhoto1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPice);
            this.groupBox1.Controls.Add(this.lblMaxSpeed);
            this.groupBox1.Controls.Add(this.lblTransmission);
            this.groupBox1.Controls.Add(this.lblHorsePower);
            this.groupBox1.Controls.Add(this.lblColor);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblModel);
            this.groupBox1.Location = new System.Drawing.Point(8, 252);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 177);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Car Specs";
            // 
            // lblPice
            // 
            this.lblPice.AutoSize = true;
            this.lblPice.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPice.Location = new System.Drawing.Point(236, 146);
            this.lblPice.Name = "lblPice";
            this.lblPice.Size = new System.Drawing.Size(51, 23);
            this.lblPice.TabIndex = 16;
            this.lblPice.Text = "Price";
            // 
            // lblMaxSpeed
            // 
            this.lblMaxSpeed.AutoSize = true;
            this.lblMaxSpeed.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxSpeed.Location = new System.Drawing.Point(212, 81);
            this.lblMaxSpeed.Name = "lblMaxSpeed";
            this.lblMaxSpeed.Size = new System.Drawing.Size(98, 23);
            this.lblMaxSpeed.TabIndex = 15;
            this.lblMaxSpeed.Text = "Max. Speed";
            // 
            // lblTransmission
            // 
            this.lblTransmission.AutoSize = true;
            this.lblTransmission.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransmission.Location = new System.Drawing.Point(202, 17);
            this.lblTransmission.Name = "lblTransmission";
            this.lblTransmission.Size = new System.Drawing.Size(118, 23);
            this.lblTransmission.TabIndex = 14;
            this.lblTransmission.Text = "Transmission";
            // 
            // lblHorsePower
            // 
            this.lblHorsePower.AutoSize = true;
            this.lblHorsePower.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorsePower.Location = new System.Drawing.Point(6, 146);
            this.lblHorsePower.Name = "lblHorsePower";
            this.lblHorsePower.Size = new System.Drawing.Size(110, 23);
            this.lblHorsePower.TabIndex = 13;
            this.lblHorsePower.Text = "Horse Power";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(6, 81);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(53, 23);
            this.lblColor.TabIndex = 12;
            this.lblColor.Text = "Color";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(307, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "$80 Per Day";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(329, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "190";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(329, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 16);
            this.label11.TabIndex = 7;
            this.label11.Text = "Auto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(133, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "120";
            // 
            // btnRentJeep
            // 
            this.btnRentJeep.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnRentJeep.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentJeep.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRentJeep.Location = new System.Drawing.Point(675, 155);
            this.btnRentJeep.Name = "btnRentJeep";
            this.btnRentJeep.Size = new System.Drawing.Size(117, 34);
            this.btnRentJeep.TabIndex = 18;
            this.btnRentJeep.Text = "Rent Now";
            this.btnRentJeep.UseVisualStyleBackColor = false;
            this.btnRentJeep.Click += new System.EventHandler(this.btnRentJeep_Click);
            // 
            // pbTucson
            // 
            this.pbTucson.Image = global::Car_Rental_System.Properties.Resources._2022_Hyundai_Tucson_Review11;
            this.pbTucson.Location = new System.Drawing.Point(168, 22);
            this.pbTucson.Name = "pbTucson";
            this.pbTucson.Size = new System.Drawing.Size(447, 224);
            this.pbTucson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTucson.TabIndex = 16;
            this.pbTucson.TabStop = false;
            // 
            // frmSUVTucsonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbTucson);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRentJeep);
            this.Name = "frmSUVTucsonInfo";
            this.Text = "frmSUVTucsonInfo";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTucson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTucson;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblModel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbPhoto5;
        private System.Windows.Forms.RadioButton rbPhoto4;
        private System.Windows.Forms.RadioButton rbPhoto3;
        private System.Windows.Forms.RadioButton rbPhoto2;
        private System.Windows.Forms.RadioButton rbPhoto1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPice;
        private System.Windows.Forms.Label lblMaxSpeed;
        private System.Windows.Forms.Label lblTransmission;
        private System.Windows.Forms.Label lblHorsePower;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRentJeep;
    }
}