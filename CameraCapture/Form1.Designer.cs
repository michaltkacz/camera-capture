namespace CameraCapture
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
            this.devicesComboBox = new System.Windows.Forms.ComboBox();
            this.findDevicesButton = new System.Windows.Forms.Button();
            this.displayPictureBox = new System.Windows.Forms.PictureBox();
            this.startCameraButton = new System.Windows.Forms.Button();
            this.stopCameraButton = new System.Windows.Forms.Button();
            this.screenshotButton = new System.Windows.Forms.Button();
            this.brightnessTrackBar = new System.Windows.Forms.TrackBar();
            this.saturationTrackBar = new System.Windows.Forms.TrackBar();
            this.contrastTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.flipXCheckBox = new System.Windows.Forms.CheckBox();
            this.movementDetectionCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.displayPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturationTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // devicesComboBox
            // 
            this.devicesComboBox.FormattingEnabled = true;
            this.devicesComboBox.Location = new System.Drawing.Point(114, 13);
            this.devicesComboBox.Name = "devicesComboBox";
            this.devicesComboBox.Size = new System.Drawing.Size(206, 21);
            this.devicesComboBox.TabIndex = 0;
            // 
            // findDevicesButton
            // 
            this.findDevicesButton.Location = new System.Drawing.Point(13, 11);
            this.findDevicesButton.Name = "findDevicesButton";
            this.findDevicesButton.Size = new System.Drawing.Size(95, 23);
            this.findDevicesButton.TabIndex = 1;
            this.findDevicesButton.Text = "Find Devices";
            this.findDevicesButton.UseVisualStyleBackColor = true;
            this.findDevicesButton.Click += new System.EventHandler(this.findDevicesButton_Click);
            // 
            // displayPictureBox
            // 
            this.displayPictureBox.Location = new System.Drawing.Point(13, 43);
            this.displayPictureBox.Name = "displayPictureBox";
            this.displayPictureBox.Size = new System.Drawing.Size(775, 344);
            this.displayPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.displayPictureBox.TabIndex = 2;
            this.displayPictureBox.TabStop = false;
            // 
            // startCameraButton
            // 
            this.startCameraButton.Enabled = false;
            this.startCameraButton.Location = new System.Drawing.Point(326, 11);
            this.startCameraButton.Name = "startCameraButton";
            this.startCameraButton.Size = new System.Drawing.Size(76, 23);
            this.startCameraButton.TabIndex = 3;
            this.startCameraButton.Text = "Start Camera";
            this.startCameraButton.UseVisualStyleBackColor = true;
            this.startCameraButton.Click += new System.EventHandler(this.startCameraButton_Click);
            // 
            // stopCameraButton
            // 
            this.stopCameraButton.Enabled = false;
            this.stopCameraButton.Location = new System.Drawing.Point(408, 11);
            this.stopCameraButton.Name = "stopCameraButton";
            this.stopCameraButton.Size = new System.Drawing.Size(84, 23);
            this.stopCameraButton.TabIndex = 4;
            this.stopCameraButton.Text = "Stop Camera";
            this.stopCameraButton.UseVisualStyleBackColor = true;
            this.stopCameraButton.Click += new System.EventHandler(this.stopCameraButton_Click);
            // 
            // screenshotButton
            // 
            this.screenshotButton.Enabled = false;
            this.screenshotButton.Location = new System.Drawing.Point(498, 11);
            this.screenshotButton.Name = "screenshotButton";
            this.screenshotButton.Size = new System.Drawing.Size(75, 23);
            this.screenshotButton.TabIndex = 5;
            this.screenshotButton.Text = "Screenshot";
            this.screenshotButton.UseVisualStyleBackColor = true;
            this.screenshotButton.Click += new System.EventHandler(this.screenshotButton_Click);
            // 
            // brightnessTrackBar
            // 
            this.brightnessTrackBar.Enabled = false;
            this.brightnessTrackBar.Location = new System.Drawing.Point(78, 393);
            this.brightnessTrackBar.Name = "brightnessTrackBar";
            this.brightnessTrackBar.Size = new System.Drawing.Size(154, 45);
            this.brightnessTrackBar.TabIndex = 6;
            // 
            // saturationTrackBar
            // 
            this.saturationTrackBar.Enabled = false;
            this.saturationTrackBar.Location = new System.Drawing.Point(349, 394);
            this.saturationTrackBar.Name = "saturationTrackBar";
            this.saturationTrackBar.Size = new System.Drawing.Size(154, 45);
            this.saturationTrackBar.TabIndex = 7;
            // 
            // contrastTrackBar
            // 
            this.contrastTrackBar.Enabled = false;
            this.contrastTrackBar.Location = new System.Drawing.Point(634, 393);
            this.contrastTrackBar.Name = "contrastTrackBar";
            this.contrastTrackBar.Size = new System.Drawing.Size(154, 45);
            this.contrastTrackBar.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Brightness:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Saturation:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(579, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Contrast:";
            // 
            // flipXCheckBox
            // 
            this.flipXCheckBox.AutoSize = true;
            this.flipXCheckBox.Enabled = false;
            this.flipXCheckBox.Location = new System.Drawing.Point(579, 15);
            this.flipXCheckBox.Name = "flipXCheckBox";
            this.flipXCheckBox.Size = new System.Drawing.Size(52, 17);
            this.flipXCheckBox.TabIndex = 12;
            this.flipXCheckBox.Text = "Flip X";
            this.flipXCheckBox.UseVisualStyleBackColor = true;
            this.flipXCheckBox.CheckedChanged += new System.EventHandler(this.flipXCheckBox_CheckedChanged);
            // 
            // movementDetectionCheckBox
            // 
            this.movementDetectionCheckBox.AutoSize = true;
            this.movementDetectionCheckBox.Enabled = false;
            this.movementDetectionCheckBox.Location = new System.Drawing.Point(665, 15);
            this.movementDetectionCheckBox.Name = "movementDetectionCheckBox";
            this.movementDetectionCheckBox.Size = new System.Drawing.Size(123, 17);
            this.movementDetectionCheckBox.TabIndex = 13;
            this.movementDetectionCheckBox.Text = "Movement Detected";
            this.movementDetectionCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.movementDetectionCheckBox);
            this.Controls.Add(this.flipXCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contrastTrackBar);
            this.Controls.Add(this.saturationTrackBar);
            this.Controls.Add(this.brightnessTrackBar);
            this.Controls.Add(this.screenshotButton);
            this.Controls.Add(this.stopCameraButton);
            this.Controls.Add(this.startCameraButton);
            this.Controls.Add(this.displayPictureBox);
            this.Controls.Add(this.findDevicesButton);
            this.Controls.Add(this.devicesComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Camera Capture Application";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.displayPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturationTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox devicesComboBox;
        private System.Windows.Forms.Button findDevicesButton;
        private System.Windows.Forms.PictureBox displayPictureBox;
        private System.Windows.Forms.Button startCameraButton;
        private System.Windows.Forms.Button stopCameraButton;
        private System.Windows.Forms.Button screenshotButton;
        private System.Windows.Forms.TrackBar brightnessTrackBar;
        private System.Windows.Forms.TrackBar saturationTrackBar;
        private System.Windows.Forms.TrackBar contrastTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox flipXCheckBox;
        private System.Windows.Forms.CheckBox movementDetectionCheckBox;
    }
}

