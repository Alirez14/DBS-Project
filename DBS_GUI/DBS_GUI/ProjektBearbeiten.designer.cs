namespace Projekt
{
    partial class ProjektBearbeiten
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
            this.EndDate = new System.Windows.Forms.Label();
            this.Projfin = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Format = new System.Windows.Forms.Label();
            this.ProjID = new System.Windows.Forms.Label();
            this.Projekt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EndDate
            // 
            this.EndDate.AutoSize = true;
            this.EndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDate.ForeColor = System.Drawing.Color.White;
            this.EndDate.Location = new System.Drawing.Point(12, 89);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(131, 20);
            this.EndDate.TabIndex = 0;
            this.EndDate.Text = "Finishing Date";
            // 
            // Projfin
            // 
            this.Projfin.Location = new System.Drawing.Point(149, 89);
            this.Projfin.Name = "Projfin";
            this.Projfin.Size = new System.Drawing.Size(211, 22);
            this.Projfin.TabIndex = 1;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(196, 147);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(87, 40);
            this.Add.TabIndex = 2;
            this.Add.Text = "Update";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Format
            // 
            this.Format.AutoSize = true;
            this.Format.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Format.ForeColor = System.Drawing.Color.White;
            this.Format.Location = new System.Drawing.Point(160, 117);
            this.Format.Name = "Format";
            this.Format.Size = new System.Drawing.Size(181, 13);
            this.Format.TabIndex = 3;
            this.Format.Text = "(YYYY-MM-DD HH:MM:SS.0000000)";
            // 
            // ProjID
            // 
            this.ProjID.AutoSize = true;
            this.ProjID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjID.ForeColor = System.Drawing.Color.White;
            this.ProjID.Location = new System.Drawing.Point(12, 45);
            this.ProjID.Name = "ProjID";
            this.ProjID.Size = new System.Drawing.Size(100, 20);
            this.ProjID.TabIndex = 4;
            this.ProjID.Text = "Project ID ";
            // 
            // Projekt
            // 
            this.Projekt.Location = new System.Drawing.Point(149, 42);
            this.Projekt.Name = "Projekt";
            this.Projekt.Size = new System.Drawing.Size(107, 22);
            this.Projekt.TabIndex = 5;
            // 
            // ProjektBearbeiten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(400, 199);
            this.Controls.Add(this.Projekt);
            this.Controls.Add(this.ProjID);
            this.Controls.Add(this.Format);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Projfin);
            this.Controls.Add(this.EndDate);
            this.Name = "ProjektBearbeiten";
            this.Text = "Projekt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EndDate;
        private System.Windows.Forms.TextBox Projfin;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label Format;
        private System.Windows.Forms.Label ProjID;
        private System.Windows.Forms.TextBox Projekt;
    }
}

