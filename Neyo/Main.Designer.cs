namespace Neyo
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.PanelWindows = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.CloseBox = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.RainbowCheckBox = new Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.RainbowTimer = new System.Windows.Forms.Timer(this.components);
            this.PanelModules = new System.Windows.Forms.Panel();
            this.paneclicker = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Throwpot = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.siticoneTrackBar1 = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckBox1 = new Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ClickerMenu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.siticoneTrackBar2 = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.PanelWindows.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PanelModules.SuspendLayout();
            this.paneclicker.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelWindows
            // 
            this.PanelWindows.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.PanelWindows.Controls.Add(this.label2);
            this.PanelWindows.Controls.Add(this.Title);
            this.PanelWindows.Controls.Add(this.CloseBox);
            this.PanelWindows.Controls.Add(this.siticoneControlBox1);
            this.PanelWindows.Location = new System.Drawing.Point(3, 4);
            this.PanelWindows.Margin = new System.Windows.Forms.Padding(4);
            this.PanelWindows.Name = "PanelWindows";
            this.PanelWindows.Size = new System.Drawing.Size(1060, 46);
            this.PanelWindows.TabIndex = 0;
            this.PanelWindows.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelWindows_Paint);
            this.PanelWindows.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelWindows_MouseDown);
            this.PanelWindows.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelWindows_MouseMove);
            this.PanelWindows.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelWindows_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(93, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "1.0";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(17, 7);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(89, 32);
            this.Title.TabIndex = 2;
            this.Title.Text = "Neyo ";
            // 
            // CloseBox
            // 
            this.CloseBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBox.BorderRadius = 6;
            this.CloseBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.CloseBox.ControlBoxStyle = Siticone.Desktop.UI.WinForms.Enums.ControlBoxStyle.Custom;
            this.CloseBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CloseBox.HoverState.FillColor = System.Drawing.Color.Red;
            this.CloseBox.IconColor = System.Drawing.Color.White;
            this.CloseBox.Location = new System.Drawing.Point(1000, 1);
            this.CloseBox.Margin = new System.Windows.Forms.Padding(4);
            this.CloseBox.Name = "CloseBox";
            this.CloseBox.Size = new System.Drawing.Size(60, 42);
            this.CloseBox.TabIndex = 0;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.siticoneControlBox1.BorderRadius = 6;
            this.siticoneControlBox1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.siticoneControlBox1.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.siticoneControlBox1.HoverState.FillColor = System.Drawing.Color.Red;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(932, 1);
            this.siticoneControlBox1.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.Size = new System.Drawing.Size(60, 42);
            this.siticoneControlBox1.TabIndex = 1;
            // 
            // RainbowCheckBox
            // 
            this.RainbowCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RainbowCheckBox.CheckedState.BorderRadius = 4;
            this.RainbowCheckBox.CheckedState.BorderThickness = 0;
            this.RainbowCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RainbowCheckBox.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.RainbowCheckBox.Location = new System.Drawing.Point(13, 10);
            this.RainbowCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.RainbowCheckBox.Name = "RainbowCheckBox";
            this.RainbowCheckBox.Size = new System.Drawing.Size(27, 25);
            this.RainbowCheckBox.TabIndex = 1;
            this.RainbowCheckBox.Text = "siticoneCustomCheckBox1";
            this.RainbowCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.RainbowCheckBox.UncheckedState.BorderRadius = 4;
            this.RainbowCheckBox.UncheckedState.BorderThickness = 0;
            this.RainbowCheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.RainbowCheckBox.Click += new System.EventHandler(this.RainbowCheckBox_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.RainbowCheckBox);
            this.panel1.Location = new System.Drawing.Point(3, 508);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 42);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rainbow";
            // 
            // RainbowTimer
            // 
            this.RainbowTimer.Tick += new System.EventHandler(this.RainbowTimer_Tick);
            // 
            // PanelModules
            // 
            this.PanelModules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.PanelModules.Controls.Add(this.paneclicker);
            this.PanelModules.Controls.Add(this.panel2);
            this.PanelModules.Location = new System.Drawing.Point(3, 53);
            this.PanelModules.Margin = new System.Windows.Forms.Padding(4);
            this.PanelModules.Name = "PanelModules";
            this.PanelModules.Size = new System.Drawing.Size(1060, 462);
            this.PanelModules.TabIndex = 3;
            // 
            // paneclicker
            // 
            this.paneclicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.paneclicker.Controls.Add(this.label6);
            this.paneclicker.Controls.Add(this.label7);
            this.paneclicker.Controls.Add(this.siticoneTrackBar2);
            this.paneclicker.Controls.Add(this.textBox1);
            this.paneclicker.Controls.Add(this.Throwpot);
            this.paneclicker.Controls.Add(this.label5);
            this.paneclicker.Controls.Add(this.label4);
            this.paneclicker.Controls.Add(this.siticoneTrackBar1);
            this.paneclicker.Controls.Add(this.label3);
            this.paneclicker.Controls.Add(this.CheckBox1);
            this.paneclicker.Location = new System.Drawing.Point(13, 63);
            this.paneclicker.Margin = new System.Windows.Forms.Padding(4);
            this.paneclicker.Name = "paneclicker";
            this.paneclicker.Size = new System.Drawing.Size(1039, 388);
            this.paneclicker.TabIndex = 1;
            this.paneclicker.Paint += new System.Windows.Forms.PaintEventHandler(this.paneclicker_Paint);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(169, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(94, 27);
            this.textBox1.TabIndex = 9;
            this.textBox1.Tag = "";
            this.textBox1.Text = "NONE";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        

            // 
            // Throwpot
            // 
            this.Throwpot.Location = new System.Drawing.Point(944, 19);
            this.Throwpot.Margin = new System.Windows.Forms.Padding(4);
            this.Throwpot.Name = "Throwpot";
            this.Throwpot.Size = new System.Drawing.Size(1031, 380);
            this.Throwpot.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(456, 116);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(32, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Min CPS";
            // 
            // siticoneTrackBar1
            // 
            this.siticoneTrackBar1.Location = new System.Drawing.Point(36, 115);
            this.siticoneTrackBar1.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneTrackBar1.Name = "siticoneTrackBar1";
            this.siticoneTrackBar1.Size = new System.Drawing.Size(400, 28);
            this.siticoneTrackBar1.TabIndex = 5;
            this.siticoneTrackBar1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(75, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enable";
            // 
            // CheckBox1
            // 
            this.CheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CheckBox1.CheckedState.BorderRadius = 4;
            this.CheckBox1.CheckedState.BorderThickness = 0;
            this.CheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CheckBox1.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.CheckBox1.Location = new System.Drawing.Point(32, 31);
            this.CheckBox1.Margin = new System.Windows.Forms.Padding(4);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(31, 28);
            this.CheckBox1.TabIndex = 3;
            this.CheckBox1.Text = "siticoneCustomCheckBox1";
            this.CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.CheckBox1.UncheckedState.BorderRadius = 4;
            this.CheckBox1.UncheckedState.BorderThickness = 0;
            this.CheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.CheckBox1.Click += new System.EventHandler(this.siticoneCustomCheckBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.ClickerMenu);
            this.panel2.Location = new System.Drawing.Point(8, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1044, 48);
            this.panel2.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(917, 5);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(123, 39);
            this.button7.TabIndex = 8;
            this.button7.Text = "Destruct";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(788, 5);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(123, 39);
            this.button6.TabIndex = 7;
            this.button6.Text = "Config";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(657, 5);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 39);
            this.button5.TabIndex = 6;
            this.button5.Text = "Misc";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(527, 4);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 39);
            this.button4.TabIndex = 5;
            this.button4.Text = "Target";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(396, 5);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 39);
            this.button3.TabIndex = 4;
            this.button3.Text = "Refill";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(265, 5);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = "Wtap";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(135, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Throwpot";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClickerMenu
            // 
            this.ClickerMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClickerMenu.FlatAppearance.BorderSize = 0;
            this.ClickerMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClickerMenu.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClickerMenu.ForeColor = System.Drawing.Color.White;
            this.ClickerMenu.Location = new System.Drawing.Point(4, 4);
            this.ClickerMenu.Margin = new System.Windows.Forms.Padding(4);
            this.ClickerMenu.Name = "ClickerMenu";
            this.ClickerMenu.Size = new System.Drawing.Size(123, 39);
            this.ClickerMenu.TabIndex = 1;
            this.ClickerMenu.Text = "Clicker";
            this.ClickerMenu.UseVisualStyleBackColor = false;
            this.ClickerMenu.Click += new System.EventHandler(this.ClickerMenu_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(456, 189);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "20";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(32, 162);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = "Max CPS";
            // 
            // siticoneTrackBar2
            // 
            this.siticoneTrackBar2.Location = new System.Drawing.Point(36, 188);
            this.siticoneTrackBar2.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneTrackBar2.Name = "siticoneTrackBar2";
            this.siticoneTrackBar2.Size = new System.Drawing.Size(400, 28);
            this.siticoneTrackBar2.TabIndex = 10;
            this.siticoneTrackBar2.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.PanelModules);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelWindows);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Main_Load);
            this.PanelWindows.ResumeLayout(false);
            this.PanelWindows.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelModules.ResumeLayout(false);
            this.paneclicker.ResumeLayout(false);
            this.paneclicker.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelWindows;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox CloseBox;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox RainbowCheckBox;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer RainbowTimer;
        private System.Windows.Forms.Panel PanelModules;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ClickerMenu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel paneclicker;
        private System.Windows.Forms.Label label3;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox CheckBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar siticoneTrackBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel Throwpot;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar siticoneTrackBar2;
    }
}

