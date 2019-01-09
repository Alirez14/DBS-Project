namespace DBS_GUI
{
    partial class ProjShow
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
            this.showproj = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.showproj)).BeginInit();
            this.SuspendLayout();
            // 
            // showproj
            // 
            this.showproj.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.showproj.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.showproj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showproj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showproj.Location = new System.Drawing.Point(0, 0);
            this.showproj.Name = "showproj";
            this.showproj.RowTemplate.Height = 24;
            this.showproj.Size = new System.Drawing.Size(800, 450);
            this.showproj.TabIndex = 0;
            this.showproj.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ProjShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showproj);
            this.Name = "ProjShow";
            this.Text = "ProjShow";
            ((System.ComponentModel.ISupportInitialize)(this.showproj)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView showproj;
    }
}