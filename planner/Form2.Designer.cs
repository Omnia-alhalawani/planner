namespace planner
{
     public class RoundLabel : Label
    {
        Color customBackColor = Color.Gray;
        Color customTextColor = Color.WhiteSmoke;
        public Color CustomBC
        {
            get { return customBackColor; }
            set
            {
                customBackColor = value;
                Invalidate();
            }
        }
        public Color CustomTC
        {
            get { return customTextColor; }
            set
            {
                customTextColor = value;
                Invalidate(); //to redo label when color changes
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            GraphicsPath path = new GraphicsPath();
            int r = 10;

            path.AddArc(0, 0, r, r, 180, 90);
            path.AddArc(this.Width - r, 0, r, r, 270, 90);
            path.AddArc(this.Width - r, this.Height - r, r, r, 0, 90);
            path.AddArc(0, this.Height - r, r, r, 90, 90);
            path.CloseFigure();

            using (SolidBrush brush = new SolidBrush(customBackColor))
            {
                e.Graphics.FillPath(brush, path);
            }

            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;

            using (SolidBrush tb = new SolidBrush(this.ForeColor))
            {
                e.Graphics.DrawString(this.Text, this.Font, tb, ClientRectangle, sf);
            }
            using (SolidBrush textBrush = new SolidBrush(customTextColor))
            {
                e.Graphics.DrawString(this.Text, this.Font, textBrush, ClientRectangle, sf);
            }
        }
    }
    partial class Form2
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
            this.back_btn = new System.Windows.Forms.Button();
            this.label_notes = new System.Windows.Forms.Label();
            this.notes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.week1 = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.week2 = new System.Windows.Forms.GroupBox();
            this.week3 = new System.Windows.Forms.GroupBox();
            this.week4 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.week1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.back_btn);
            this.panel1.Controls.Add(this.label_notes);
            this.panel1.Controls.Add(this.notes);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.week1);
            this.panel1.Controls.Add(this.week2);
            this.panel1.Controls.Add(this.week3);
            this.panel1.Controls.Add(this.week4);
            this.panel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(23, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1342, 709);
            this.panel1.TabIndex = 1;
            // 
            // label_Month
            // 
            this.label_Month.BackColor = System.Drawing.Color.Transparent;
            this.label_Month.CustomBC = System.Drawing.Color.Pink;
            this.label_Month.CustomTC = System.Drawing.Color.White;
            this.label_Month.Font = new System.Drawing.Font("Brush Script MT", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Month.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_Month.Location = new System.Drawing.Point(495, 10);
            this.label_Month.Name = "label_Jan";
            this.label_Month.Size = new System.Drawing.Size(200, 60);
            this.label_Month.TabIndex = 0;
            this.label_Month.Text = "January";
            this.label_Month.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.Black;
            this.back_btn.Location = new System.Drawing.Point(1131, 564);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(188, 54);
            this.back_btn.TabIndex = 7;
            this.back_btn.Text = "back";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // label_notes
            // 
            this.label_notes.Location = new System.Drawing.Point(1195, 58);
            this.label_notes.Name = "label_notes";
            this.label_notes.Size = new System.Drawing.Size(57, 23);
            this.label_notes.TabIndex = 6;
            this.label_notes.Text = "notes";
            // 
            // notes
            // 
            this.notes.Location = new System.Drawing.Point(1120, 94);
            this.notes.Multiline = true;
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(199, 435);
            this.notes.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Mistral", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(540, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 78);
            this.label1.TabIndex = 4;
            this.label1.Text = "jan";
            // 
            // week1
            // 
            this.week1.Controls.Add(this.textBox7);
            this.week1.Controls.Add(this.textBox6);
            this.week1.Controls.Add(this.checkBox7);
            this.week1.Controls.Add(this.checkBox6);
            this.week1.Controls.Add(this.textBox5);
            this.week1.Controls.Add(this.checkBox5);
            this.week1.Controls.Add(this.textBox4);
            this.week1.Controls.Add(this.textBox2);
            this.week1.Controls.Add(this.textBox1);
            this.week1.Controls.Add(this.textBox3);
            this.week1.Controls.Add(this.checkBox4);
            this.week1.Controls.Add(this.checkBox3);
            this.week1.Controls.Add(this.checkBox2);
            this.week1.Controls.Add(this.checkBox1);
            this.week1.Font = new System.Drawing.Font("Constantia", 12F);
            this.week1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.week1.Location = new System.Drawing.Point(15, 85);
            this.week1.Margin = new System.Windows.Forms.Padding(4);
            this.week1.Name = "week1";
            this.week1.Padding = new System.Windows.Forms.Padding(4);
            this.week1.Size = new System.Drawing.Size(253, 498);
            this.week1.TabIndex = 0;
            this.week1.TabStop = false;
            this.week1.Text = "Week 1";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(42, 440);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(183, 32);
            this.textBox7.TabIndex = 13;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(42, 372);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(183, 32);
            this.textBox6.TabIndex = 9;
            // 
            // checkBox7
            // 
            this.checkBox7.Location = new System.Drawing.Point(7, 410);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(239, 88);
            this.checkBox7.TabIndex = 12;
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.Location = new System.Drawing.Point(7, 346);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(239, 88);
            this.checkBox6.TabIndex = 11;
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(42, 308);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(183, 32);
            this.textBox5.TabIndex = 8;
            // 
            // checkBox5
            // 
            this.checkBox5.Location = new System.Drawing.Point(7, 280);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(239, 88);
            this.checkBox5.TabIndex = 10;
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(42, 234);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(183, 32);
            this.textBox4.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(42, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(183, 32);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 32);
            this.textBox1.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(42, 166);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(183, 32);
            this.textBox3.TabIndex = 0;
            // 
            // checkBox4
            // 
            this.checkBox4.Location = new System.Drawing.Point(7, 203);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(239, 94);
            this.checkBox4.TabIndex = 4;
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.Location = new System.Drawing.Point(7, 134);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(239, 94);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.Location = new System.Drawing.Point(7, 70);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(218, 94);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(0, 9);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(239, 88);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // week2
            // 
            this.week2.Font = new System.Drawing.Font("Constantia", 12F);
            this.week2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.week2.Location = new System.Drawing.Point(292, 85);
            this.week2.Margin = new System.Windows.Forms.Padding(4);
            this.week2.Name = "week2";
            this.week2.Padding = new System.Windows.Forms.Padding(4);
            this.week2.Size = new System.Drawing.Size(253, 489);
            this.week2.TabIndex = 1;
            this.week2.TabStop = false;
            this.week2.Text = "Week 2";
            // 
            // week3
            // 
            this.week3.Font = new System.Drawing.Font("Constantia", 12F);
            this.week3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.week3.Location = new System.Drawing.Point(575, 85);
            this.week3.Margin = new System.Windows.Forms.Padding(4);
            this.week3.Name = "week3";
            this.week3.Padding = new System.Windows.Forms.Padding(4);
            this.week3.Size = new System.Drawing.Size(253, 498);
            this.week3.TabIndex = 2;
            this.week3.TabStop = false;
            this.week3.Text = "Week 3";
            // 
            // week4
            // 
            this.week4.Font = new System.Drawing.Font("Constantia", 12F);
            this.week4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.week4.Location = new System.Drawing.Point(860, 85);
            this.week4.Margin = new System.Windows.Forms.Padding(4);
            this.week4.Name = "week4";
            this.week4.Padding = new System.Windows.Forms.Padding(4);
            this.week4.Size = new System.Drawing.Size(253, 498);
            this.week4.TabIndex = 3;
            this.week4.TabStop = false;
            this.week4.Text = "Week 4";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1378, 749);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.week1.ResumeLayout(false);
            this.week1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox week1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox week2;
        private System.Windows.Forms.GroupBox week3;
        private System.Windows.Forms.GroupBox week4;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_notes;
        private System.Windows.Forms.TextBox notes;
        private System.Windows.Forms.Button back_btn;
    }
}
