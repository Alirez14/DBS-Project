namespace DBS_GUI
{
    partial class listAngestellte
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
            this.dataviewAngestellte = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataviewAngestellte)).BeginInit();
            this.SuspendLayout();
            // 
            // dataviewAngestellte
            // 
            this.dataviewAngestellte.AllowUserToAddRows = false;
            this.dataviewAngestellte.AllowUserToDeleteRows = false;
            this.dataviewAngestellte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataviewAngestellte.Location = new System.Drawing.Point(-1, 0);
            this.dataviewAngestellte.Name = "dataviewAngestellte";
            this.dataviewAngestellte.ReadOnly = true;
            this.dataviewAngestellte.RowTemplate.Height = 24;
            this.dataviewAngestellte.Size = new System.Drawing.Size(901, 532);
            this.dataviewAngestellte.TabIndex = 0;
            // 
            // listAngestellte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 531);
            this.Controls.Add(this.dataviewAngestellte);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "listAngestellte";
            this.ShowIcon = false;
            this.Text = "Anzeige aller Angestellten";
            this.Load += new System.EventHandler(this.listAngestellte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataviewAngestellte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataviewAngestellte;
    }
}