namespace MovieRentalSystem
{
    partial class Reports
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
            this.gridcustomer = new System.Windows.Forms.DataGridView();
            this.gridmovies = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridcustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridmovies)).BeginInit();
            this.SuspendLayout();
            // 
            // gridcustomer
            // 
            this.gridcustomer.AllowUserToAddRows = false;
            this.gridcustomer.AllowUserToDeleteRows = false;
            this.gridcustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridcustomer.Location = new System.Drawing.Point(12, 12);
            this.gridcustomer.Name = "gridcustomer";
            this.gridcustomer.ReadOnly = true;
            this.gridcustomer.Size = new System.Drawing.Size(782, 195);
            this.gridcustomer.TabIndex = 0;
            // 
            // gridmovies
            // 
            this.gridmovies.AllowUserToAddRows = false;
            this.gridmovies.AllowUserToDeleteRows = false;
            this.gridmovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridmovies.Location = new System.Drawing.Point(12, 252);
            this.gridmovies.Name = "gridmovies";
            this.gridmovies.ReadOnly = true;
            this.gridmovies.Size = new System.Drawing.Size(782, 195);
            this.gridmovies.TabIndex = 1;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 460);
            this.Controls.Add(this.gridmovies);
            this.Controls.Add(this.gridcustomer);
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridcustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridmovies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridcustomer;
        private System.Windows.Forms.DataGridView gridmovies;
    }
}