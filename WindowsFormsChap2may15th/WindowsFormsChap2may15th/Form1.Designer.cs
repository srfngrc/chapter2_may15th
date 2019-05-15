namespace WindowsFormsChap2may15th
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.btnDisplayOutput = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDisplayOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(136, 63);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(427, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(136, 131);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(147, 20);
            this.txtCity.TabIndex = 2;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(136, 98);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(427, 20);
            this.txtAddress.TabIndex = 1;
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(464, 131);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(99, 20);
            this.txtZip.TabIndex = 4;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(344, 131);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(55, 20);
            this.txtState.TabIndex = 3;
            // 
            // btnDisplayOutput
            // 
            this.btnDisplayOutput.Location = new System.Drawing.Point(45, 180);
            this.btnDisplayOutput.Name = "btnDisplayOutput";
            this.btnDisplayOutput.Size = new System.Drawing.Size(123, 23);
            this.btnDisplayOutput.TabIndex = 5;
            this.btnDisplayOutput.Text = "&Display\r\n";
            this.btnDisplayOutput.UseVisualStyleBackColor = true;
            this.btnDisplayOutput.Click += new System.EventHandler(this.btnDisplayOutput_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(440, 180);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(123, 23);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "E&xit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(45, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Name: ";
            this.label1.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(45, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Address:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(45, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "City";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(298, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "State ";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(418, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "ZIP";
            // 
            // txtDisplayOutput
            // 
            this.txtDisplayOutput.Location = new System.Drawing.Point(45, 225);
            this.txtDisplayOutput.Multiline = true;
            this.txtDisplayOutput.Name = "txtDisplayOutput";
            this.txtDisplayOutput.ReadOnly = true;
            this.txtDisplayOutput.Size = new System.Drawing.Size(518, 94);
            this.txtDisplayOutput.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 358);
            this.Controls.Add(this.txtDisplayOutput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.btnDisplayOutput);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mailing Label Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Button btnDisplayOutput;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDisplayOutput;
    }
}

