namespace Lab7
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.GeneralPanel = new System.Windows.Forms.Panel();
            this.Operations = new System.Windows.Forms.FlowLayoutPanel();
            this.DelButtom = new System.Windows.Forms.Button();
            this.ClearButtom = new System.Windows.Forms.Button();
            this.MultiplyButtom = new System.Windows.Forms.Button();
            this.DivideButtom = new System.Windows.Forms.Button();
            this.SumButtom = new System.Windows.Forms.Button();
            this.RestButtom = new System.Windows.Forms.Button();
            this.AnsButtom = new System.Windows.Forms.Button();
            this.EqualButtom = new System.Windows.Forms.Button();
            this.Numbers = new System.Windows.Forms.FlowLayoutPanel();
            this.SevenButtom = new System.Windows.Forms.Button();
            this.EightButtom = new System.Windows.Forms.Button();
            this.NineButtom = new System.Windows.Forms.Button();
            this.FourButtom = new System.Windows.Forms.Button();
            this.FiveButtom = new System.Windows.Forms.Button();
            this.SixButtom = new System.Windows.Forms.Button();
            this.OneButtom = new System.Windows.Forms.Button();
            this.TwoButtom = new System.Windows.Forms.Button();
            this.ThreeButtom = new System.Windows.Forms.Button();
            this.ZeroButtom = new System.Windows.Forms.Button();
            this.Pointbuttom = new System.Windows.Forms.Button();
            this.Screen = new System.Windows.Forms.FlowLayoutPanel();
            this.ScreenTextBox = new System.Windows.Forms.RichTextBox();
            this.GeneralPanel.SuspendLayout();
            this.Operations.SuspendLayout();
            this.Numbers.SuspendLayout();
            this.Screen.SuspendLayout();
            this.SuspendLayout();
            // 
            // GeneralPanel
            // 
            this.GeneralPanel.AutoSize = true;
            this.GeneralPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GeneralPanel.Controls.Add(this.Operations);
            this.GeneralPanel.Controls.Add(this.Numbers);
            this.GeneralPanel.Controls.Add(this.Screen);
            this.GeneralPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GeneralPanel.Location = new System.Drawing.Point(0, 0);
            this.GeneralPanel.Name = "GeneralPanel";
            this.GeneralPanel.Size = new System.Drawing.Size(800, 450);
            this.GeneralPanel.TabIndex = 0;
            // 
            // Operations
            // 
            this.Operations.Controls.Add(this.DelButtom);
            this.Operations.Controls.Add(this.ClearButtom);
            this.Operations.Controls.Add(this.MultiplyButtom);
            this.Operations.Controls.Add(this.DivideButtom);
            this.Operations.Controls.Add(this.SumButtom);
            this.Operations.Controls.Add(this.RestButtom);
            this.Operations.Controls.Add(this.AnsButtom);
            this.Operations.Controls.Add(this.EqualButtom);
            this.Operations.Dock = System.Windows.Forms.DockStyle.Left;
            this.Operations.Location = new System.Drawing.Point(517, 106);
            this.Operations.Name = "Operations";
            this.Operations.Size = new System.Drawing.Size(289, 344);
            this.Operations.TabIndex = 2;
            // 
            // DelButtom
            // 
            this.DelButtom.BackColor = System.Drawing.Color.Maroon;
            this.DelButtom.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.DelButtom.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.DelButtom.Location = new System.Drawing.Point(3, 3);
            this.DelButtom.Name = "DelButtom";
            this.DelButtom.Size = new System.Drawing.Size(134, 63);
            this.DelButtom.TabIndex = 3;
            this.DelButtom.Text = "DEL";
            this.DelButtom.UseVisualStyleBackColor = false;
            this.DelButtom.Click += new System.EventHandler(this.DelButtom_Click);
            // 
            // ClearButtom
            // 
            this.ClearButtom.BackColor = System.Drawing.Color.Maroon;
            this.ClearButtom.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.ClearButtom.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ClearButtom.Location = new System.Drawing.Point(143, 3);
            this.ClearButtom.Name = "ClearButtom";
            this.ClearButtom.Size = new System.Drawing.Size(134, 63);
            this.ClearButtom.TabIndex = 4;
            this.ClearButtom.Text = "AC";
            this.ClearButtom.UseVisualStyleBackColor = false;
            this.ClearButtom.Click += new System.EventHandler(this.ClearButtom_Click);
            // 
            // MultiplyButtom
            // 
            this.MultiplyButtom.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.MultiplyButtom.Location = new System.Drawing.Point(3, 72);
            this.MultiplyButtom.Name = "MultiplyButtom";
            this.MultiplyButtom.Size = new System.Drawing.Size(134, 63);
            this.MultiplyButtom.TabIndex = 11;
            this.MultiplyButtom.Text = "x";
            this.MultiplyButtom.UseVisualStyleBackColor = true;
            this.MultiplyButtom.Click += new System.EventHandler(this.MultiplyButtom_Click);
            // 
            // DivideButtom
            // 
            this.DivideButtom.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.DivideButtom.Location = new System.Drawing.Point(143, 72);
            this.DivideButtom.Name = "DivideButtom";
            this.DivideButtom.Size = new System.Drawing.Size(134, 63);
            this.DivideButtom.TabIndex = 6;
            this.DivideButtom.Text = "/";
            this.DivideButtom.UseVisualStyleBackColor = true;
            this.DivideButtom.Click += new System.EventHandler(this.DivideButtom_Click);
            // 
            // SumButtom
            // 
            this.SumButtom.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.SumButtom.Location = new System.Drawing.Point(3, 141);
            this.SumButtom.Name = "SumButtom";
            this.SumButtom.Size = new System.Drawing.Size(134, 63);
            this.SumButtom.TabIndex = 5;
            this.SumButtom.Text = "+";
            this.SumButtom.UseVisualStyleBackColor = true;
            this.SumButtom.Click += new System.EventHandler(this.SumButtom_Click);
            // 
            // RestButtom
            // 
            this.RestButtom.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.RestButtom.Location = new System.Drawing.Point(143, 141);
            this.RestButtom.Name = "RestButtom";
            this.RestButtom.Size = new System.Drawing.Size(134, 63);
            this.RestButtom.TabIndex = 12;
            this.RestButtom.Text = "-";
            this.RestButtom.UseVisualStyleBackColor = true;
            this.RestButtom.Click += new System.EventHandler(this.RestButtom_Click);
            // 
            // AnsButtom
            // 
            this.AnsButtom.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.AnsButtom.Location = new System.Drawing.Point(3, 210);
            this.AnsButtom.Name = "AnsButtom";
            this.AnsButtom.Size = new System.Drawing.Size(134, 63);
            this.AnsButtom.TabIndex = 9;
            this.AnsButtom.Text = "Ans";
            this.AnsButtom.UseVisualStyleBackColor = true;
            this.AnsButtom.Click += new System.EventHandler(this.AnsButtom_Click);
            // 
            // EqualButtom
            // 
            this.EqualButtom.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.EqualButtom.Location = new System.Drawing.Point(143, 210);
            this.EqualButtom.Name = "EqualButtom";
            this.EqualButtom.Size = new System.Drawing.Size(134, 63);
            this.EqualButtom.TabIndex = 10;
            this.EqualButtom.Text = "=";
            this.EqualButtom.UseVisualStyleBackColor = true;
            this.EqualButtom.Click += new System.EventHandler(this.EqualButtom_Click);
            // 
            // Numbers
            // 
            this.Numbers.Controls.Add(this.SevenButtom);
            this.Numbers.Controls.Add(this.EightButtom);
            this.Numbers.Controls.Add(this.NineButtom);
            this.Numbers.Controls.Add(this.FourButtom);
            this.Numbers.Controls.Add(this.FiveButtom);
            this.Numbers.Controls.Add(this.SixButtom);
            this.Numbers.Controls.Add(this.OneButtom);
            this.Numbers.Controls.Add(this.TwoButtom);
            this.Numbers.Controls.Add(this.ThreeButtom);
            this.Numbers.Controls.Add(this.ZeroButtom);
            this.Numbers.Controls.Add(this.Pointbuttom);
            this.Numbers.Dock = System.Windows.Forms.DockStyle.Left;
            this.Numbers.Location = new System.Drawing.Point(0, 106);
            this.Numbers.Name = "Numbers";
            this.Numbers.Size = new System.Drawing.Size(517, 344);
            this.Numbers.TabIndex = 1;
            // 
            // SevenButtom
            // 
            this.SevenButtom.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SevenButtom.Location = new System.Drawing.Point(3, 3);
            this.SevenButtom.Name = "SevenButtom";
            this.SevenButtom.Size = new System.Drawing.Size(160, 79);
            this.SevenButtom.TabIndex = 0;
            this.SevenButtom.Text = "7";
            this.SevenButtom.UseVisualStyleBackColor = true;
            this.SevenButtom.Click += new System.EventHandler(this.SevenButtom_Click);
            // 
            // EightButtom
            // 
            this.EightButtom.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.EightButtom.Location = new System.Drawing.Point(169, 3);
            this.EightButtom.Name = "EightButtom";
            this.EightButtom.Size = new System.Drawing.Size(160, 79);
            this.EightButtom.TabIndex = 1;
            this.EightButtom.Text = "8";
            this.EightButtom.UseVisualStyleBackColor = true;
            this.EightButtom.Click += new System.EventHandler(this.EightButtom_Click);
            // 
            // NineButtom
            // 
            this.NineButtom.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.NineButtom.Location = new System.Drawing.Point(335, 3);
            this.NineButtom.Name = "NineButtom";
            this.NineButtom.Size = new System.Drawing.Size(160, 79);
            this.NineButtom.TabIndex = 2;
            this.NineButtom.Text = "9";
            this.NineButtom.UseVisualStyleBackColor = true;
            this.NineButtom.Click += new System.EventHandler(this.NineButtom_Click);
            // 
            // FourButtom
            // 
            this.FourButtom.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.FourButtom.Location = new System.Drawing.Point(3, 88);
            this.FourButtom.Name = "FourButtom";
            this.FourButtom.Size = new System.Drawing.Size(160, 79);
            this.FourButtom.TabIndex = 3;
            this.FourButtom.Text = "4";
            this.FourButtom.UseVisualStyleBackColor = true;
            this.FourButtom.Click += new System.EventHandler(this.FourButtom_Click);
            // 
            // FiveButtom
            // 
            this.FiveButtom.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.FiveButtom.Location = new System.Drawing.Point(169, 88);
            this.FiveButtom.Name = "FiveButtom";
            this.FiveButtom.Size = new System.Drawing.Size(160, 79);
            this.FiveButtom.TabIndex = 4;
            this.FiveButtom.Text = "5";
            this.FiveButtom.UseVisualStyleBackColor = true;
            this.FiveButtom.Click += new System.EventHandler(this.FiveButtom_Click);
            // 
            // SixButtom
            // 
            this.SixButtom.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.SixButtom.Location = new System.Drawing.Point(335, 88);
            this.SixButtom.Name = "SixButtom";
            this.SixButtom.Size = new System.Drawing.Size(160, 79);
            this.SixButtom.TabIndex = 5;
            this.SixButtom.Text = "6";
            this.SixButtom.UseVisualStyleBackColor = true;
            this.SixButtom.Click += new System.EventHandler(this.SixButtom_Click);
            // 
            // OneButtom
            // 
            this.OneButtom.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.OneButtom.Location = new System.Drawing.Point(3, 173);
            this.OneButtom.Name = "OneButtom";
            this.OneButtom.Size = new System.Drawing.Size(160, 79);
            this.OneButtom.TabIndex = 6;
            this.OneButtom.Text = "1";
            this.OneButtom.UseVisualStyleBackColor = true;
            this.OneButtom.Click += new System.EventHandler(this.OneButtom_Click);
            // 
            // TwoButtom
            // 
            this.TwoButtom.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.TwoButtom.Location = new System.Drawing.Point(169, 173);
            this.TwoButtom.Name = "TwoButtom";
            this.TwoButtom.Size = new System.Drawing.Size(160, 79);
            this.TwoButtom.TabIndex = 7;
            this.TwoButtom.Text = "2";
            this.TwoButtom.UseVisualStyleBackColor = true;
            this.TwoButtom.Click += new System.EventHandler(this.TwoButtom_Click);
            // 
            // ThreeButtom
            // 
            this.ThreeButtom.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.ThreeButtom.Location = new System.Drawing.Point(335, 173);
            this.ThreeButtom.Name = "ThreeButtom";
            this.ThreeButtom.Size = new System.Drawing.Size(160, 79);
            this.ThreeButtom.TabIndex = 8;
            this.ThreeButtom.Text = "3";
            this.ThreeButtom.UseVisualStyleBackColor = true;
            this.ThreeButtom.Click += new System.EventHandler(this.ThreeButtom_Click);
            // 
            // ZeroButtom
            // 
            this.ZeroButtom.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.ZeroButtom.Location = new System.Drawing.Point(3, 258);
            this.ZeroButtom.Name = "ZeroButtom";
            this.ZeroButtom.Size = new System.Drawing.Size(160, 79);
            this.ZeroButtom.TabIndex = 9;
            this.ZeroButtom.Text = "0";
            this.ZeroButtom.UseVisualStyleBackColor = true;
            this.ZeroButtom.Click += new System.EventHandler(this.ZeroButtom_Click);
            // 
            // Pointbuttom
            // 
            this.Pointbuttom.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.Pointbuttom.Location = new System.Drawing.Point(169, 258);
            this.Pointbuttom.Name = "Pointbuttom";
            this.Pointbuttom.Size = new System.Drawing.Size(160, 79);
            this.Pointbuttom.TabIndex = 10;
            this.Pointbuttom.Text = ".";
            this.Pointbuttom.UseVisualStyleBackColor = true;
            // 
            // Screen
            // 
            this.Screen.Controls.Add(this.ScreenTextBox);
            this.Screen.Dock = System.Windows.Forms.DockStyle.Top;
            this.Screen.Location = new System.Drawing.Point(0, 0);
            this.Screen.Name = "Screen";
            this.Screen.Size = new System.Drawing.Size(800, 106);
            this.Screen.TabIndex = 0;
            // 
            // ScreenTextBox
            // 
            this.ScreenTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.ScreenTextBox.Location = new System.Drawing.Point(3, 3);
            this.ScreenTextBox.Name = "ScreenTextBox";
            this.ScreenTextBox.ReadOnly = true;
            this.ScreenTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ScreenTextBox.Size = new System.Drawing.Size(791, 96);
            this.ScreenTextBox.TabIndex = 0;
            this.ScreenTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GeneralPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GeneralPanel.ResumeLayout(false);
            this.Operations.ResumeLayout(false);
            this.Numbers.ResumeLayout(false);
            this.Screen.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel GeneralPanel;
        private System.Windows.Forms.FlowLayoutPanel Operations;
        private System.Windows.Forms.Button DelButtom;
        private System.Windows.Forms.Button ClearButtom;
        private System.Windows.Forms.Button SumButtom;
        private System.Windows.Forms.Button DivideButtom;
        private System.Windows.Forms.Button AnsButtom;
        private System.Windows.Forms.Button EqualButtom;
        private System.Windows.Forms.FlowLayoutPanel Numbers;
        private System.Windows.Forms.Button SevenButtom;
        private System.Windows.Forms.Button EightButtom;
        private System.Windows.Forms.Button NineButtom;
        private System.Windows.Forms.Button FourButtom;
        private System.Windows.Forms.Button FiveButtom;
        private System.Windows.Forms.Button SixButtom;
        private System.Windows.Forms.Button OneButtom;
        private System.Windows.Forms.Button TwoButtom;
        private System.Windows.Forms.Button ThreeButtom;
        private System.Windows.Forms.Button ZeroButtom;
        private System.Windows.Forms.Button Pointbuttom;
        private System.Windows.Forms.FlowLayoutPanel Screen;
        private System.Windows.Forms.RichTextBox ScreenTextBox;
        private System.Windows.Forms.Button MultiplyButtom;
        private System.Windows.Forms.Button RestButtom;
    }
}

