namespace STM32CustomProg
{
    partial class Mainform
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
            this.buttonDetect = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.RichTextBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonProgram = new System.Windows.Forms.Button();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.txtFirmwarePath = new System.Windows.Forms.TextBox();
            this.labelFirmware = new System.Windows.Forms.Label();
            this.buttonLoadHex = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtFlashAddress = new System.Windows.Forms.TextBox();
            this.comboBoxAdapters = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDetect
            // 
            this.buttonDetect.Location = new System.Drawing.Point(674, 67);
            this.buttonDetect.Name = "buttonDetect";
            this.buttonDetect.Size = new System.Drawing.Size(75, 33);
            this.buttonDetect.TabIndex = 0;
            this.buttonDetect.Text = "Detect";
            this.buttonDetect.UseVisualStyleBackColor = true;
            this.buttonDetect.Click += new System.EventHandler(this.buttonDetect_Click);
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(48, 105);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(701, 240);
            this.resultBox.TabIndex = 1;
            this.resultBox.Text = "";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(582, 351);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 37);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonProgram
            // 
            this.buttonProgram.Location = new System.Drawing.Point(674, 351);
            this.buttonProgram.Name = "buttonProgram";
            this.buttonProgram.Size = new System.Drawing.Size(75, 37);
            this.buttonProgram.TabIndex = 3;
            this.buttonProgram.Text = "Flash";
            this.buttonProgram.UseVisualStyleBackColor = true;
            this.buttonProgram.Click += new System.EventHandler(this.buttonProgram_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // txtFirmwarePath
            // 
            this.txtFirmwarePath.Location = new System.Drawing.Point(125, 36);
            this.txtFirmwarePath.Name = "txtFirmwarePath";
            this.txtFirmwarePath.Size = new System.Drawing.Size(520, 22);
            this.txtFirmwarePath.TabIndex = 4;
            // 
            // labelFirmware
            // 
            this.labelFirmware.AutoSize = true;
            this.labelFirmware.Location = new System.Drawing.Point(50, 39);
            this.labelFirmware.Name = "labelFirmware";
            this.labelFirmware.Size = new System.Drawing.Size(69, 17);
            this.labelFirmware.TabIndex = 5;
            this.labelFirmware.Text = "Firmware:";
            // 
            // buttonLoadHex
            // 
            this.buttonLoadHex.Location = new System.Drawing.Point(674, 31);
            this.buttonLoadHex.Name = "buttonLoadHex";
            this.buttonLoadHex.Size = new System.Drawing.Size(75, 33);
            this.buttonLoadHex.TabIndex = 6;
            this.buttonLoadHex.Text = "Load";
            this.buttonLoadHex.UseVisualStyleBackColor = true;
            this.buttonLoadHex.Click += new System.EventHandler(this.buttonLoadHex_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Address:";
            // 
            // TxtFlashAddress
            // 
            this.TxtFlashAddress.Location = new System.Drawing.Point(125, 72);
            this.TxtFlashAddress.Name = "TxtFlashAddress";
            this.TxtFlashAddress.Size = new System.Drawing.Size(100, 22);
            this.TxtFlashAddress.TabIndex = 8;
            this.TxtFlashAddress.Text = "0";
            // 
            // comboBoxAdapters
            // 
            this.comboBoxAdapters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdapters.Location = new System.Drawing.Point(370, 72);
            this.comboBoxAdapters.Name = "comboBoxAdapters";
            this.comboBoxAdapters.Size = new System.Drawing.Size(275, 24);
            this.comboBoxAdapters.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "ST-Link:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(48, 351);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 90);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Option Bytes";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 27);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(112, 21);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "nBOOT_SEL";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 54);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(109, 21);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "nRST_Mode";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(145, 27);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(86, 21);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "nBOOT0";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(145, 54);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(86, 21);
            this.checkBox4.TabIndex = 7;
            this.checkBox4.Text = "nBOOT1";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 76);
            this.button1.TabIndex = 8;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 446);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 468);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxAdapters);
            this.Controls.Add(this.TxtFlashAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLoadHex);
            this.Controls.Add(this.labelFirmware);
            this.Controls.Add(this.txtFirmwarePath);
            this.Controls.Add(this.buttonProgram);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.buttonDetect);
            this.Name = "Mainform";
            this.Text = "Stm32 Custom Prog";
            this.Load += new System.EventHandler(this.Mainform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDetect;
        private System.Windows.Forms.RichTextBox resultBox;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonProgram;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.TextBox TxtFlashAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLoadHex;
        private System.Windows.Forms.Label labelFirmware;
        private System.Windows.Forms.TextBox txtFirmwarePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxAdapters;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

