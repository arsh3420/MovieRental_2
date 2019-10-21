namespace MovieRentalSystem
{
    partial class Issue
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
            this.button1 = new System.Windows.Forms.Button();
            this.tbx_CustomerID = new System.Windows.Forms.TextBox();
            this.tbx_MovieID = new System.Windows.Forms.TextBox();
            this.tbx_PhoneNo = new System.Windows.Forms.TextBox();
            this.tbx_Address = new System.Windows.Forms.TextBox();
            this.tbx_LastName = new System.Windows.Forms.TextBox();
            this.tbx_FirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 47);
            this.button1.TabIndex = 34;
            this.button1.Text = "Issue";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tbx_CustomerID
            // 
            this.tbx_CustomerID.Location = new System.Drawing.Point(147, 50);
            this.tbx_CustomerID.Name = "tbx_CustomerID";
            this.tbx_CustomerID.Size = new System.Drawing.Size(435, 20);
            this.tbx_CustomerID.TabIndex = 33;
            this.tbx_CustomerID.Click += new System.EventHandler(this.CustID_TextChanged);
            this.tbx_CustomerID.TextChanged += new System.EventHandler(this.tbx_CustomerID_TextChanged);
            // 
            // tbx_MovieID
            // 
            this.tbx_MovieID.Enabled = false;
            this.tbx_MovieID.Location = new System.Drawing.Point(147, 24);
            this.tbx_MovieID.Name = "tbx_MovieID";
            this.tbx_MovieID.Size = new System.Drawing.Size(435, 20);
            this.tbx_MovieID.TabIndex = 32;
            // 
            // tbx_PhoneNo
            // 
            this.tbx_PhoneNo.Enabled = false;
            this.tbx_PhoneNo.Location = new System.Drawing.Point(147, 195);
            this.tbx_PhoneNo.Name = "tbx_PhoneNo";
            this.tbx_PhoneNo.Size = new System.Drawing.Size(435, 20);
            this.tbx_PhoneNo.TabIndex = 27;
            // 
            // tbx_Address
            // 
            this.tbx_Address.Enabled = false;
            this.tbx_Address.Location = new System.Drawing.Point(147, 128);
            this.tbx_Address.Multiline = true;
            this.tbx_Address.Name = "tbx_Address";
            this.tbx_Address.Size = new System.Drawing.Size(435, 61);
            this.tbx_Address.TabIndex = 26;
            // 
            // tbx_LastName
            // 
            this.tbx_LastName.Enabled = false;
            this.tbx_LastName.Location = new System.Drawing.Point(147, 102);
            this.tbx_LastName.Name = "tbx_LastName";
            this.tbx_LastName.Size = new System.Drawing.Size(435, 20);
            this.tbx_LastName.TabIndex = 25;
            // 
            // tbx_FirstName
            // 
            this.tbx_FirstName.Enabled = false;
            this.tbx_FirstName.Location = new System.Drawing.Point(147, 76);
            this.tbx_FirstName.Name = "tbx_FirstName";
            this.tbx_FirstName.Size = new System.Drawing.Size(435, 20);
            this.tbx_FirstName.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Phone No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Customer ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Movie ID";
            // 
            // Issue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 320);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbx_CustomerID);
            this.Controls.Add(this.tbx_MovieID);
            this.Controls.Add(this.tbx_PhoneNo);
            this.Controls.Add(this.tbx_Address);
            this.Controls.Add(this.tbx_LastName);
            this.Controls.Add(this.tbx_FirstName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Issue";
            this.Text = "Issue";
            this.Load += new System.EventHandler(this.Issue_Load);
            this.Click += new System.EventHandler(this.CustID_TextChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbx_CustomerID;
        private System.Windows.Forms.TextBox tbx_MovieID;
        private System.Windows.Forms.TextBox tbx_PhoneNo;
        private System.Windows.Forms.TextBox tbx_Address;
        private System.Windows.Forms.TextBox tbx_LastName;
        private System.Windows.Forms.TextBox tbx_FirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}