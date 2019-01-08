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
            this.showDeactivated = new System.Windows.Forms.CheckBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataviewAngestellte)).BeginInit();
            this.SuspendLayout();
            // 
            // dataviewAngestellte
            // 
            this.dataviewAngestellte.AllowUserToAddRows = false;
            this.dataviewAngestellte.AllowUserToDeleteRows = false;
            this.dataviewAngestellte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataviewAngestellte.Location = new System.Drawing.Point(12, 48);
            this.dataviewAngestellte.Name = "dataviewAngestellte";
            this.dataviewAngestellte.ReadOnly = true;
            this.dataviewAngestellte.RowTemplate.Height = 24;
            this.dataviewAngestellte.Size = new System.Drawing.Size(876, 471);
            this.dataviewAngestellte.TabIndex = 0;
            // 
            // showDeactivated
            // 
            this.showDeactivated.AutoSize = true;
            this.showDeactivated.Location = new System.Drawing.Point(168, 17);
            this.showDeactivated.Name = "showDeactivated";
            this.showDeactivated.Size = new System.Drawing.Size(281, 23);
            this.showDeactivated.TabIndex = 1;
            this.showDeactivated.Text = "Zeige auch deaktivierte Angestellte";
            this.showDeactivated.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(131, 30);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Aktualisieren";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // listAngestellte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 531);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.showDeactivated);
            this.Controls.Add(this.dataviewAngestellte);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "listAngestellte";
            this.ShowIcon = false;
            this.Text = "Anzeige aller Angestellten";
            this.Load += new System.EventHandler(this.listAngestellte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataviewAngestellte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataviewAngestellte;
        private System.Windows.Forms.CheckBox showDeactivated;
        private System.Windows.Forms.Button btnRefresh;
    }
}