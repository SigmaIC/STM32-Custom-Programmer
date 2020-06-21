using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using STM32CustomProg; 
using Microsoft.Win32;
using System.Text.RegularExpressions;

namespace STM32CustomProg
{
    public partial class Mainform : Form
    {
       
        public Mainform()
        {
            InitializeComponent();
        }

        STLinkAdapter l_STLinkAdapter = new STLinkAdapter("");
        private void Mainform_Load(object sender, EventArgs e)
        {
            DetectSTLinkAsync();
        }

        delegate void SetTextCallback(string text); 
        public void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.resultBox.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                //this.resultBox.AppendText("\rData Received: " + text); 
                this.resultBox.AppendText("\r" + text);
                // set the current caret position to the end
                this.resultBox.SelectionStart = resultBox.Text.Length;
                // scroll it automatically
                this.resultBox.ScrollToCaret();
            }


        }
        async Task DetectSTLinkAsync()
        {
            STLinkReturnCodes l_STLinkReturnCode = STLinkReturnCodes.Success;
            string l_STLinkResponse = String.Empty;
            // Connecting to the ST-LINK/V2.
            if (l_STLinkReturnCode == STLinkReturnCodes.Success)
            {
                l_STLinkReturnCode = await Task.Run(() => l_STLinkAdapter.FindSTLink(out l_STLinkResponse));

                SetText(l_STLinkResponse);

            }
            string[] splitList = {"\\r", "\\n"," ", "_", ":", "=", "STM32",  "CUBE" };
            List<string> AdapterList= new List<string>();
            List<string> stringList = l_STLinkResponse.Replace("-", "").Replace("\r", "").Replace("\n", "").Split(splitList, StringSplitOptions.RemoveEmptyEntries).ToList();
             
            foreach (var item in stringList)
            {
                if(item.Length > 15)
                {
                    AdapterList.Add(item);
                }
            }

            comboBoxAdapters.Items.AddRange(AdapterList.ToArray());
            comboBoxAdapters.SelectedIndex = 0;
            

        }
        private void buttonDetect_Click(object sender, EventArgs e)
        { 
            DetectSTLinkAsync(); 
        }

        async Task ConnectTargetAsync()
        {
            STLinkReturnCodes l_STLinkReturnCode = STLinkReturnCodes.Success;
            string l_STLinkResponse = String.Empty;
            string l_FirmwareInfo = String.Empty;
            //// Connecting to the processor target.  The target process or is a string like "STM32F05".
            if (l_STLinkReturnCode == STLinkReturnCodes.Success)
            {
                l_STLinkReturnCode = await Task.Run(() => l_STLinkAdapter.ConnectToTarget(l_FirmwareInfo, out l_STLinkResponse));
                SetText(l_STLinkResponse);
            }

        }
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            ConnectTargetAsync();
        }

        async Task ProgramTargetAsync()
        {
            STLinkReturnCodes l_STLinkReturnCode = STLinkReturnCodes.Success;
            string l_STLinkResponse = String.Empty;
            string l_BinFilePath = txtFirmwarePath.Text;
            string l_FlashSN = String.Empty;
            int address = 0;

            
            if(comboBoxAdapters.Items.Count > 0)
            {
                l_FlashSN = comboBoxAdapters.SelectedItem.ToString();
            }
            else
            {
                DetectSTLinkAsync();
                l_FlashSN = comboBoxAdapters.SelectedItem.ToString();
            }
                        
            if (String.IsNullOrEmpty(l_BinFilePath) || String.IsNullOrEmpty(l_FlashSN))
            {
                SetText("No firmware file loaded");
            }
            else
            {
                int.TryParse(TxtFlashAddress.Text, out address);

                UInt32 FlashloaderFlashAddress = 0x08000000 + (UInt32)address;
                // Programming flashloader
                if (l_STLinkReturnCode == STLinkReturnCodes.Success)
                {
                    l_STLinkReturnCode = await Task.Run(() => l_STLinkAdapter.ProgramTarget(l_BinFilePath, FlashloaderFlashAddress, l_FlashSN, out l_STLinkResponse));
                    SetText(l_STLinkResponse);
                }
            }

          
        }
        private void buttonProgram_Click(object sender, EventArgs e)
        {
            //using (var wrapper = new Logic())
            //// Using block is here to make sure we release native memory right away
            //{
            //    MessageBox.Show("The answer is " + wrapper.Get());
            //}
            ProgramTargetAsync(); 
        }

        private void buttonLoadHex_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "bin",
                Filter = "Firmware files (*.hex, *.bin, *.elf)|*.hex; *.bin;*.elf",
                FilterIndex = 1,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFirmwarePath.Text = openFileDialog1.FileName;
            }
        }
    }
}
