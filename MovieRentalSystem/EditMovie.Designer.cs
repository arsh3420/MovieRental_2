namespace MovieRentalSystem
{
    partial class EditMovie
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
            this.tbx_Genre = new System.Windows.Forms.TextBox();
            this.tbx_Plot = new System.Windows.Forms.TextBox();
            this.tbx_Copies = new System.Windows.Forms.TextBox();
            this.tbx_Year = new System.Windows.Forms.TextBox();
            this.tbx_Title = new System.Windows.Forms.TextBox();
            this.tbx_Rating = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(113, 312);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(84, 48);
            this.btn_Submit.TabIndex = 34;
            this.btn_Submit.Text = "Update Movie";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tbx_Genre
            // 
            this.tbx_Genre.Location = new System.Drawing.Point(113, 227);
            this.tbx_Genre.Multiline = true;
            this.tbx_Genre.Name = "tbx_Genre";
            this.tbx_Genre.Size = new System.Drawing.Size(150, 53);
            this.tbx_Genre.TabIndex = 33;
            // 
            // tbx_Plot
            // 
            this.tbx_Plot.Location = new System.Drawing.Point(113, 168);
            this.tbx_Plot.Multiline = true;
            this.tbx_Plot.Name = "tbx_Plot";
            this.tbx_Plot.Size = new System.Drawing.Size(150, 53);
            this.tbx_Plot.TabIndex = 32;
            // 
            // tbx_Copies
            // 
            this.tbx_Copies.Location = new System.Drawing.Point(113, 142);
            this.tbx_Copies.Name = "tbx_Copies";
            this.tbx_Copies.Size = new System.Drawing.Size(150, 20);
            this.tbx_Copies.TabIndex = 31;
            // 
            // tbx_Year
            // 
            this.tbx_Year.Location = new System.Drawing.Point(113, 116);
            this.tbx_Year.Name = "tbx_Year";
            this.tbx_Year.Size = new System.Drawing.Size(150, 20);
            this.tbx_Year.TabIndex = 30;
            // 
            // tbx_Title
            // 
            this.tbx_Title.Location = new System.Drawing.Point(113, 31);
            this.tbx_Title.Multiline = true;
            this.tbx_Title.Name = "tbx_Title";
            this.tbx_Title.Size = new System.Drawing.Size(150, 53);
            this.tbx_Title.TabIndex = 28;
            // 
            // tbx_Rating
            // 
            this.tbx_Rating.Location = new System.Drawing.Point(113, 90);
            this.tbx_Rating.Name = "tbx_Rating";
            this.tbx_Rating.Size = new System.Drawing.Size(150, 20);
            this.tbx_Rating.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Genre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Plot";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Copies";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Rating";
            // 
            // EditMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 419);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.tbx_Genre);
            this.Controls.Add(this.tbx_Plot);
            this.Controls.Add(this.tbx_Copies);
            this.Controls.Add(this.tbx_Year);
            this.Controls.Add(this.tbx_Title);
            this.Controls.Add(this.tbx_Rating);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditMovie";
            this.Text = "EditMovie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.TextBox tbx_Genre;
        private System.Windows.Forms.TextBox tbx_Plot;
        private System.Windows.Forms.TextBox tbx_Copies;
        private System.Windows.Forms.TextBox tbx_Year;
        private System.Windows.Forms.TextBox tbx_Title;
        private System.Windows.Forms.TextBox tbx_Rating;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}