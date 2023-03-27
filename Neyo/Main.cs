
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Neyo
{
 
    public partial class Main : Form
    {

        Point Pos;
        bool mDown = false;
    
        Color[] rainbowColors = { Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Blue, Color.Indigo, Color.Violet };



        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void PanelWindows_MouseDown(object sender, MouseEventArgs e)
        {
            Pos.X = e.X;
            Pos.Y = e.Y;
            mDown = true;

        }

        private void PanelWindows_MouseMove(object sender, MouseEventArgs e)
        {

            if(mDown)
            {
                Point currentPos = PointToScreen(e.Location);
                Location = new Point(currentPos.X - Pos.X, currentPos.Y - Pos.Y);

            }
       
        }

        private void PanelWindows_MouseUp(object sender, MouseEventArgs e)
        {
            mDown = false;
        }

        private Timer rainbowTimer;
        private Color originalBackColor;
        private Color[] rainbowColorsArray = { Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Blue, Color.Indigo, Color.Violet };
        private int currentColorIndex = 0;

        private void RainbowCheckBox_Click(object sender, EventArgs e)
        {
            if (RainbowCheckBox.Checked)
            {
                originalBackColor = this.BackColor;
                rainbowTimer = new Timer();
                rainbowTimer.Interval = 100; //Intervalo menor para una transición más suave
                rainbowTimer.Tick += new EventHandler(RainbowTimer_Tick);
                rainbowTimer.Start();
            }
            else
            {
                this.BackColor = originalBackColor;
                rainbowTimer.Stop();
            }
        }

        private void RainbowTimer_Tick(object sender, EventArgs e)
        {
            currentColorIndex = (currentColorIndex + 1) % rainbowColorsArray.Length;
            Color nextColor = rainbowColorsArray[currentColorIndex];
            this.BackColor = InterpolateColor(this.BackColor, nextColor, 0.1f);
        }

        private Color InterpolateColor(Color color1, Color color2, float factor)
        {
            int r = (int)Math.Round((1 - factor) * color1.R + factor * color2.R);
            int g = (int)Math.Round((1 - factor) * color1.G + factor * color2.G);
            int b = (int)Math.Round((1 - factor) * color1.B + factor * color2.B);
            return Color.FromArgb(r, g, b);
        }

        private void PanelWindows_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void paneclicker_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ClickerMenu_Click(object sender, EventArgs e)
        {
            Throwpot.Visible = false; // oculta el panel anterior si está abierto
            paneclicker.Visible = true; // muestra el panel actual

        }

        private void button1_Click(object sender, EventArgs e)
        {
            paneclicker.Visible = true;
            Throwpot.Visible = true; // muestra el panel actual

        }

        private void Throwpot_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool checkBoxActivado;

        private void siticoneCustomCheckBox1_Click(object sender, EventArgs e)
        {
            if (CheckBox1.Checked)
            {
                textBox1.Enabled = true;
                checkBoxActivado = true;
            }
            else
            {
                textBox1.Enabled = false;
                checkBoxActivado = false;
            }
        }

        

    }
}
