namespace Laba3
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
            this.refractionBar = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.reflectionBar = new System.Windows.Forms.TrackBar();
            this.colorBar = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.zBar = new System.Windows.Forms.TrackBar();
            this.yBar = new System.Windows.Forms.TrackBar();
            this.xBar = new System.Windows.Forms.TrackBar();
            this.sizeBar = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.refractionBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reflectionBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeBar)).BeginInit();
            this.SuspendLayout();
            // 
            // refractionBar
            // 
            this.refractionBar.Location = new System.Drawing.Point(878, 229);
            this.refractionBar.Name = "refractionBar";
            this.refractionBar.Size = new System.Drawing.Size(163, 45);
            this.refractionBar.TabIndex = 29;
            this.refractionBar.Scroll += new System.EventHandler(this.refractionBar_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(893, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Коэффициент преломления";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(897, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Коэффициент отражения";
            // 
            // reflectionBar
            // 
            this.reflectionBar.Location = new System.Drawing.Point(878, 149);
            this.reflectionBar.Name = "reflectionBar";
            this.reflectionBar.Size = new System.Drawing.Size(163, 45);
            this.reflectionBar.TabIndex = 26;
            this.reflectionBar.Scroll += new System.EventHandler(this.reflectionBar_Scroll);
            // 
            // colorBar
            // 
            this.colorBar.Location = new System.Drawing.Point(878, 81);
            this.colorBar.Name = "colorBar";
            this.colorBar.Size = new System.Drawing.Size(163, 45);
            this.colorBar.TabIndex = 25;
            this.colorBar.Scroll += new System.EventHandler(this.boxColorBar_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(939, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Цвет";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(1057, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "X:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(1055, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(1055, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Z:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(1166, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Позиция";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(939, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Размер";
            // 
            // zBar
            // 
            this.zBar.Location = new System.Drawing.Point(1075, 126);
            this.zBar.Name = "zBar";
            this.zBar.Size = new System.Drawing.Size(207, 45);
            this.zBar.TabIndex = 18;
            this.zBar.Scroll += new System.EventHandler(this.boxZBar_Scroll);
            // 
            // yBar
            // 
            this.yBar.Location = new System.Drawing.Point(1075, 75);
            this.yBar.Name = "yBar";
            this.yBar.Size = new System.Drawing.Size(207, 45);
            this.yBar.TabIndex = 17;
            this.yBar.Scroll += new System.EventHandler(this.boxYBar_Scroll);
            // 
            // xBar
            // 
            this.xBar.Location = new System.Drawing.Point(1075, 24);
            this.xBar.Name = "xBar";
            this.xBar.Size = new System.Drawing.Size(207, 45);
            this.xBar.TabIndex = 16;
            this.xBar.Scroll += new System.EventHandler(this.boxXBar_Scroll);
            // 
            // sizeBar
            // 
            this.sizeBar.Location = new System.Drawing.Point(878, 30);
            this.sizeBar.Name = "sizeBar";
            this.sizeBar.Size = new System.Drawing.Size(163, 45);
            this.sizeBar.TabIndex = 15;
            this.sizeBar.Scroll += new System.EventHandler(this.boxSizeBar_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(1072, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Номер материала";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(1075, 188);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 30;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 706);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.refractionBar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.reflectionBar);
            this.Controls.Add(this.colorBar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zBar);
            this.Controls.Add(this.yBar);
            this.Controls.Add(this.xBar);
            this.Controls.Add(this.sizeBar);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "ЛР 3: Трассировка лучей";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.refractionBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reflectionBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar refractionBar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar reflectionBar;
        private System.Windows.Forms.TrackBar colorBar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar zBar;
        private System.Windows.Forms.TrackBar yBar;
        private System.Windows.Forms.TrackBar xBar;
        private System.Windows.Forms.TrackBar sizeBar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBox1;
    }
}

