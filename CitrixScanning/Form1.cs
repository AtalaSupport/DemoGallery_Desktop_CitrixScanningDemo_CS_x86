using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Atalasoft.Twain;

namespace CitrixScanning
{
    public partial class Form1 : Form
    {
        private Acquisition _acquisition;
        private Device _device;
        private string _deviceName;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Be sure to provide a parent to the Acquisition object.
            _acquisition = new Acquisition(this);
            if (_acquisition.SystemHasTwain == false || _acquisition.Devices.Count == 0)
            {
                MessageBox.Show("No compatible scanners were found on this system.", "No Scanners Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

            _deviceName = _acquisition.Devices.Default.Identity.ProductName;

            _acquisition.ImageAcquired += new ImageAcquiredEventHandler(_acquisition_ImageAcquired);
            _acquisition.AcquireFinished += new EventHandler(_acquisition_AcquireFinished);
            _acquisition.AcquireCanceled += new EventHandler(_acquisition_AcquireCanceled);
            _acquisition.AsynchronousException += new AsynchronousExceptionEventHandler(_acquisition_AsynchronousException);
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisposeDevice();
            if (_acquisition != null) _acquisition.Dispose();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            Device dev = _acquisition.ShowSelectSource();
            if (dev != null)
                _deviceName = dev.Identity.ProductName;
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            // CreateDeviceSession returns a new temporary Device object to scan with.
            // This device cannot be opened and closed more than once and you must 
            // dispose the object when finished with the scan.
            _device = _acquisition.CreateDeviceSession(_deviceName);
            if (_device == null)
            {
                MessageBox.Show("We were unable to create the device session for '" + _deviceName + "'.", "Create Device Session Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                _device.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("We were unable to open the device.\r\n\r\n" + ex.Message, "Open Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DisposeDevice();
                return;
            }

            _device.ThreadingEnabled = true;
            _device.TransferCount = 1;
            _device.TransferMethod = TwainTransferMethod.TWSX_NATIVE;
            _device.PixelType = ImagePixelType.BlackAndWhite;
            _device.Resolution = new TwainResolution(300, 300);
            _device.Acquire();
        }

        void _acquisition_AcquireFinished(object sender, EventArgs e)
        {
            DisposeDevice();
        }

        void _acquisition_AcquireCanceled(object sender, EventArgs e)
        {
            DisposeDevice();
        }

        void _acquisition_ImageAcquired(object sender, AcquireEventArgs e)
        {
            if (e.Image != null)
            {
                MessageBox.Show("Image:  " + e.Image.PixelFormat.ToString() + " - " + e.Image.Width.ToString() + " x " + e.Image.Height.ToString(), "Image Acquired", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Image.Dispose();
            }
        }

        void _acquisition_AsynchronousException(object sender, AsynchronousExceptionEventArgs e)
        {
            DisposeDevice();
            MessageBox.Show("There was an error while scanning.\r\n\r\n" + e.Exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void DisposeDevice()
        {
            if (_device != null)
            {
                _device.Dispose();
                _device = null;
            }
        }
    }
}