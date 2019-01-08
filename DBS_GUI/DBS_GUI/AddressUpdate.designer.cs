namespace DBS_GUI
{
    partial class AddressUpdate
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
            this.update = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.Label();
            this.Adr = new System.Windows.Forms.Label();
            this.cusid = new System.Windows.Forms.TextBox();
            this.adrUpdate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(41, 142);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(117, 40);
            this.update.TabIndex = 0;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.ForeColor = System.Drawing.Color.White;
            this.ID.Location = new System.Drawing.Point(37, 50);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(121, 20);
            this.ID.TabIndex = 1;
            this.ID.Text = "Customer ID:";
            // 
            // Adr
            // 
            this.Adr.AutoSize = true;
            this.Adr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adr.ForeColor = System.Drawing.Color.White;
            this.Adr.Location = new System.Drawing.Point(37, 94);
            this.Adr.Name = "Adr";
            this.Adr.Size = new System.Drawing.Size(100, 20);
            this.Adr.TabIndex = 2;
            this.Adr.Text = "Addresse: ";
            // 
            // cusid
            // 
            this.cusid.Location = new System.Drawing.Point(177, 50);
            this.cusid.Name = "cusid";
            this.cusid.Size = new System.Drawing.Size(100, 22);
            this.cusid.TabIndex = 3;
            // 
            // adrUpdate
            // 
            this.adrUpdate.Location = new System.Drawing.Point(177, 94);
            this.adrUpdate.Name = "adrUpdate";
            this.adrUpdate.Size = new System.Drawing.Size(331, 22);
            this.adrUpdate.TabIndex = 4;
            // 
            // AddressUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(520, 194);
            this.Controls.Add(this.adrUpdate);
            this.Controls.Add(this.cusid);
            this.Controls.Add(this.Adr);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.update);
            this.Name = "AddressUpdate";
            this.Text = "AddressUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label Adr;
        private System.Windows.Forms.TextBox cusid;
        private System.Windows.Forms.TextBox adrUpdate;
    }
}