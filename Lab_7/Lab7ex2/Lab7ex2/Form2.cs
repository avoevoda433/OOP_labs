using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7ex2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            this.BackColor = Color.Green;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            using (GraphicsPath myPath = new GraphicsPath())
            {
                myPath.AddLines(new[] {new Point(0, Height/2),
                                       new Point(Width/2, 0),
                                       new Point(Width, Height/2),
                                       new Point(Width/2, Height)});
                Region = new Region(myPath);
            }
        }
    }
}
