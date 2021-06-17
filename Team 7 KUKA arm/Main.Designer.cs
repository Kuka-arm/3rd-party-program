namespace Team_7_KUKA_arm
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.c4_input = new System.Windows.Forms.Panel();
            this.c1_input = new System.Windows.Forms.Panel();
            this.c2_input = new System.Windows.Forms.Panel();
            this.c3_input = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.c4_output = new System.Windows.Forms.Panel();
            this.c1_output = new System.Windows.Forms.Panel();
            this.c2_output = new System.Windows.Forms.Panel();
            this.c3_output = new System.Windows.Forms.Panel();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(441, 386);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input Picture";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.c4_input);
            this.groupBox1.Controls.Add(this.c1_input);
            this.groupBox1.Controls.Add(this.c2_input);
            this.groupBox1.Controls.Add(this.c3_input);
            this.groupBox1.Location = new System.Drawing.Point(459, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 190);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // c4_input
            // 
            this.c4_input.BackColor = System.Drawing.Color.White;
            this.c4_input.Location = new System.Drawing.Point(284, 31);
            this.c4_input.Name = "c4_input";
            this.c4_input.Size = new System.Drawing.Size(76, 140);
            this.c4_input.TabIndex = 13;
            // 
            // c1_input
            // 
            this.c1_input.BackColor = System.Drawing.Color.White;
            this.c1_input.Location = new System.Drawing.Point(15, 31);
            this.c1_input.Name = "c1_input";
            this.c1_input.Size = new System.Drawing.Size(76, 140);
            this.c1_input.TabIndex = 10;
            // 
            // c2_input
            // 
            this.c2_input.BackColor = System.Drawing.Color.White;
            this.c2_input.Location = new System.Drawing.Point(103, 31);
            this.c2_input.Name = "c2_input";
            this.c2_input.Size = new System.Drawing.Size(76, 140);
            this.c2_input.TabIndex = 11;
            // 
            // c3_input
            // 
            this.c3_input.BackColor = System.Drawing.Color.White;
            this.c3_input.Location = new System.Drawing.Point(194, 31);
            this.c3_input.Name = "c3_input";
            this.c3_input.Size = new System.Drawing.Size(76, 140);
            this.c3_input.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.c4_output);
            this.groupBox2.Controls.Add(this.c1_output);
            this.groupBox2.Controls.Add(this.c2_output);
            this.groupBox2.Controls.Add(this.c3_output);
            this.groupBox2.Location = new System.Drawing.Point(459, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 190);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // c4_output
            // 
            this.c4_output.BackColor = System.Drawing.Color.White;
            this.c4_output.Location = new System.Drawing.Point(284, 31);
            this.c4_output.Name = "c4_output";
            this.c4_output.Size = new System.Drawing.Size(76, 140);
            this.c4_output.TabIndex = 17;
            this.c4_output.Click += new System.EventHandler(this.c4_output_Click);
            // 
            // c1_output
            // 
            this.c1_output.BackColor = System.Drawing.Color.White;
            this.c1_output.Location = new System.Drawing.Point(15, 31);
            this.c1_output.Name = "c1_output";
            this.c1_output.Size = new System.Drawing.Size(76, 140);
            this.c1_output.TabIndex = 14;
            this.c1_output.Click += new System.EventHandler(this.c1_output_Click);
            // 
            // c2_output
            // 
            this.c2_output.BackColor = System.Drawing.Color.White;
            this.c2_output.Location = new System.Drawing.Point(103, 31);
            this.c2_output.Name = "c2_output";
            this.c2_output.Size = new System.Drawing.Size(76, 140);
            this.c2_output.TabIndex = 15;
            this.c2_output.Click += new System.EventHandler(this.c2_output_Click);
            // 
            // c3_output
            // 
            this.c3_output.BackColor = System.Drawing.Color.White;
            this.c3_output.Location = new System.Drawing.Point(194, 31);
            this.c3_output.Name = "c3_output";
            this.c3_output.Size = new System.Drawing.Size(76, 140);
            this.c3_output.TabIndex = 16;
            this.c3_output.Click += new System.EventHandler(this.c3_output_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(308, 409);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(145, 23);
            this.btnImport.TabIndex = 4;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(459, 409);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(145, 23);
            this.btnSort.TabIndex = 5;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 444);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmMain";
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Panel c4_input;
        private System.Windows.Forms.Panel c1_input;
        private System.Windows.Forms.Panel c2_input;
        private System.Windows.Forms.Panel c3_input;
        private System.Windows.Forms.Panel c4_output;
        private System.Windows.Forms.Panel c1_output;
        private System.Windows.Forms.Panel c2_output;
        private System.Windows.Forms.Panel c3_output;
    }
}

