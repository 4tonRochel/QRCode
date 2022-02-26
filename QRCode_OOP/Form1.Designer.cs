
namespace QRCode_OOP
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblcam = new System.Windows.Forms.Label();
            this.cbxCam = new System.Windows.Forms.ComboBox();
            this.pbxQR = new System.Windows.Forms.PictureBox();
            this.btnScan = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxQR)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcam
            // 
            this.lblcam.AutoSize = true;
            this.lblcam.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcam.Location = new System.Drawing.Point(38, 346);
            this.lblcam.Name = "lblcam";
            this.lblcam.Size = new System.Drawing.Size(63, 15);
            this.lblcam.TabIndex = 0;
            this.lblcam.Text = "Camera";
            this.lblcam.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbxCam
            // 
            this.cbxCam.FormattingEnabled = true;
            this.cbxCam.Location = new System.Drawing.Point(104, 343);
            this.cbxCam.Name = "cbxCam";
            this.cbxCam.Size = new System.Drawing.Size(121, 21);
            this.cbxCam.TabIndex = 1;
            this.cbxCam.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pbxQR
            // 
            this.pbxQR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxQR.Location = new System.Drawing.Point(1, 54);
            this.pbxQR.Name = "pbxQR";
            this.pbxQR.Size = new System.Drawing.Size(268, 283);
            this.pbxQR.TabIndex = 2;
            this.pbxQR.TabStop = false;
            this.pbxQR.Click += new System.EventHandler(this.pbxQR_Click);
            // 
            // btnScan
            // 
            this.btnScan.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnScan.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScan.Location = new System.Drawing.Point(58, 12);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(167, 31);
            this.btnScan.TabIndex = 3;
            this.btnScan.Text = "Start Scan";
            this.btnScan.UseVisualStyleBackColor = false;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(270, 368);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.pbxQR);
            this.Controls.Add(this.cbxCam);
            this.Controls.Add(this.lblcam);
            this.Name = "Form1";
            this.Text = "QR Scanner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcam;
        private System.Windows.Forms.ComboBox cbxCam;
        private System.Windows.Forms.PictureBox pbxQR;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Timer timer1;
    }
}

