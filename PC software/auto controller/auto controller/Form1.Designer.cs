namespace auto_controller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVooruit = new System.Windows.Forms.Button();
            this.btnAchteruit = new System.Windows.Forms.Button();
            this.btnLinks = new System.Windows.Forms.Button();
            this.btnRechts = new System.Windows.Forms.Button();
            this.btnLichtAAN = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.txbComPoort = new System.Windows.Forms.TextBox();
            this.lblComPoort = new System.Windows.Forms.Label();
            this.btnLicht2Aan = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblServo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::auto_controller.Properties.Resources.logo;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Name = "label1";
            // 
            // btnVooruit
            // 
            resources.ApplyResources(this.btnVooruit, "btnVooruit");
            this.btnVooruit.Name = "btnVooruit";
            this.btnVooruit.UseVisualStyleBackColor = true;
            this.btnVooruit.Click += new System.EventHandler(this.btnVooruit_Click);
            // 
            // btnAchteruit
            // 
            resources.ApplyResources(this.btnAchteruit, "btnAchteruit");
            this.btnAchteruit.Name = "btnAchteruit";
            this.btnAchteruit.UseVisualStyleBackColor = true;
            this.btnAchteruit.Click += new System.EventHandler(this.btnAchteruit_Click);
            // 
            // btnLinks
            // 
            resources.ApplyResources(this.btnLinks, "btnLinks");
            this.btnLinks.Name = "btnLinks";
            this.btnLinks.UseVisualStyleBackColor = true;
            this.btnLinks.Click += new System.EventHandler(this.btnLinks_Click);
            // 
            // btnRechts
            // 
            resources.ApplyResources(this.btnRechts, "btnRechts");
            this.btnRechts.Name = "btnRechts";
            this.btnRechts.UseVisualStyleBackColor = true;
            this.btnRechts.Click += new System.EventHandler(this.btnRechts_Click);
            // 
            // btnLichtAAN
            // 
            resources.ApplyResources(this.btnLichtAAN, "btnLichtAAN");
            this.btnLichtAAN.Name = "btnLichtAAN";
            this.btnLichtAAN.UseVisualStyleBackColor = true;
            this.btnLichtAAN.Click += new System.EventHandler(this.btnLichtAAN_Click);
            // 
            // btnConnect
            // 
            resources.ApplyResources(this.btnConnect, "btnConnect");
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnStop
            // 
            resources.ApplyResources(this.btnStop, "btnStop");
            this.btnStop.Name = "btnStop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // trackBar1
            // 
            resources.ApplyResources(this.trackBar1, "trackBar1");
            this.trackBar1.Maximum = 180;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // txbComPoort
            // 
            resources.ApplyResources(this.txbComPoort, "txbComPoort");
            this.txbComPoort.Name = "txbComPoort";
            // 
            // lblComPoort
            // 
            resources.ApplyResources(this.lblComPoort, "lblComPoort");
            this.lblComPoort.Name = "lblComPoort";
            // 
            // btnLicht2Aan
            // 
            resources.ApplyResources(this.btnLicht2Aan, "btnLicht2Aan");
            this.btnLicht2Aan.Name = "btnLicht2Aan";
            this.btnLicht2Aan.UseVisualStyleBackColor = true;
            this.btnLicht2Aan.Click += new System.EventHandler(this.btnLicht2Aan_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // lblStatus
            // 
            resources.ApplyResources(this.lblStatus, "lblStatus");
            this.lblStatus.Name = "lblStatus";
            // 
            // lblServo
            // 
            resources.ApplyResources(this.lblServo, "lblServo");
            this.lblServo.Name = "lblServo";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblServo);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLicht2Aan);
            this.Controls.Add(this.lblComPoort);
            this.Controls.Add(this.txbComPoort);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnLichtAAN);
            this.Controls.Add(this.btnRechts);
            this.Controls.Add(this.btnLinks);
            this.Controls.Add(this.btnAchteruit);
            this.Controls.Add(this.btnVooruit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVooruit;
        private System.Windows.Forms.Button btnAchteruit;
        private System.Windows.Forms.Button btnLinks;
        private System.Windows.Forms.Button btnRechts;
        private System.Windows.Forms.Button btnLichtAAN;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox txbComPoort;
        private System.Windows.Forms.Label lblComPoort;
        private System.Windows.Forms.Button btnLicht2Aan;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblServo;
        private System.Windows.Forms.Label label3;
    }
}

