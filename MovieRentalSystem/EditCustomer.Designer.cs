namespace MovieRentalSystem
{
    partial class EditCustomer
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
            this.btn_Submit = new System.Windows.Forms.Button();
            this.tbx_PhoneNo = new System.Windows.Forms.TextBox();
            this.tbx_Address = new System.Windows.Forms.TextBox();
            this.tbx_LastName = new System.Windows.Forms.TextBox();
            this.tbx_FirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(107, 258);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 41);
            this.btn_Submit.TabIndex = 26;
            this.btn_Submit.Text = "Update Customer";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tbx_PhoneNo
            // 
            this.tbx_PhoneNo.Location = new System.Drawing.Point(107, 205);
            this.tbx_PhoneNo.Name = "tbx_PhoneNo";
            this.tbx_PhoneNo.Size = new System.Drawing.Size(140, 20);
            this.tbx_PhoneNo.TabIndex = 25;
            // 
            // tbx_Address
            // 
            this.tbx_Address.Location = new System.Drawing.Point(107, 121);
            this.tbx_Address.Multiline = true;
            this.tbx_Address.Name = "tbx_Address";
            this.tbx_Address.Size = new System.Drawing.Size(140, 50);
            this.tbx_Address.TabIndex = 24;
            // 
            // tbx_LastName
            // 
            this.tbx_LastName.Location = new System.Drawing.Point(107, 74);
            this.tbx_LastName.Name = "tbx_LastName";
            this.tbx_LastName.Size = new System.Drawing.Size(140, 20);
            this.tbx_LastName.TabIndex = 23;
            // 
            // tbx_FirstName
            // 
            this.tbx_FirstName.Location = new System.Drawing.Point(107, 31);
            this.tbx_FirstName.Name = "tbx_FirstName";
            this.tbx_FirstName.Size = new System.Drawing.Size(140, 20);
            this.tbx_FirstName.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Phone No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "First Name";
            // 
            // EditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 385);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.tbx_PhoneNo);
            this.Controls.Add(this.tbx_Address);
            this.Controls.Add(this.tbx_LastName);
            this.Controls.Add(this.tbx_FirstName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "EditCustomer";
            this.Text = "EditCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.TextBox tbx_PhoneNo;
        private System.Windows.Forms.TextBox tbx_Address;
        private System.Windows.Forms.TextBox tbx_LastName;
        private System.Windows.Forms.TextBox tbx_FirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}