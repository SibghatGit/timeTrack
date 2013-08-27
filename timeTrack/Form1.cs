using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timeTrack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            string[] lines = System.IO.File.ReadAllLines(@"time.csv");
            list.View = View.Details;
            list.GridLines = true;
            string[] header = lines[0].Split('|'); 
            list.Columns.Add(header[0], 150, HorizontalAlignment.Center);
            list.Columns.Add(header[1], 150, HorizontalAlignment.Center);
            list.Columns.Add(header[2], 75, HorizontalAlignment.Center);
            list.Columns.Add(header[3], 100, HorizontalAlignment.Center);
            projectLab.Visible = false;
            messageLab.Visible = false; 
            foreach (string s in lines)
            {
                string[] lts = s.Split('|');
                ListViewItem lvi = new ListViewItem(lts[0]);
                lvi.SubItems.Add(lts[1]);
                lvi.SubItems.Add(lts[2]);
                lvi.SubItems.Add(lts[3]);
                list.Items.Add(lvi); 
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProjectLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void startTimeLabel(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void StartButtonClicked(object sender, EventArgs e)
        {
            projectLab.Visible = true;
            messageLab.Visible = true; 
            startTime.Text = DateTime.Now.ToShortTimeString();
            projectLab.Text = ProjectTextBox.Text;
            ProjectTextBox.Visible = false;
            messageLab.Text = messageTextbox.Text;
            messageTextbox.Visible = false;
            startButton.Visible = false;
            endButton.Visible = true; 

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {          
               
            time.Text = DateTime.Now.ToShortTimeString();
          }

        private void listView(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void endButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = File.AppendText(@"time.csv"))
            {
                sw.WriteLine(DateTime.Now.ToShortDateString()+"|"+ projectLab.Text+"|"+8+"|"+messageLab.Text);
            }
            projectLab.Visible = false;
            messageLab.Visible = false;
            endButton.Visible = false;
            startButton.Visible = true;
            ProjectTextBox.Visible = true;
            messageTextbox.Visible = true;
            ProjectTextBox.Text = "";
            messageTextbox.Text = ""; 
            //Application.Exit(); 
        }
    }
}
