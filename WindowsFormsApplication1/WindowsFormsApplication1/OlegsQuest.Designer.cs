namespace WindowsFormsApplication1
{
    partial class OlegsQuest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OlegsQuest));
            this.oleg_face = new System.Windows.Forms.PictureBox();
            this.rang = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.lvl = new System.Windows.Forms.Label();
            this.name_box = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.log = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.str = new System.Windows.Forms.Label();
            this.agil = new System.Windows.Forms.Label();
            this.intel = new System.Windows.Forms.Label();
            this.add_str = new System.Windows.Forms.Button();
            this.add_agil = new System.Windows.Forms.Button();
            this.add_intel = new System.Windows.Forms.Button();
            this.use1 = new System.Windows.Forms.Button();
            this.use2 = new System.Windows.Forms.Button();
            this.use3 = new System.Windows.Forms.Button();
            this.use4 = new System.Windows.Forms.Button();
            this.use5 = new System.Windows.Forms.Button();
            this.xp_bar = new System.Windows.Forms.ProgressBar();
            this.kuzmin_face = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.rage_bar = new System.Windows.Forms.ProgressBar();
            this.prepod_name = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.ustalost = new System.Windows.Forms.Label();
            this.money = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.bathroom = new System.Windows.Forms.Label();
            this.stats = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.action = new System.Windows.Forms.Label();
            this.comletition = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.oleg_face)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuzmin_face)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // oleg_face
            // 
            this.oleg_face.Image = ((System.Drawing.Image)(resources.GetObject("oleg_face.Image")));
            this.oleg_face.Location = new System.Drawing.Point(19, 40);
            this.oleg_face.Name = "oleg_face";
            this.oleg_face.Size = new System.Drawing.Size(84, 87);
            this.oleg_face.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.oleg_face.TabIndex = 0;
            this.oleg_face.TabStop = false;
            // 
            // rang
            // 
            this.rang.AutoSize = true;
            this.rang.Location = new System.Drawing.Point(110, 87);
            this.rang.Name = "rang";
            this.rang.Size = new System.Drawing.Size(51, 13);
            this.rang.TabIndex = 1;
            this.rang.Text = "Abiturient";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(181, 43);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(35, 21);
            this.start.TabIndex = 2;
            this.start.Text = "OK";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.button1_Click);
            // 
            // lvl
            // 
            this.lvl.AutoSize = true;
            this.lvl.Location = new System.Drawing.Point(110, 65);
            this.lvl.Name = "lvl";
            this.lvl.Size = new System.Drawing.Size(73, 13);
            this.lvl.TabIndex = 3;
            this.lvl.Text = "Lvl 0 Creature";
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(108, 43);
            this.name_box.MaxLength = 12;
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(75, 20);
            this.name_box.TabIndex = 4;
            this.name_box.Text = "Name here";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(110, 43);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(65, 13);
            this.name.TabIndex = 4;
            this.name.Text = "Oleg\'s name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Your oleg stats:";
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(220, 40);
            this.log.Name = "log";
            this.log.ReadOnly = true;
            this.log.Size = new System.Drawing.Size(468, 242);
            this.log.TabIndex = 8;
            this.log.Text = "<---Enter name\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Strength";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Agility";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Intelligence";
            // 
            // str
            // 
            this.str.AutoSize = true;
            this.str.Location = new System.Drawing.Point(94, 190);
            this.str.Name = "str";
            this.str.Size = new System.Drawing.Size(13, 13);
            this.str.TabIndex = 12;
            this.str.Text = "0";
            // 
            // agil
            // 
            this.agil.AutoSize = true;
            this.agil.Location = new System.Drawing.Point(94, 220);
            this.agil.Name = "agil";
            this.agil.Size = new System.Drawing.Size(13, 13);
            this.agil.TabIndex = 13;
            this.agil.Text = "0";
            // 
            // intel
            // 
            this.intel.AutoSize = true;
            this.intel.Location = new System.Drawing.Point(94, 250);
            this.intel.Name = "intel";
            this.intel.Size = new System.Drawing.Size(13, 13);
            this.intel.TabIndex = 14;
            this.intel.Text = "0";
            // 
            // add_str
            // 
            this.add_str.Location = new System.Drawing.Point(128, 185);
            this.add_str.Name = "add_str";
            this.add_str.Size = new System.Drawing.Size(75, 23);
            this.add_str.TabIndex = 15;
            this.add_str.Text = "Add";
            this.add_str.UseVisualStyleBackColor = true;
            this.add_str.Click += new System.EventHandler(this.button2_Click);
            // 
            // add_agil
            // 
            this.add_agil.Location = new System.Drawing.Point(128, 215);
            this.add_agil.Name = "add_agil";
            this.add_agil.Size = new System.Drawing.Size(75, 23);
            this.add_agil.TabIndex = 16;
            this.add_agil.Text = "Add";
            this.add_agil.UseVisualStyleBackColor = true;
            this.add_agil.Click += new System.EventHandler(this.button3_Click);
            // 
            // add_intel
            // 
            this.add_intel.Location = new System.Drawing.Point(128, 245);
            this.add_intel.Name = "add_intel";
            this.add_intel.Size = new System.Drawing.Size(75, 23);
            this.add_intel.TabIndex = 17;
            this.add_intel.Text = "Add";
            this.add_intel.UseVisualStyleBackColor = true;
            this.add_intel.Click += new System.EventHandler(this.button4_Click);
            // 
            // use1
            // 
            this.use1.Location = new System.Drawing.Point(211, 321);
            this.use1.Name = "use1";
            this.use1.Size = new System.Drawing.Size(93, 58);
            this.use1.TabIndex = 18;
            this.use1.Text = "Drakonit\'";
            this.use1.UseVisualStyleBackColor = true;
            this.use1.Click += new System.EventHandler(this.use1_Click);
            // 
            // use2
            // 
            this.use2.Location = new System.Drawing.Point(310, 321);
            this.use2.Name = "use2";
            this.use2.Size = new System.Drawing.Size(93, 58);
            this.use2.TabIndex = 19;
            this.use2.Text = "Umilyat\'";
            this.use2.UseVisualStyleBackColor = true;
            this.use2.Click += new System.EventHandler(this.use2_Click);
            // 
            // use3
            // 
            this.use3.Location = new System.Drawing.Point(409, 321);
            this.use3.Name = "use3";
            this.use3.Size = new System.Drawing.Size(93, 58);
            this.use3.TabIndex = 20;
            this.use3.Text = "Spisivat\'";
            this.use3.UseVisualStyleBackColor = true;
            // 
            // use4
            // 
            this.use4.Location = new System.Drawing.Point(508, 321);
            this.use4.Name = "use4";
            this.use4.Size = new System.Drawing.Size(92, 58);
            this.use4.TabIndex = 21;
            this.use4.Text = "Randomit\'";
            this.use4.UseVisualStyleBackColor = true;
            // 
            // use5
            // 
            this.use5.Location = new System.Drawing.Point(606, 321);
            this.use5.Name = "use5";
            this.use5.Size = new System.Drawing.Size(91, 58);
            this.use5.TabIndex = 22;
            this.use5.Text = "Shpora";
            this.use5.UseVisualStyleBackColor = true;
            // 
            // xp_bar
            // 
            this.xp_bar.Location = new System.Drawing.Point(113, 130);
            this.xp_bar.Name = "xp_bar";
            this.xp_bar.Size = new System.Drawing.Size(100, 23);
            this.xp_bar.TabIndex = 23;
            // 
            // kuzmin_face
            // 
            this.kuzmin_face.Image = ((System.Drawing.Image)(resources.GetObject("kuzmin_face.Image")));
            this.kuzmin_face.Location = new System.Drawing.Point(16, 373);
            this.kuzmin_face.Name = "kuzmin_face";
            this.kuzmin_face.Size = new System.Drawing.Size(84, 70);
            this.kuzmin_face.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kuzmin_face.TabIndex = 24;
            this.kuzmin_face.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 357);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Prepod";
            this.label11.Click += new System.EventHandler(this.label11_Click_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(106, 430);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Rage";
            // 
            // rage_bar
            // 
            this.rage_bar.Location = new System.Drawing.Point(145, 420);
            this.rage_bar.Name = "rage_bar";
            this.rage_bar.Size = new System.Drawing.Size(100, 23);
            this.rage_bar.TabIndex = 27;
            // 
            // prepod_name
            // 
            this.prepod_name.AutoSize = true;
            this.prepod_name.Location = new System.Drawing.Point(67, 357);
            this.prepod_name.Name = "prepod_name";
            this.prepod_name.Size = new System.Drawing.Size(43, 13);
            this.prepod_name.TabIndex = 28;
            this.prepod_name.Text = "Kuz\'min";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(23, 287);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Ustalost\'";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 304);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Shpora";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(23, 321);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "Bathroom";
            // 
            // ustalost
            // 
            this.ustalost.AutoSize = true;
            this.ustalost.Location = new System.Drawing.Point(136, 287);
            this.ustalost.Name = "ustalost";
            this.ustalost.Size = new System.Drawing.Size(13, 13);
            this.ustalost.TabIndex = 32;
            this.ustalost.Text = "0";
            // 
            // money
            // 
            this.money.AutoSize = true;
            this.money.Location = new System.Drawing.Point(136, 304);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(13, 13);
            this.money.TabIndex = 33;
            this.money.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(148, 287);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(15, 13);
            this.label19.TabIndex = 34;
            this.label19.Text = "%";
            // 
            // bathroom
            // 
            this.bathroom.AutoSize = true;
            this.bathroom.Location = new System.Drawing.Point(136, 321);
            this.bathroom.Name = "bathroom";
            this.bathroom.Size = new System.Drawing.Size(13, 13);
            this.bathroom.TabIndex = 35;
            this.bathroom.Text = "0";
            // 
            // stats
            // 
            this.stats.AutoSize = true;
            this.stats.Location = new System.Drawing.Point(125, 166);
            this.stats.Name = "stats";
            this.stats.Size = new System.Drawing.Size(13, 13);
            this.stats.TabIndex = 36;
            this.stats.Text = "0";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(145, 166);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(21, 13);
            this.label22.TabIndex = 37;
            this.label22.Text = "left";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(217, 392);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(35, 13);
            this.label23.TabIndex = 38;
            this.label23.Text = "Items:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Action PTS:";
            // 
            // action
            // 
            this.action.AutoSize = true;
            this.action.Location = new System.Drawing.Point(282, 293);
            this.action.Name = "action";
            this.action.Size = new System.Drawing.Size(13, 13);
            this.action.TabIndex = 40;
            this.action.Text = "0";
            this.action.Click += new System.EventHandler(this.label2_Click);
            // 
            // comletition
            // 
            this.comletition.Location = new System.Drawing.Point(319, 288);
            this.comletition.Name = "comletition";
            this.comletition.Size = new System.Drawing.Size(378, 23);
            this.comletition.TabIndex = 41;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(742, 24);
            this.menuStrip1.TabIndex = 42;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // Menu
            // 
            this.Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(50, 20);
            this.Menu.Text = "Menu";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "%";
            // 
            // OlegsQuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 463);
            this.ControlBox = false;
            this.Controls.Add(this.comletition);
            this.Controls.Add(this.action);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.stats);
            this.Controls.Add(this.bathroom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.money);
            this.Controls.Add(this.ustalost);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.prepod_name);
            this.Controls.Add(this.rage_bar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.kuzmin_face);
            this.Controls.Add(this.xp_bar);
            this.Controls.Add(this.use5);
            this.Controls.Add(this.use4);
            this.Controls.Add(this.use3);
            this.Controls.Add(this.use2);
            this.Controls.Add(this.use1);
            this.Controls.Add(this.add_intel);
            this.Controls.Add(this.add_agil);
            this.Controls.Add(this.add_str);
            this.Controls.Add(this.intel);
            this.Controls.Add(this.agil);
            this.Controls.Add(this.str);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.log);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.name);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.lvl);
            this.Controls.Add(this.start);
            this.Controls.Add(this.rang);
            this.Controls.Add(this.oleg_face);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OlegsQuest";
            this.Text = "OlegsQuest";
            ((System.ComponentModel.ISupportInitialize)(this.oleg_face)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuzmin_face)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox oleg_face;
        private System.Windows.Forms.Label rang;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label lvl;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox log;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button add_str;
        private System.Windows.Forms.Label intel;
        private System.Windows.Forms.Label agil;
        private System.Windows.Forms.Label str;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button add_agil;
        private System.Windows.Forms.Button add_intel;
        private System.Windows.Forms.Button use1;
        private System.Windows.Forms.Button use2;
        private System.Windows.Forms.Button use3;
        private System.Windows.Forms.Button use4;
        private System.Windows.Forms.Button use5;
        private System.Windows.Forms.ProgressBar xp_bar;
        private System.Windows.Forms.PictureBox kuzmin_face;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ProgressBar rage_bar;
        private System.Windows.Forms.Label prepod_name;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label ustalost;
        private System.Windows.Forms.Label money;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label bathroom;
        private System.Windows.Forms.Label stats;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label action;
        private System.Windows.Forms.ProgressBar comletition;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label2;
    }
}

