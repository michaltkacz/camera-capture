using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Imaging.Filters;
using AForge.Video;
using AForge.Video.DirectShow;

namespace CameraCapture
{
    public partial class Form1 : Form
    {
        FilterInfoCollection devicesList;
        VideoCaptureDevice currentDevice;

        //BrightnessCorrection brightnessCorrection;
        //SaturationCorrection saturationCorrection;
        //ContrastCorrection contrastCorrection;

        bool isFlipX;

        private int mvDetectionThreshold = 0;
        private int mvPrevFrameScore = 0;

        public Form1()
        {
            InitializeComponent();
            isFlipX = flipXCheckBox.Checked;

            //brightnessCorrection = new BrightnessCorrection();
            //saturationCorrection = new SaturationCorrection();
            //contrastCorrection = new ContrastCorrection();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            stopCameraButton_Click(sender, e);

        }

        private void findDevicesButton_Click(object sender, EventArgs e)
        {
            devicesComboBox.Items.Clear();
            devicesList = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in devicesList)
            {
                devicesComboBox.Items.Add(device.Name);
            }

            if (devicesComboBox.Items.Count > 0)
            {
                devicesComboBox.SelectedIndex = 0;
                currentDevice = new VideoCaptureDevice(devicesList[devicesComboBox.SelectedIndex].MonikerString);

                startCameraButton.Enabled = true;
            }

        }

        private void startCameraButton_Click(object sender, EventArgs e)
        {
            if (currentDevice != null)
            {
                currentDevice = new VideoCaptureDevice(devicesList[devicesComboBox.SelectedIndex].MonikerString);
                currentDevice.NewFrame += currentDevice_NewFrame;
                currentDevice.Start();

                startCameraButton.Enabled = false;
                stopCameraButton.Enabled = true;
                screenshotButton.Enabled = true;
                flipXCheckBox.Enabled = true;

                findDevicesButton.Enabled = false;
                devicesComboBox.Enabled = false;
            }

        }

        private void stopCameraButton_Click(object sender, EventArgs e)
        {
            if (currentDevice != null)
            {
                currentDevice.Stop();
                currentDevice.NewFrame -= currentDevice_NewFrame;

                startCameraButton.Enabled = true;
                stopCameraButton.Enabled = false;
                screenshotButton.Enabled = false;
                flipXCheckBox.Enabled = false;

                findDevicesButton.Enabled = true;
                devicesComboBox.Enabled = true;
            }

        }

        private void screenshotButton_Click(object sender, EventArgs e)
        {
            Bitmap screenshoot = (Bitmap)displayPictureBox.Image;
            saveFileDialog1.Filter = "JPEG file|*.jpg";
            saveFileDialog1.Title = "Save screenshoot";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile())
                {
                    screenshoot.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            }

        }

        private void currentDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap frame = (Bitmap)eventArgs.Frame.Clone();
            if (isFlipX)
            {
                frame.RotateFlip(RotateFlipType.RotateNoneFlipX);
            }

            checkMovementDetection(frame);
            //brightnessCorrection.ApplyInPlace(frame);
            //saturationCorrection.ApplyInPlace(frame);
            //contrastCorrection.ApplyInPlace(frame);

            displayPictureBox.Image = frame;

        }

        private void checkMovementDetection(Bitmap frame)
        {
            int mvFrameScore = 0;
            int pixelCheckDensity = 50;
            for (int i = 0; i < frame.Height; i += pixelCheckDensity)
            {
                for (int j = 0; j < frame.Width; j += pixelCheckDensity)
                {
                    var color = frame.GetPixel(j, i);
                    mvFrameScore += color.R;
                    mvFrameScore += color.G;
                    mvFrameScore += color.B;
                    mvFrameScore += color.A;
                }
            }

            int mvScoreDifference = Math.Abs(mvPrevFrameScore - mvFrameScore);
            bool isMovementDetected = mvScoreDifference > mvDetectionThreshold;
            Debug.WriteLine(isMovementDetected);
            BeginInvoke(new SetMovementDetectionCheckBoxDelegate(SetMovementDetectionCheckBoxValue), isMovementDetected);

            mvPrevFrameScore = mvFrameScore;
            mvDetectionThreshold = (int) (0.002f * mvPrevFrameScore);
        }

        private delegate void SetMovementDetectionCheckBoxDelegate(bool isMovementDetected);
        private void SetMovementDetectionCheckBoxValue(bool isMovementDetected)
        {
            movementDetectionCheckBox.Checked = isMovementDetected;

        }

        private void flipXCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            isFlipX = flipXCheckBox.Checked;

        }

    }
}
