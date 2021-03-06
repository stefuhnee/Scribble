﻿namespace Scribble
{
    partial class Scribble
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
            this.SizeSelect = new System.Windows.Forms.NumericUpDown();
            this.colorButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Circle = new System.Windows.Forms.RadioButton();
            this.square = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Tools = new System.Windows.Forms.Panel();
            this.FillCheck = new System.Windows.Forms.CheckBox();
            this.cursive = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.SizeSelect)).BeginInit();
            this.Tools.SuspendLayout();
            this.SuspendLayout();
            // 
            // SizeSelect
            // 
            this.SizeSelect.Location = new System.Drawing.Point(70, 58);
            this.SizeSelect.Name = "SizeSelect";
            this.SizeSelect.Size = new System.Drawing.Size(120, 31);
            this.SizeSelect.TabIndex = 1;
            this.SizeSelect.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.SizeSelect.ValueChanged += new System.EventHandler(this.SizeSelect_ValueChanged);
            // 
            // colorButton
            // 
            this.colorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.colorButton.Location = new System.Drawing.Point(297, 18);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(199, 81);
            this.colorButton.TabIndex = 0;
            this.colorButton.Text = "Choose Color";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(45, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Brush Size";
            // 
            // Circle
            // 
            this.Circle.AutoSize = true;
            this.Circle.Location = new System.Drawing.Point(572, 60);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(98, 29);
            this.Circle.TabIndex = 3;
            this.Circle.Text = "Circle";
            this.Circle.UseVisualStyleBackColor = true;
            this.Circle.CheckedChanged += new System.EventHandler(this.Circle_CheckedChanged);
            // 
            // square
            // 
            this.square.AutoSize = true;
            this.square.Location = new System.Drawing.Point(686, 61);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(112, 29);
            this.square.TabIndex = 4;
            this.square.Text = "Square";
            this.square.UseVisualStyleBackColor = true;
            this.square.CheckedChanged += new System.EventHandler(this.square_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(636, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "Brush Shape";
            // 
            // Tools
            // 
            this.Tools.Controls.Add(this.FillCheck);
            this.Tools.Controls.Add(this.cursive);
            this.Tools.Controls.Add(this.label2);
            this.Tools.Controls.Add(this.square);
            this.Tools.Controls.Add(this.Circle);
            this.Tools.Controls.Add(this.label1);
            this.Tools.Controls.Add(this.colorButton);
            this.Tools.Controls.Add(this.SizeSelect);
            this.Tools.Location = new System.Drawing.Point(12, 12);
            this.Tools.Name = "Tools";
            this.Tools.Size = new System.Drawing.Size(1568, 118);
            this.Tools.TabIndex = 3;
            // 
            // FillCheck
            // 
            this.FillCheck.AutoSize = true;
            this.FillCheck.Location = new System.Drawing.Point(1039, 60);
            this.FillCheck.Name = "FillCheck";
            this.FillCheck.Size = new System.Drawing.Size(72, 29);
            this.FillCheck.TabIndex = 8;
            this.FillCheck.Text = "Fill";
            this.FillCheck.UseVisualStyleBackColor = true;
            this.FillCheck.CheckedChanged += new System.EventHandler(this.FillCheck_CheckedChanged);
            // 
            // cursive
            // 
            this.cursive.AutoSize = true;
            this.cursive.Checked = true;
            this.cursive.Location = new System.Drawing.Point(813, 61);
            this.cursive.Name = "cursive";
            this.cursive.Size = new System.Drawing.Size(116, 29);
            this.cursive.TabIndex = 7;
            this.cursive.TabStop = true;
            this.cursive.Text = "Cursive";
            this.cursive.UseVisualStyleBackColor = true;
            this.cursive.CheckedChanged += new System.EventHandler(this.cursive_CheckedChanged);
            // 
            // Scribble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1616, 1436);
            this.Controls.Add(this.Tools);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Scribble";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.SizeSelect)).EndInit();
            this.Tools.ResumeLayout(false);
            this.Tools.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown SizeSelect;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Circle;
        private System.Windows.Forms.RadioButton square;
        private System.Windows.Forms.CheckBox isFilled;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel Tools;
        private System.Windows.Forms.CheckBox FillCheck;
        private System.Windows.Forms.RadioButton cursive;
    }
}

