
namespace OOP_lab12
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DrawPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonSegment = new System.Windows.Forms.RadioButton();
            this.LightPurple = new System.Windows.Forms.Panel();
            this.Purple = new System.Windows.Forms.Panel();
            this.Teal = new System.Windows.Forms.Panel();
            this.Blue = new System.Windows.Forms.Panel();
            this.SkyBlue = new System.Windows.Forms.Panel();
            this.Lime = new System.Windows.Forms.Panel();
            this.Green = new System.Windows.Forms.Panel();
            this.Yellow = new System.Windows.Forms.Panel();
            this.Orange = new System.Windows.Forms.Panel();
            this.Red = new System.Windows.Forms.Panel();
            this.ButtonPrTriangle = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelColor = new System.Windows.Forms.Panel();
            this.Color = new System.Windows.Forms.Label();
            this.White = new System.Windows.Forms.Panel();
            this.Brown = new System.Windows.Forms.Panel();
            this.Gray = new System.Windows.Forms.Panel();
            this.Black = new System.Windows.Forms.Panel();
            this.ButtonEllipse = new System.Windows.Forms.RadioButton();
            this.ButtonTriangle = new System.Windows.Forms.RadioButton();
            this.ButtonRect = new System.Windows.Forms.RadioButton();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // DrawPanel
            // 
            this.DrawPanel.BackColor = System.Drawing.Color.White;
            this.DrawPanel.Location = new System.Drawing.Point(12, 80);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Size = new System.Drawing.Size(928, 435);
            this.DrawPanel.TabIndex = 0;
            this.DrawPanel.Click += new System.EventHandler(this.DrawPanel_Click);
            this.DrawPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawPanel_MouseDown);
            this.DrawPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawPanel_MouseMove);
            this.DrawPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawPanel_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ButtonSegment);
            this.groupBox1.Controls.Add(this.LightPurple);
            this.groupBox1.Controls.Add(this.Purple);
            this.groupBox1.Controls.Add(this.Teal);
            this.groupBox1.Controls.Add(this.Blue);
            this.groupBox1.Controls.Add(this.SkyBlue);
            this.groupBox1.Controls.Add(this.Lime);
            this.groupBox1.Controls.Add(this.Green);
            this.groupBox1.Controls.Add(this.Yellow);
            this.groupBox1.Controls.Add(this.Orange);
            this.groupBox1.Controls.Add(this.Red);
            this.groupBox1.Controls.Add(this.ButtonPrTriangle);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.White);
            this.groupBox1.Controls.Add(this.Brown);
            this.groupBox1.Controls.Add(this.Gray);
            this.groupBox1.Controls.Add(this.Black);
            this.groupBox1.Controls.Add(this.ButtonEllipse);
            this.groupBox1.Controls.Add(this.ButtonTriangle);
            this.groupBox1.Controls.Add(this.ButtonRect);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(928, 62);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // ButtonSegment
            // 
            this.ButtonSegment.AutoSize = true;
            this.ButtonSegment.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSegment.Image")));
            this.ButtonSegment.Location = new System.Drawing.Point(220, 13);
            this.ButtonSegment.Name = "ButtonSegment";
            this.ButtonSegment.Size = new System.Drawing.Size(46, 34);
            this.ButtonSegment.TabIndex = 18;
            this.ButtonSegment.Text = "       \r\n\r\n";
            this.ButtonSegment.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonSegment.UseVisualStyleBackColor = true;
            // 
            // LightPurple
            // 
            this.LightPurple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.LightPurple.Location = new System.Drawing.Point(581, 36);
            this.LightPurple.Name = "LightPurple";
            this.LightPurple.Size = new System.Drawing.Size(20, 15);
            this.LightPurple.TabIndex = 17;
            this.LightPurple.Click += new System.EventHandler(this.LightPurple_Click);
            // 
            // Purple
            // 
            this.Purple.BackColor = System.Drawing.Color.Purple;
            this.Purple.Location = new System.Drawing.Point(581, 15);
            this.Purple.Name = "Purple";
            this.Purple.Size = new System.Drawing.Size(20, 15);
            this.Purple.TabIndex = 16;
            this.Purple.Click += new System.EventHandler(this.Purple_Click);
            // 
            // Teal
            // 
            this.Teal.BackColor = System.Drawing.Color.Teal;
            this.Teal.Location = new System.Drawing.Point(555, 36);
            this.Teal.Name = "Teal";
            this.Teal.Size = new System.Drawing.Size(20, 15);
            this.Teal.TabIndex = 15;
            this.Teal.Click += new System.EventHandler(this.Teal_Click);
            // 
            // Blue
            // 
            this.Blue.BackColor = System.Drawing.Color.Blue;
            this.Blue.Location = new System.Drawing.Point(529, 36);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(20, 15);
            this.Blue.TabIndex = 14;
            this.Blue.Click += new System.EventHandler(this.Blue_Click);
            // 
            // SkyBlue
            // 
            this.SkyBlue.BackColor = System.Drawing.Color.SkyBlue;
            this.SkyBlue.Location = new System.Drawing.Point(503, 36);
            this.SkyBlue.Name = "SkyBlue";
            this.SkyBlue.Size = new System.Drawing.Size(20, 15);
            this.SkyBlue.TabIndex = 13;
            this.SkyBlue.Click += new System.EventHandler(this.SkyBlue_Click);
            // 
            // Lime
            // 
            this.Lime.BackColor = System.Drawing.Color.Lime;
            this.Lime.Location = new System.Drawing.Point(477, 36);
            this.Lime.Name = "Lime";
            this.Lime.Size = new System.Drawing.Size(20, 15);
            this.Lime.TabIndex = 12;
            this.Lime.Click += new System.EventHandler(this.Lime_Click);
            // 
            // Green
            // 
            this.Green.BackColor = System.Drawing.Color.Green;
            this.Green.Location = new System.Drawing.Point(451, 36);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(20, 15);
            this.Green.TabIndex = 8;
            this.Green.Click += new System.EventHandler(this.Green_Click);
            // 
            // Yellow
            // 
            this.Yellow.BackColor = System.Drawing.Color.Yellow;
            this.Yellow.Location = new System.Drawing.Point(555, 15);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(20, 15);
            this.Yellow.TabIndex = 11;
            this.Yellow.Click += new System.EventHandler(this.Yellow_Click);
            // 
            // Orange
            // 
            this.Orange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Orange.Location = new System.Drawing.Point(529, 15);
            this.Orange.Name = "Orange";
            this.Orange.Size = new System.Drawing.Size(20, 15);
            this.Orange.TabIndex = 10;
            this.Orange.Click += new System.EventHandler(this.Orange_Click);
            // 
            // Red
            // 
            this.Red.BackColor = System.Drawing.Color.Red;
            this.Red.Location = new System.Drawing.Point(503, 15);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(20, 15);
            this.Red.TabIndex = 8;
            this.Red.Click += new System.EventHandler(this.Red_Click);
            // 
            // ButtonPrTriangle
            // 
            this.ButtonPrTriangle.AutoSize = true;
            this.ButtonPrTriangle.Image = ((System.Drawing.Image)(resources.GetObject("ButtonPrTriangle.Image")));
            this.ButtonPrTriangle.Location = new System.Drawing.Point(168, 13);
            this.ButtonPrTriangle.Name = "ButtonPrTriangle";
            this.ButtonPrTriangle.Size = new System.Drawing.Size(46, 34);
            this.ButtonPrTriangle.TabIndex = 9;
            this.ButtonPrTriangle.Text = "       \r\n\r\n";
            this.ButtonPrTriangle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonPrTriangle.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panelColor);
            this.panel4.Controls.Add(this.Color);
            this.panel4.Location = new System.Drawing.Point(328, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(78, 49);
            this.panel4.TabIndex = 8;
            // 
            // panelColor
            // 
            this.panelColor.BackColor = System.Drawing.Color.Black;
            this.panelColor.Location = new System.Drawing.Point(3, 0);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(72, 29);
            this.panelColor.TabIndex = 1;
            // 
            // Color
            // 
            this.Color.AutoSize = true;
            this.Color.Location = new System.Drawing.Point(19, 28);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(36, 15);
            this.Color.TabIndex = 0;
            this.Color.Text = "Color";
            // 
            // White
            // 
            this.White.BackColor = System.Drawing.Color.White;
            this.White.Location = new System.Drawing.Point(425, 36);
            this.White.Name = "White";
            this.White.Size = new System.Drawing.Size(20, 15);
            this.White.TabIndex = 7;
            this.White.Click += new System.EventHandler(this.White_Click);
            // 
            // Brown
            // 
            this.Brown.BackColor = System.Drawing.Color.Brown;
            this.Brown.Location = new System.Drawing.Point(477, 15);
            this.Brown.Name = "Brown";
            this.Brown.Size = new System.Drawing.Size(20, 15);
            this.Brown.TabIndex = 6;
            this.Brown.Click += new System.EventHandler(this.Brown_Click);
            // 
            // Gray
            // 
            this.Gray.BackColor = System.Drawing.Color.Gray;
            this.Gray.Location = new System.Drawing.Point(451, 15);
            this.Gray.Name = "Gray";
            this.Gray.Size = new System.Drawing.Size(20, 15);
            this.Gray.TabIndex = 5;
            this.Gray.Click += new System.EventHandler(this.Gray_Click);
            // 
            // Black
            // 
            this.Black.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Black.Location = new System.Drawing.Point(425, 15);
            this.Black.Name = "Black";
            this.Black.Size = new System.Drawing.Size(20, 15);
            this.Black.TabIndex = 4;
            this.Black.Click += new System.EventHandler(this.Black_Click);
            // 
            // ButtonEllipse
            // 
            this.ButtonEllipse.AutoSize = true;
            this.ButtonEllipse.Image = ((System.Drawing.Image)(resources.GetObject("ButtonEllipse.Image")));
            this.ButtonEllipse.Location = new System.Drawing.Point(116, 18);
            this.ButtonEllipse.Name = "ButtonEllipse";
            this.ButtonEllipse.Size = new System.Drawing.Size(46, 24);
            this.ButtonEllipse.TabIndex = 3;
            this.ButtonEllipse.Text = "       ";
            this.ButtonEllipse.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonEllipse.UseVisualStyleBackColor = true;
            // 
            // ButtonTriangle
            // 
            this.ButtonTriangle.AutoSize = true;
            this.ButtonTriangle.Image = ((System.Drawing.Image)(resources.GetObject("ButtonTriangle.Image")));
            this.ButtonTriangle.Location = new System.Drawing.Point(64, 15);
            this.ButtonTriangle.Name = "ButtonTriangle";
            this.ButtonTriangle.Size = new System.Drawing.Size(46, 24);
            this.ButtonTriangle.TabIndex = 2;
            this.ButtonTriangle.Text = "       ";
            this.ButtonTriangle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonTriangle.UseVisualStyleBackColor = true;
            // 
            // ButtonRect
            // 
            this.ButtonRect.AutoSize = true;
            this.ButtonRect.Image = ((System.Drawing.Image)(resources.GetObject("ButtonRect.Image")));
            this.ButtonRect.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonRect.Location = new System.Drawing.Point(6, 15);
            this.ButtonRect.Name = "ButtonRect";
            this.ButtonRect.Size = new System.Drawing.Size(46, 24);
            this.ButtonRect.TabIndex = 1;
            this.ButtonRect.Text = "       ";
            this.ButtonRect.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(952, 527);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DrawPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graphics editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DrawPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ButtonTriangle;
        private System.Windows.Forms.RadioButton ButtonRect;
        private System.Windows.Forms.RadioButton ButtonEllipse;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Label Color;
        private System.Windows.Forms.Panel White;
        private System.Windows.Forms.Panel Brown;
        private System.Windows.Forms.Panel Gray;
        private System.Windows.Forms.Panel Black;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.RadioButton ButtonPrTriangle;
        private System.Windows.Forms.Panel Red;
        private System.Windows.Forms.Panel Yellow;
        private System.Windows.Forms.Panel Orange;
        private System.Windows.Forms.Panel Lime;
        private System.Windows.Forms.Panel Green;
        private System.Windows.Forms.Panel Blue;
        private System.Windows.Forms.Panel SkyBlue;
        private System.Windows.Forms.Panel Teal;
        private System.Windows.Forms.Panel LightPurple;
        private System.Windows.Forms.Panel Purple;
        private System.Windows.Forms.RadioButton ButtonSegment;
    }
}

