namespace Team_7_KUKA_arm
{
    partial class Comports
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
            this.btnGetPorts = new System.Windows.Forms.Button();
            this.rtbSerialPorts = new System.Windows.Forms.RichTextBox();
            this.cbxPorts = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnGetPorts
            // 
            this.btnGetPorts.Location = new System.Drawing.Point(12, 12);
            this.btnGetPorts.Name = "btnGetPorts";
            this.btnGetPorts.Size = new System.Drawing.Size(75, 23);
            this.btnGetPorts.TabIndex = 0;
            this.btnGetPorts.Text = "Get Ports";
            this.btnGetPorts.UseVisualStyleBackColor = true;
            this.btnGetPorts.Click += new System.EventHandler(this.btnGetPorts_Click);
            // 
            // rtbSerialPorts
            // 
            this.rtbSerialPorts.Location = new System.Drawing.Point(12, 41);
            this.rtbSerialPorts.Name = "rtbSerialPorts";
            this.rtbSerialPorts.Size = new System.Drawing.Size(202, 150);
            this.rtbSerialPorts.TabIndex = 1;
            this.rtbSerialPorts.Text = "";
            // 
            // cbxPorts
            // 
            this.cbxPorts.FormattingEnabled = true;
            this.cbxPorts.Location = new System.Drawing.Point(93, 12);
            this.cbxPorts.Name = "cbxPorts";
            this.cbxPorts.Size = new System.Drawing.Size(121, 21);
            this.cbxPorts.TabIndex = 2;
            // 
            // Comports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 450);
            this.Controls.Add(this.cbxPorts);
            this.Controls.Add(this.rtbSerialPorts);
            this.Controls.Add(this.btnGetPorts);
            this.Name = "Comports";
            this.Text = "Comports";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetPorts;
        private System.Windows.Forms.RichTextBox rtbSerialPorts;
        private System.Windows.Forms.ComboBox cbxPorts;
    }
}