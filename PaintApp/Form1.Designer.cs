namespace PaintApp
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnEraser = new System.Windows.Forms.Button();
            this.BtnPaint = new System.Windows.Forms.Button();
            this.BtnRectangle = new System.Windows.Forms.Button();
            this.BtnEllipse = new System.Windows.Forms.Button();
            this.BtnLine = new System.Windows.Forms.Button();
            this.BtnPencil = new System.Windows.Forms.Button();
            this.BtnColor = new System.Windows.Forms.Button();
            this.Pic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.BtnSave);
            this.panel1.Controls.Add(this.BtnClear);
            this.panel1.Controls.Add(this.BtnEraser);
            this.panel1.Controls.Add(this.BtnPaint);
            this.panel1.Controls.Add(this.BtnRectangle);
            this.panel1.Controls.Add(this.BtnEllipse);
            this.panel1.Controls.Add(this.BtnLine);
            this.panel1.Controls.Add(this.BtnPencil);
            this.panel1.Controls.Add(this.BtnColor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 35);
            this.panel1.TabIndex = 0;
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnSave.Location = new System.Drawing.Point(718, 6);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 8;
            this.BtnSave.Text = "Mentés";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnClear.Location = new System.Drawing.Point(637, 6);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 5;
            this.BtnClear.Text = "Törlés";
            this.BtnClear.UseVisualStyleBackColor = false;
            // 
            // BtnEraser
            // 
            this.BtnEraser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnEraser.Location = new System.Drawing.Point(498, 6);
            this.BtnEraser.Name = "BtnEraser";
            this.BtnEraser.Size = new System.Drawing.Size(75, 23);
            this.BtnEraser.TabIndex = 6;
            this.BtnEraser.Text = "Radír";
            this.BtnEraser.UseVisualStyleBackColor = false;
            this.BtnEraser.Click += new System.EventHandler(this.BtnEraser_Click);
            // 
            // BtnPaint
            // 
            this.BtnPaint.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnPaint.Location = new System.Drawing.Point(417, 6);
            this.BtnPaint.Name = "BtnPaint";
            this.BtnPaint.Size = new System.Drawing.Size(75, 23);
            this.BtnPaint.TabIndex = 7;
            this.BtnPaint.Text = "Kitöltés";
            this.BtnPaint.UseVisualStyleBackColor = false;
            this.BtnPaint.Click += new System.EventHandler(this.BtnPaint_Click);
            // 
            // BtnRectangle
            // 
            this.BtnRectangle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnRectangle.Location = new System.Drawing.Point(336, 6);
            this.BtnRectangle.Name = "BtnRectangle";
            this.BtnRectangle.Size = new System.Drawing.Size(75, 23);
            this.BtnRectangle.TabIndex = 4;
            this.BtnRectangle.Text = "Négyszög";
            this.BtnRectangle.UseVisualStyleBackColor = false;
            this.BtnRectangle.Click += new System.EventHandler(this.BtnRectangle_Click);
            // 
            // BtnEllipse
            // 
            this.BtnEllipse.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnEllipse.Location = new System.Drawing.Point(255, 6);
            this.BtnEllipse.Name = "BtnEllipse";
            this.BtnEllipse.Size = new System.Drawing.Size(75, 23);
            this.BtnEllipse.TabIndex = 3;
            this.BtnEllipse.Text = "Kör";
            this.BtnEllipse.UseVisualStyleBackColor = false;
            this.BtnEllipse.Click += new System.EventHandler(this.BtnEllipse_Click);
            // 
            // BtnLine
            // 
            this.BtnLine.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnLine.Location = new System.Drawing.Point(174, 6);
            this.BtnLine.Name = "BtnLine";
            this.BtnLine.Size = new System.Drawing.Size(75, 23);
            this.BtnLine.TabIndex = 3;
            this.BtnLine.Text = "Vonal";
            this.BtnLine.UseVisualStyleBackColor = false;
            this.BtnLine.Click += new System.EventHandler(this.BtnLine_Click);
            // 
            // BtnPencil
            // 
            this.BtnPencil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnPencil.Location = new System.Drawing.Point(93, 6);
            this.BtnPencil.Name = "BtnPencil";
            this.BtnPencil.Size = new System.Drawing.Size(75, 23);
            this.BtnPencil.TabIndex = 3;
            this.BtnPencil.Text = "Cerúza";
            this.BtnPencil.UseVisualStyleBackColor = false;
            this.BtnPencil.Click += new System.EventHandler(this.BtnPencil_Click);
            // 
            // BtnColor
            // 
            this.BtnColor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnColor.Location = new System.Drawing.Point(12, 6);
            this.BtnColor.Name = "BtnColor";
            this.BtnColor.Size = new System.Drawing.Size(75, 23);
            this.BtnColor.TabIndex = 2;
            this.BtnColor.Text = "Szín";
            this.BtnColor.UseVisualStyleBackColor = false;
            this.BtnColor.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // Pic
            // 
            this.Pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pic.Location = new System.Drawing.Point(0, 35);
            this.Pic.Name = "Pic";
            this.Pic.Size = new System.Drawing.Size(800, 415);
            this.Pic.TabIndex = 1;
            this.Pic.TabStop = false;
            this.Pic.Paint += new System.Windows.Forms.PaintEventHandler(this.Pic_Paint);
            this.Pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseClick);
            this.Pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseDown);
            this.Pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseMove);
            this.Pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pic);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Pic;
        private System.Windows.Forms.Button BtnEllipse;
        private System.Windows.Forms.Button BtnLine;
        private System.Windows.Forms.Button BtnPencil;
        private System.Windows.Forms.Button BtnColor;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnEraser;
        private System.Windows.Forms.Button BtnPaint;
        private System.Windows.Forms.Button BtnRectangle;
    }
}

