using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;
using System.Threading;
using System.Diagnostics;
namespace TOOL_BO4_PC_UNDETECTED_BY_EFK
{
   
    public partial class Form1 : Form
    {
        Mem m = new Mem();
        bool game;
        public Form1()
        {
            InitializeComponent();
          
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            game = m.OpenProcess("BlackOps4");

            Thread.Sleep(1000);
            backgroundWorker1.ReportProgress(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
            Process.Start("https://discord.gg/qtGHtKRjGK");
            MessageBox.Show("Welcome to INFARCTED.CC BO4 SOURCE CHEAT BY EFK");
            MessageBox.Show("Just Disable Your AV");
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m.WriteMemory("base+0xDE80D74", "string", textBox1.Text);
            m.WriteMemory("base+0xEA3DC14", "string", textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ALL COLOR FOR CHANGE NAME : \n^1 = RED\n^2 = GREEN\n^3 = YELLOW\n^4 = BLUE\n^5 = CYAN\n^6 = PURPLE\n^7 = WHITE\n^8 = BROWN\n^9 = GREY\n^0 = BLACK");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.WindowState = FormWindowState.Minimized;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                m.WriteMemory("base+0x9353A00,0xE40", "byte", "5");
            }
            else
            {
                m.WriteMemory("base+0x9353A00,0xE40", "byte", "4");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            m.WriteMemory("base+0xDE80D74", "string", "^1" + textBox1.Text);
            m.WriteMemory("base+0xEA3DC14", "string", "^1" + textBox1.Text);

            m.WriteMemory("base+0xDE80D74", "string", "^2" + textBox1.Text);
            m.WriteMemory("base+0xEA3DC14", "string", "^2" + textBox1.Text);

            m.WriteMemory("base+0xDE80D74", "string", "^3" + textBox1.Text);
            m.WriteMemory("base+0xEA3DC14", "string", "^3" + textBox1.Text);

            m.WriteMemory("base+0xDE80D74", "string", "^4" + textBox1.Text);
            m.WriteMemory("base+0xEA3DC14", "string", "^4" + textBox1.Text);

            m.WriteMemory("base+0xDE80D74", "string", "^6" + textBox1.Text);
            m.WriteMemory("base+0xEA3DC14", "string", "^6" + textBox1.Text);

            m.WriteMemory("base+0xDE80D74", "string", "^7" + textBox1.Text);
            m.WriteMemory("base+0xEA3DC14", "string", "^7" + textBox1.Text);

            m.WriteMemory("base+0xDE80D74", "string", "^5" + textBox1.Text);
            m.WriteMemory("base+0xEA3DC14", "string", "^5" + textBox1.Text);

            m.WriteMemory("base+0xDE80D74", "string", "^9" + textBox1.Text);
            m.WriteMemory("base+0xEA3DC14", "string", "^9" + textBox1.Text);

            m.WriteMemory("base+0xDE80D74", "string", "^1" + textBox1.Text);
            m.WriteMemory("base+0xEA3DC14", "string", "^1" + textBox1.Text);

            m.WriteMemory("base+0xDE80D74", "string", "^8" + textBox1.Text);
            m.WriteMemory("base+0xEA3DC14", "string", "^8" + textBox1.Text);

            m.WriteMemory("base+0xDE80D74", "string", "^2" + textBox1.Text);
            m.WriteMemory("base+0xEA3DC14", "string", "^2" + textBox1.Text);

            m.WriteMemory("base+0xDE80D74", "string", "^0" + textBox1.Text);
            m.WriteMemory("base+0xEA3DC14", "string", "^0" + textBox1.Text);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                point.Start();
            }
            else
            {
                point.Stop();
                m.WriteMemory("base+0x9353A00,0x446C", "int", "500");
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            m.WriteMemory("base+0x9353A00,0x43DC", "float", textBox2.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            m.WriteMemory("base+0x9353A00,0x4470", "int", textBox3.Text);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                ammo.Start();
            }
            else
            {
                ammo.Stop();
                m.WriteMemory("base+0x9353A00,0x1324", "int", "0");
            }
        }

        private void ammo_Tick(object sender, EventArgs e)
        {
            m.WriteMemory("base+0x9353A00,0x1324", "int", "999999");
        }

        private void point_Tick(object sender, EventArgs e)
        {
            m.WriteMemory("base+0x9353A00,0x446C", "int", "999999");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            m.WriteMemory("base+0x9353A00,0x60", "int", textBox4.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            m.WriteMemory("base+0x9353A00,0x178", "int", textBox4.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            m.WriteMemory("base+0x9353A00,0x1B0", "int", textBox4.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            m.WriteMemory("base+0x8B501E4", "int", textBox5.Text);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            m.ReadInt("base+0x9353A00,0xF20", label5.Text);
        }
    }
}
