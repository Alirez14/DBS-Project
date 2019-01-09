namespace DBS_GUI
{
    partial class DeleteCus
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
            this.DelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DelButton
            // 
            this.DelButton.BackColor = System.Drawing.Color.White;
            this.DelButton.ForeColor = System.Drawing.Color.Black;
            this.DelButton.Location = new System.Drawing.Point(140, 110);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(100, 39);
            this.DelButton.TabIndex = 0;
            this.DelButton.Text = "Delete";
            this.DelButton.UseVisualStyleBackColor = false;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer ID:";
            // 
            // pid
            // 
            this.pid.Location = new System.Drawing.Point(140, 66);
            this.pid.Name = "pid";
            this.pid.Size = new System.Drawing.Size(100, 22);
            this.pid.TabIndex = 2;
            // 
            // DeleteCus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(278, 161);
            this.Controls.Add(this.pid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DelButton);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "DeleteCus";
            this.Text = "Delete Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pid;
    }
}