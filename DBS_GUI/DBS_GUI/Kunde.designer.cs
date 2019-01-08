namespace DBS_GUI
{
    partial class kundeForm
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
            this.Info = new System.Windows.Forms.Label();
            this.Addkunden = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.firstname = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.female = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            this.address = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.Nname = new System.Windows.Forms.TextBox();
            this.nachname = new System.Windows.Forms.Label();
            this.Namefisrt = new System.Windows.Forms.TextBox();
            this.first = new System.Windows.Forms.Label();
            this.kundeID = new System.Windows.Forms.TextBox();
            this.kunid = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.shomare = new System.Windows.Forms.Button();
            this.town = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.addr = new System.Windows.Forms.Button();
            this.Addkunden.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info.Location = new System.Drawing.Point(148, 9);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(196, 32);
            this.Info.TabIndex = 0;
            this.Info.Text = "Customers Tool";
            // 
            // Addkunden
            // 
            this.Addkunden.Controls.Add(this.tabPage1);
            this.Addkunden.Controls.Add(this.tabPage2);
            this.Addkunden.Controls.Add(this.tabPage4);
            this.Addkunden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addkunden.Location = new System.Drawing.Point(0, 60);
            this.Addkunden.Name = "Addkunden";
            this.Addkunden.SelectedIndex = 0;
            this.Addkunden.Size = new System.Drawing.Size(800, 453);
            this.Addkunden.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Peru;
            this.tabPage1.Controls.Add(this.firstname);
            this.tabPage1.Controls.Add(this.lastname);
            this.tabPage1.Controls.Add(this.female);
            this.tabPage1.Controls.Add(this.male);
            this.tabPage1.Controls.Add(this.address);
            this.tabPage1.Controls.Add(this.city);
            this.tabPage1.Controls.Add(this.phone);
            this.tabPage1.Controls.Add(this.email);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Customers";
            // 
            // firstname
            // 
            this.firstname.BackColor = System.Drawing.SystemColors.Window;
            this.firstname.Location = new System.Drawing.Point(111, 30);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(358, 22);
            this.firstname.TabIndex = 15;
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(111, 72);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(358, 22);
            this.lastname.TabIndex = 14;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(196, 115);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(75, 21);
            this.female.TabIndex = 13;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(111, 114);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(59, 21);
            this.male.TabIndex = 12;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(111, 155);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(358, 22);
            this.address.TabIndex = 11;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(111, 201);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(358, 22);
            this.city.TabIndex = 10;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(111, 248);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(358, 22);
            this.phone.TabIndex = 9;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(111, 289);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(358, 22);
            this.email.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 50);
            this.button1.TabIndex = 7;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sex";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lastname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firstname ";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Peru;
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.Nname);
            this.tabPage2.Controls.Add(this.nachname);
            this.tabPage2.Controls.Add(this.Namefisrt);
            this.tabPage2.Controls.Add(this.first);
            this.tabPage2.Controls.Add(this.kundeID);
            this.tabPage2.Controls.Add(this.kunid);
            this.tabPage2.Controls.Add(this.search);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 422);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View Indformation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.ForestGreen;
            this.label8.Location = new System.Drawing.Point(202, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "OR";
            // 
            // Nname
            // 
            this.Nname.Location = new System.Drawing.Point(234, 160);
            this.Nname.Name = "Nname";
            this.Nname.Size = new System.Drawing.Size(146, 24);
            this.Nname.TabIndex = 7;
            this.Nname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // nachname
            // 
            this.nachname.AutoSize = true;
            this.nachname.ForeColor = System.Drawing.Color.White;
            this.nachname.Location = new System.Drawing.Point(254, 128);
            this.nachname.Name = "nachname";
            this.nachname.Size = new System.Drawing.Size(86, 18);
            this.nachname.TabIndex = 6;
            this.nachname.Text = "Lastname:";
            // 
            // Namefisrt
            // 
            this.Namefisrt.Location = new System.Drawing.Point(65, 160);
            this.Namefisrt.Name = "Namefisrt";
            this.Namefisrt.Size = new System.Drawing.Size(142, 24);
            this.Namefisrt.TabIndex = 5;
            // 
            // first
            // 
            this.first.AutoSize = true;
            this.first.ForeColor = System.Drawing.Color.White;
            this.first.Location = new System.Drawing.Point(93, 128);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(88, 18);
            this.first.TabIndex = 4;
            this.first.Text = "Firstname:";
            // 
            // kundeID
            // 
            this.kundeID.Location = new System.Drawing.Point(124, 56);
            this.kundeID.Name = "kundeID";
            this.kundeID.Size = new System.Drawing.Size(194, 24);
            this.kundeID.TabIndex = 3;
            // 
            // kunid
            // 
            this.kunid.AutoSize = true;
            this.kunid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kunid.Location = new System.Drawing.Point(147, 25);
            this.kunid.Name = "kunid";
            this.kunid.Size = new System.Drawing.Size(151, 18);
            this.kunid.TabIndex = 2;
            this.kunid.Text = "Customer Number:";
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.AliceBlue;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(163, 206);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(99, 44);
            this.search.TabIndex = 1;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 256);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(481, 163);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Peru;
            this.tabPage4.Controls.Add(this.shomare);
            this.tabPage4.Controls.Add(this.town);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.mail);
            this.tabPage4.Controls.Add(this.del);
            this.tabPage4.Controls.Add(this.addr);
            this.tabPage4.Location = new System.Drawing.Point(4, 27);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(792, 422);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Update ";
            // 
            // shomare
            // 
            this.shomare.BackColor = System.Drawing.Color.White;
            this.shomare.Location = new System.Drawing.Point(325, 293);
            this.shomare.Name = "shomare";
            this.shomare.Size = new System.Drawing.Size(144, 89);
            this.shomare.TabIndex = 5;
            this.shomare.Text = "Phone";
            this.shomare.UseVisualStyleBackColor = false;
            this.shomare.Click += new System.EventHandler(this.shomare_Click);
            // 
            // town
            // 
            this.town.BackColor = System.Drawing.Color.White;
            this.town.Location = new System.Drawing.Point(7, 293);
            this.town.Name = "town";
            this.town.Size = new System.Drawing.Size(144, 89);
            this.town.TabIndex = 4;
            this.town.Text = "City";
            this.town.UseVisualStyleBackColor = false;
            this.town.Click += new System.EventHandler(this.town_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Info;
            this.label9.Location = new System.Drawing.Point(44, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(362, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "How do you want to Update the list? ";
            // 
            // mail
            // 
            this.mail.BackColor = System.Drawing.SystemColors.HighlightText;
            this.mail.Location = new System.Drawing.Point(325, 109);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(144, 89);
            this.mail.TabIndex = 2;
            this.mail.Text = "Email";
            this.mail.UseVisualStyleBackColor = false;
            this.mail.Click += new System.EventHandler(this.mail_Click);
            // 
            // del
            // 
            this.del.BackColor = System.Drawing.Color.White;
            this.del.Location = new System.Drawing.Point(164, 202);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(144, 89);
            this.del.TabIndex = 1;
            this.del.Text = "Delete";
            this.del.UseVisualStyleBackColor = false;
            this.del.Click += new System.EventHandler(this.button3_Click);
            // 
            // addr
            // 
            this.addr.BackColor = System.Drawing.Color.White;
            this.addr.Location = new System.Drawing.Point(8, 109);
            this.addr.Name = "addr";
            this.addr.Size = new System.Drawing.Size(144, 89);
            this.addr.TabIndex = 0;
            this.addr.Text = "Address";
            this.addr.UseVisualStyleBackColor = false;
            this.addr.Click += new System.EventHandler(this.button2_Click);
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 507);
            this.Controls.Add(this.Addkunden);
            this.Controls.Add(this.Info);
            this.Name = "form";
            this.Text = "Kunden";
            this.Addkunden.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.TabControl Addkunden;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Namefisrt;
        private System.Windows.Forms.Label first;
        private System.Windows.Forms.TextBox kundeID;
        private System.Windows.Forms.Label kunid;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Nname;
        private System.Windows.Forms.Label nachname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button mail;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button addr;
        private System.Windows.Forms.Button shomare;
        private System.Windows.Forms.Button town;
        private System.Windows.Forms.Label label9;
    }
}

