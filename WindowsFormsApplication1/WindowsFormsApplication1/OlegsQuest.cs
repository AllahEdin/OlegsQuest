using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class OlegsQuest : Form
    {

        short sys = 1,
              react = 2;
        

        public OlegsQuest()
        {
            InitializeComponent();
            checkExamButtons();
            hideStatButtons(true);
            name.Visible = false;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }

        private bool is_char_small(char a) 
        {
            bool it_is = false;
            if (name_box.Text[0] == 'a') { it_is = true; }
            if (name_box.Text[0] == 'b') { it_is = true; }
            if (name_box.Text[0] == 'c') { it_is = true; }
            if (name_box.Text[0] == 'd') { it_is = true; }
            if (name_box.Text[0] == 'e') { it_is = true; }
            if (name_box.Text[0] == 'f') { it_is = true; }
            if (name_box.Text[0] == 'g') { it_is = true; }
            if (name_box.Text[0] == 'h') { it_is = true; }
            if (name_box.Text[0] == 'i') { it_is = true; }
            if (name_box.Text[0] == 'j') { it_is = true; }
            if (name_box.Text[0] == 'k') { it_is = true; }
            if (name_box.Text[0] == 'l') { it_is = true; }
            if (name_box.Text[0] == 'm') { it_is = true; }
            if (name_box.Text[0] == 'n') { it_is = true; }
            if (name_box.Text[0] == 'o') { it_is = true; }
            if (name_box.Text[0] == 'p') { it_is = true; }
            if (name_box.Text[0] == 'q') { it_is = true; }
            if (name_box.Text[0] == 'r') { it_is = true; }
            if (name_box.Text[0] == 's') { it_is = true; }
            if (name_box.Text[0] == 't') { it_is = true; }
            if (name_box.Text[0] == 'u') { it_is = true; }
            if (name_box.Text[0] == 'v') { it_is = true; }
            if (name_box.Text[0] == 'w') { it_is = true; }
            if (name_box.Text[0] == 'x') { it_is = true; }
            if (name_box.Text[0] == 'y') { it_is = true; }
            if (name_box.Text[0] == 'z') { it_is = true; }
            return it_is;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (is_char_small(name_box.Text[0])) 
            {
                string s = name_box.Text, s2;
                s2 = "" + (char)((int)name_box.Text[0] + ((int)'A' - (int)'a'));
                for (int i = 1; i < s.Length; i++)
                {
                    s2 += s[i];
                }

                name_box.Text = s2;
            }
            hideStatButtons(false);
            name.Text = name_box.Text;
            name_box.Visible = false;
            name.Visible = true;
            start.Visible = false;
            Game game = new Game(name.Text);
            upLvl();
            message("Your game of domashka starts now");
            message("It's your first day at univer");
            message("Set your skill points now");
        }

        public void upLvl()
        {
            Game.lvl++;
            Game.stats += 5;
            lvl.Text = "Lvl " + Game.lvl.ToString() + " creature";
            stats.Text = Game.stats.ToString();
        }

        public void message(string m)
        {
            log.Text += m + '\n';
        }

        public void message(short type, string m)
        {
            if (type == sys)
            {
                log.Text += "==" + m + "=============" + '\n';
            }
            if (type == react)
            {
                log.Text += "             @" + m + '\n';
            }
        }

        //спрятать блок прокачки
        public void hideStatButtons(Boolean a)
        {
            if (a == true)
            {
                add_str.Visible = false;
                add_agil.Visible = false;
                add_intel.Visible = false;
            }
            else
            {
                add_str.Visible = true;
                add_agil.Visible = true;
                add_intel.Visible = true;
            }

        }

        public void checkExamButtons()
        {
            if (Game.ap < 2) use1.Enabled = false;
            else use1.Enabled = true;

            if (Game.ap < 4 || Game.umiUsed) use2.Enabled = false;
            else use2.Enabled = true;

            if (Game.ap < 3) use3.Enabled = false;
            else use3.Enabled = true;

            if (Game.ap < 1) use4.Enabled = false;
            else use4.Enabled = true;

            if (Game.ap < 5) use5.Enabled = false;
            else use5.Enabled = true;

        }

        private void firstLVL(Boolean a)
        {
            if (Game.stats == 0)
            {
                message("Good job!");
                if (Game.intel <= 1)
                    message(react,"OW! Dont you think your Oleg is too stupid?");
                if (Game.str <= 1)
                    message(react,"OW! Dont you think your Oleg is too weak?");
                if (Game.agil <= 1)
                    message(react,"OW! Dont you think your Oleg is too slow?");

                message("Nevermind");
                message("Lets start you first quest!");
                loadQuest();
                
            }
        }

        //увеличение статистик
        private void button2_Click(object sender, EventArgs e)
        {
            Game.str += 1;
            str.Text = Game.str.ToString();
            Game.stats -= 1;
            stats.Text = Game.stats.ToString();
            if (Game.stats == 0)
            {
                hideStatButtons(true);
            }
            firstLVL(Game.firstLvl);          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Game.agil += 1;
            agil.Text = Game.agil.ToString();
            Game.stats -= 1;
            stats.Text = Game.stats.ToString();
            if (Game.stats == 0)
            {
                hideStatButtons(true);
            }
            firstLVL(Game.firstLvl);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Game.intel += 1;
            intel.Text = Game.intel.ToString();
            Game.stats -= 1;
            stats.Text = Game.stats.ToString();
            if (Game.stats == 0)
            {
                hideStatButtons(true);
            }
            firstLVL(Game.firstLvl);
        }

        //загрузка
        private void loadQuest()
        {
            Game.umiUsed = false;

            Game.ap = 6 + Game.str*2;
            action.Text = Game.ap.ToString();
            StreamReader sr = new StreamReader("quests\\count.txt");
            int n = Int32.Parse(sr.ReadLine());
            sr.Close();
            sr = new StreamReader("quests\\starter_quest.txt");
            string s = sr.ReadLine();
            message(sys, "Battle starts");
            message("Your oleg goes to " + s);
            s = sr.ReadLine();
            s = sr.ReadLine();
            message("Your enemy is " + s);
            prepod_name.Text = s;
            s = sr.ReadLine();
            s = sr.ReadLine();
            Enemy.rage = Int32.Parse(s);
            set_rage();
            s = sr.ReadLine();
            Enemy.rage_coeff = Double.Parse(s);
            s = sr.ReadLine();
            Enemy.vision = Int32.Parse(s);
            checkExamButtons();
        }

        private void set_rage()
        {
            rage_bar.Value = Enemy.rage;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //драконить
        private void use1_Click(object sender, EventArgs e)
        {

            if (Game.ap < 2 || Enemy.rage == 100) return;
            Game.ap -= 2;
            action.Text = Game.ap.ToString();
            Random rand = new Random();
            int k = rand.Next(1, 50);
            double d = Enemy.rage + Enemy.rage_coeff * (k - Game.intel * 5);
            if (k - Game.intel * 5 < 5) d += Enemy.rage + Enemy.rage_coeff * 5;
            if (d > 100)
            {
                message(prepod_name.Text + " is in RAGE");
                Enemy.rage = 100;
                set_rage();
            }
            else
            {
                int buff = comletition.Value;
                comletition.Value += rand.Next(3, 20);
                buff = comletition.Value - buff;
                message("You got " + buff + " % of your work");
                buff = Enemy.rage;
                Enemy.rage = (Int32)d;
                set_rage();
                buff = Enemy.rage - buff;
                message(prepod_name.Text + " gets +" + buff + " rage");
                message(sys,"What next?");
            }
            checkExamButtons();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void use2_Click(object sender, EventArgs e)
        {
            Game.umiUsed = true;
            if (Game.ap < 4 || Enemy.rage == 100) return;
            Game.ap -= 4;
            action.Text = Game.ap.ToString();
            Random rand = new Random();
            if (Enemy.rage <= 25) 
            {
                if (rand.Next(1, 2) == 2) comletition.Value += 40;
                else Enemy.rage += 40;
            }

        }
    }
}
