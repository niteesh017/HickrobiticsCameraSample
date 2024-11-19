namespace HickrobiticsCameraSample
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbDeviceList = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnContinousMode = new System.Windows.Forms.RadioButton();
            this.btnTriggerMode = new System.Windows.Forms.RadioButton();
            this.btnStartGrab = new System.Windows.Forms.Button();
            this.btnStopGrab = new System.Windows.Forms.Button();
            this.cbSoftTrigger = new System.Windows.Forms.CheckBox();
            this.btnTriggerExecute = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSetparam = new System.Windows.Forms.Button();
            this.btnGetParam = new System.Windows.Forms.Button();
            this.lblFrameRate = new System.Windows.Forms.Label();
            this.txtBoxFrameRate = new System.Windows.Forms.TextBox();
            this.lblGain = new System.Windows.Forms.Label();
            this.txtBoxGain = new System.Windows.Forms.TextBox();
            this.lblExposureTime = new System.Windows.Forms.Label();
            this.txtBoxExposure = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSavePNG = new System.Windows.Forms.Button();
            this.btnSaveTiff = new System.Windows.Forms.Button();
            this.btnSaveJPG = new System.Windows.Forms.Button();
            this.btnSaveBMP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(52, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(594, 482);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cbDeviceList
            // 
            this.cbDeviceList.FormattingEnabled = true;
            this.cbDeviceList.Location = new System.Drawing.Point(52, 17);
            this.cbDeviceList.Name = "cbDeviceList";
            this.cbDeviceList.Size = new System.Drawing.Size(594, 21);
            this.cbDeviceList.TabIndex = 1;
            this.cbDeviceList.SelectedIndexChanged += new System.EventHandler(this.cbDeviceList_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(13, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(307, 33);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search Device";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.OliveDrab;
            this.btnOpen.Location = new System.Drawing.Point(13, 65);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(137, 31);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "Open Device";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Firebrick;
            this.btnClose.Location = new System.Drawing.Point(184, 65);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(136, 31);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close Device";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnContinousMode
            // 
            this.btnContinousMode.AutoSize = true;
            this.btnContinousMode.BackColor = System.Drawing.Color.OrangeRed;
            this.btnContinousMode.Location = new System.Drawing.Point(13, 31);
            this.btnContinousMode.Name = "btnContinousMode";
            this.btnContinousMode.Size = new System.Drawing.Size(72, 17);
            this.btnContinousMode.TabIndex = 5;
            this.btnContinousMode.TabStop = true;
            this.btnContinousMode.Text = "Continous";
            this.btnContinousMode.UseVisualStyleBackColor = false;
            this.btnContinousMode.CheckedChanged += new System.EventHandler(this.btnContinousMode_CheckedChanged);
            // 
            // btnTriggerMode
            // 
            this.btnTriggerMode.AutoSize = true;
            this.btnTriggerMode.BackColor = System.Drawing.Color.Yellow;
            this.btnTriggerMode.Location = new System.Drawing.Point(232, 31);
            this.btnTriggerMode.Name = "btnTriggerMode";
            this.btnTriggerMode.Size = new System.Drawing.Size(88, 17);
            this.btnTriggerMode.TabIndex = 6;
            this.btnTriggerMode.TabStop = true;
            this.btnTriggerMode.Text = "Trigger Mode";
            this.btnTriggerMode.UseVisualStyleBackColor = false;
            this.btnTriggerMode.CheckedChanged += new System.EventHandler(this.btnTriggerMode_CheckedChanged);
            // 
            // btnStartGrab
            // 
            this.btnStartGrab.BackColor = System.Drawing.Color.OliveDrab;
            this.btnStartGrab.Location = new System.Drawing.Point(13, 54);
            this.btnStartGrab.Name = "btnStartGrab";
            this.btnStartGrab.Size = new System.Drawing.Size(91, 29);
            this.btnStartGrab.TabIndex = 7;
            this.btnStartGrab.Text = "Start";
            this.btnStartGrab.UseVisualStyleBackColor = false;
            this.btnStartGrab.Click += new System.EventHandler(this.btnStartGrab_Click);
            // 
            // btnStopGrab
            // 
            this.btnStopGrab.BackColor = System.Drawing.Color.Firebrick;
            this.btnStopGrab.Location = new System.Drawing.Point(232, 54);
            this.btnStopGrab.Name = "btnStopGrab";
            this.btnStopGrab.Size = new System.Drawing.Size(88, 29);
            this.btnStopGrab.TabIndex = 8;
            this.btnStopGrab.Text = "Stop";
            this.btnStopGrab.UseVisualStyleBackColor = false;
            this.btnStopGrab.Click += new System.EventHandler(this.btnStopGrab_Click);
            // 
            // cbSoftTrigger
            // 
            this.cbSoftTrigger.AutoSize = true;
            this.cbSoftTrigger.BackColor = System.Drawing.Color.LightCoral;
            this.cbSoftTrigger.Location = new System.Drawing.Point(13, 100);
            this.cbSoftTrigger.Name = "cbSoftTrigger";
            this.cbSoftTrigger.Size = new System.Drawing.Size(119, 17);
            this.cbSoftTrigger.TabIndex = 9;
            this.cbSoftTrigger.Text = "Trigger By Software";
            this.cbSoftTrigger.UseVisualStyleBackColor = false;
            this.cbSoftTrigger.CheckedChanged += new System.EventHandler(this.cbSoftTrigger_CheckedChanged);
            // 
            // btnTriggerExecute
            // 
            this.btnTriggerExecute.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnTriggerExecute.Location = new System.Drawing.Point(232, 89);
            this.btnTriggerExecute.Name = "btnTriggerExecute";
            this.btnTriggerExecute.Size = new System.Drawing.Size(88, 30);
            this.btnTriggerExecute.TabIndex = 10;
            this.btnTriggerExecute.Text = "Trigger Once";
            this.btnTriggerExecute.UseVisualStyleBackColor = false;
            this.btnTriggerExecute.Click += new System.EventHandler(this.btnTriggerExecute_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Location = new System.Drawing.Point(691, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 111);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Initialization";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnContinousMode);
            this.groupBox2.Controls.Add(this.btnTriggerMode);
            this.groupBox2.Controls.Add(this.btnTriggerExecute);
            this.groupBox2.Controls.Add(this.btnStartGrab);
            this.groupBox2.Controls.Add(this.cbSoftTrigger);
            this.groupBox2.Controls.Add(this.btnStopGrab);
            this.groupBox2.Location = new System.Drawing.Point(691, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 129);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Image Acquisition";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSetparam);
            this.groupBox3.Controls.Add(this.btnGetParam);
            this.groupBox3.Controls.Add(this.lblFrameRate);
            this.groupBox3.Controls.Add(this.txtBoxFrameRate);
            this.groupBox3.Controls.Add(this.lblGain);
            this.groupBox3.Controls.Add(this.txtBoxGain);
            this.groupBox3.Controls.Add(this.lblExposureTime);
            this.groupBox3.Controls.Add(this.txtBoxExposure);
            this.groupBox3.Location = new System.Drawing.Point(691, 252);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(331, 161);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parameters";
            // 
            // btnSetparam
            // 
            this.btnSetparam.BackColor = System.Drawing.Color.Aqua;
            this.btnSetparam.Location = new System.Drawing.Point(184, 117);
            this.btnSetparam.Name = "btnSetparam";
            this.btnSetparam.Size = new System.Drawing.Size(136, 33);
            this.btnSetparam.TabIndex = 7;
            this.btnSetparam.Text = "Set Parameter";
            this.btnSetparam.UseVisualStyleBackColor = false;
            this.btnSetparam.Click += new System.EventHandler(this.btnSetparam_Click);
            // 
            // btnGetParam
            // 
            this.btnGetParam.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnGetParam.Location = new System.Drawing.Point(13, 117);
            this.btnGetParam.Name = "btnGetParam";
            this.btnGetParam.Size = new System.Drawing.Size(137, 33);
            this.btnGetParam.TabIndex = 6;
            this.btnGetParam.Text = "Get Parameter";
            this.btnGetParam.UseVisualStyleBackColor = false;
            this.btnGetParam.Click += new System.EventHandler(this.btnGetParam_Click);
            // 
            // lblFrameRate
            // 
            this.lblFrameRate.AutoSize = true;
            this.lblFrameRate.Location = new System.Drawing.Point(39, 89);
            this.lblFrameRate.Name = "lblFrameRate";
            this.lblFrameRate.Size = new System.Drawing.Size(59, 13);
            this.lblFrameRate.TabIndex = 5;
            this.lblFrameRate.Text = "FrameRate";
            // 
            // txtBoxFrameRate
            // 
            this.txtBoxFrameRate.Location = new System.Drawing.Point(166, 85);
            this.txtBoxFrameRate.Name = "txtBoxFrameRate";
            this.txtBoxFrameRate.Size = new System.Drawing.Size(154, 20);
            this.txtBoxFrameRate.TabIndex = 4;
            // 
            // lblGain
            // 
            this.lblGain.AutoSize = true;
            this.lblGain.Location = new System.Drawing.Point(40, 59);
            this.lblGain.Name = "lblGain";
            this.lblGain.Size = new System.Drawing.Size(29, 13);
            this.lblGain.TabIndex = 3;
            this.lblGain.Text = "Gain";
            // 
            // txtBoxGain
            // 
            this.txtBoxGain.Location = new System.Drawing.Point(166, 57);
            this.txtBoxGain.Name = "txtBoxGain";
            this.txtBoxGain.Size = new System.Drawing.Size(154, 20);
            this.txtBoxGain.TabIndex = 2;
            // 
            // lblExposureTime
            // 
            this.lblExposureTime.AutoSize = true;
            this.lblExposureTime.Location = new System.Drawing.Point(37, 33);
            this.lblExposureTime.Name = "lblExposureTime";
            this.lblExposureTime.Size = new System.Drawing.Size(74, 13);
            this.lblExposureTime.TabIndex = 1;
            this.lblExposureTime.Text = "ExposureTime";
            this.lblExposureTime.Click += new System.EventHandler(this.lblExposureTime_Click);
            // 
            // txtBoxExposure
            // 
            this.txtBoxExposure.Location = new System.Drawing.Point(166, 31);
            this.txtBoxExposure.Name = "txtBoxExposure";
            this.txtBoxExposure.Size = new System.Drawing.Size(154, 20);
            this.txtBoxExposure.TabIndex = 0;
            this.txtBoxExposure.TextChanged += new System.EventHandler(this.txtBoxExposure_TextChanged_1);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSavePNG);
            this.groupBox4.Controls.Add(this.btnSaveTiff);
            this.groupBox4.Controls.Add(this.btnSaveJPG);
            this.groupBox4.Controls.Add(this.btnSaveBMP);
            this.groupBox4.Location = new System.Drawing.Point(691, 416);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(331, 121);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Picture Storage";
            // 
            // btnSavePNG
            // 
            this.btnSavePNG.Location = new System.Drawing.Point(184, 71);
            this.btnSavePNG.Name = "btnSavePNG";
            this.btnSavePNG.Size = new System.Drawing.Size(137, 33);
            this.btnSavePNG.TabIndex = 3;
            this.btnSavePNG.Text = "Save as PNG";
            this.btnSavePNG.UseVisualStyleBackColor = true;
            this.btnSavePNG.Click += new System.EventHandler(this.btnSavePNG_Click);
            // 
            // btnSaveTiff
            // 
            this.btnSaveTiff.Location = new System.Drawing.Point(13, 71);
            this.btnSaveTiff.Name = "btnSaveTiff";
            this.btnSaveTiff.Size = new System.Drawing.Size(137, 33);
            this.btnSaveTiff.TabIndex = 2;
            this.btnSaveTiff.Text = "Save as TIFF";
            this.btnSaveTiff.UseVisualStyleBackColor = true;
            this.btnSaveTiff.Click += new System.EventHandler(this.btnSaveTiff_Click);
            // 
            // btnSaveJPG
            // 
            this.btnSaveJPG.Location = new System.Drawing.Point(183, 32);
            this.btnSaveJPG.Name = "btnSaveJPG";
            this.btnSaveJPG.Size = new System.Drawing.Size(137, 33);
            this.btnSaveJPG.TabIndex = 1;
            this.btnSaveJPG.Text = "Save as JPG";
            this.btnSaveJPG.UseVisualStyleBackColor = true;
            this.btnSaveJPG.Click += new System.EventHandler(this.btnSaveJPG_Click);
            // 
            // btnSaveBMP
            // 
            this.btnSaveBMP.Location = new System.Drawing.Point(13, 32);
            this.btnSaveBMP.Name = "btnSaveBMP";
            this.btnSaveBMP.Size = new System.Drawing.Size(137, 33);
            this.btnSaveBMP.TabIndex = 0;
            this.btnSaveBMP.Text = "Save as BMP";
            this.btnSaveBMP.UseVisualStyleBackColor = true;
            this.btnSaveBMP.Click += new System.EventHandler(this.btnSaveBMP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 566);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbDeviceList);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbDeviceList;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RadioButton btnContinousMode;
        private System.Windows.Forms.RadioButton btnTriggerMode;
        private System.Windows.Forms.Button btnStartGrab;
        private System.Windows.Forms.Button btnStopGrab;
        private System.Windows.Forms.CheckBox cbSoftTrigger;
        private System.Windows.Forms.Button btnTriggerExecute;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblExposureTime;
        private System.Windows.Forms.TextBox txtBoxExposure;
        private System.Windows.Forms.Button btnSetparam;
        private System.Windows.Forms.Button btnGetParam;
        private System.Windows.Forms.Label lblFrameRate;
        private System.Windows.Forms.TextBox txtBoxFrameRate;
        private System.Windows.Forms.Label lblGain;
        private System.Windows.Forms.TextBox txtBoxGain;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSavePNG;
        private System.Windows.Forms.Button btnSaveTiff;
        private System.Windows.Forms.Button btnSaveJPG;
        private System.Windows.Forms.Button btnSaveBMP;
    }
}

