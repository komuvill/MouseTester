using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseTester
{


    public partial class Form1 : Form
    {
        int eventCounter = 0;

        Stopwatch swMidClick = new Stopwatch();
        Stopwatch swLeftClick = new Stopwatch();
        Stopwatch swRightClick = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
            this.MouseWheel += Form1_MouseWheel;
        }

        private void Form1_MouseWheel(object sender, MouseEventArgs e)
        {
            if(e.Delta > 0)
            {
                eventCounter++;
                debugOutput.AppendText(eventCounter + " - Scrolled up.");
                debugOutput.AppendText(Environment.NewLine);

            }
            else
            {
                eventCounter++;
                debugOutput.AppendText(eventCounter + " - Scrolled down.");
                debugOutput.AppendText(Environment.NewLine);

            }
        }


        private void testArea_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                eventCounter++;
                debugOutput.AppendText(eventCounter + " - Left button pressed.");
                debugOutput.AppendText(Environment.NewLine);
                swLeftClick.Restart();
            }
            else if (e.Button == MouseButtons.Right)
            {
                eventCounter++;
                debugOutput.AppendText(eventCounter + " - Right button pressed.");
                debugOutput.AppendText(Environment.NewLine);
                swRightClick.Restart();
            }
            else if (e.Button == MouseButtons.Middle)
            {
                eventCounter++;
                debugOutput.AppendText(eventCounter + " - Scroll wheel pressed.");
                debugOutput.AppendText(Environment.NewLine);
                swMidClick.Restart();
            }
        }

        private void testArea_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                eventCounter++;
                debugOutput.AppendText(eventCounter + " - Left button released. (" + swLeftClick.ElapsedMilliseconds + "ms)");
                debugOutput.AppendText(Environment.NewLine);
            }
            else if (e.Button == MouseButtons.Right)
            {
                eventCounter++;
                debugOutput.AppendText(eventCounter + " - Right button released.(" + swRightClick.ElapsedMilliseconds + "ms)");
                debugOutput.AppendText(Environment.NewLine);
            }
            else if (e.Button == MouseButtons.Middle)
            {
                eventCounter++;
                debugOutput.AppendText(eventCounter + " - Scroll wheel released.(" + swMidClick.ElapsedMilliseconds + "ms)");
                debugOutput.AppendText(Environment.NewLine);
            }
        }

    }
}
