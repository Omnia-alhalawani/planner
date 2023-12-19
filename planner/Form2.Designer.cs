using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
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
            int r = 40;

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
            this.week1 = new System.Windows.Forms.GroupBox();
            this.listBox6 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.week2 = new System.Windows.Forms.GroupBox();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.week3 = new System.Windows.Forms.GroupBox();
            this.listBox7 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.week4 = new System.Windows.Forms.GroupBox();
            this.listBox8 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.week1.SuspendLayout();
            this.week2.SuspendLayout();
            this.week3.SuspendLayout();
            this.week4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.back_btn);
            this.panel1.Controls.Add(this.label_notes);
            this.panel1.Controls.Add(this.notes);
            this.panel1.Controls.Add(this.week1);
            this.panel1.Controls.Add(this.week2);
            this.panel1.Controls.Add(this.week3);
            this.panel1.Controls.Add(this.week4);
            this.panel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(26, 34);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1509, 885);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.LightSlateGray;
            this.back_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back_btn.Location = new System.Drawing.Point(1245, 829);
            this.back_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(212, 68);
            this.back_btn.TabIndex = 7;
            this.back_btn.Text = "back";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // label_notes
            // 
            this.label_notes.Location = new System.Drawing.Point(1272, 106);
            this.label_notes.Name = "label_notes";
            this.label_notes.Size = new System.Drawing.Size(64, 29);
            this.label_notes.TabIndex = 6;
            this.label_notes.Text = "notes";
            // 
            // notes
            // 
            this.notes.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.notes.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.notes.Location = new System.Drawing.Point(1176, 146);
            this.notes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.notes.Multiline = true;
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(223, 608);
            this.notes.TabIndex = 5;
            this.notes.TextChanged += new System.EventHandler(this.notes_TextChanged);
            // 
            // week1
            // 
            this.week1.Controls.Add(this.listBox6);
            this.week1.Controls.Add(this.label3);
            this.week1.Controls.Add(this.listBox1);
            this.week1.Controls.Add(this.textBox1);
            this.week1.Controls.Add(this.button1);
            this.week1.Font = new System.Drawing.Font("Constantia", 12F);
            this.week1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.week1.Location = new System.Drawing.Point(79, 106);
            this.week1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.week1.Name = "week1";
            this.week1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.week1.Size = new System.Drawing.Size(246, 664);
            this.week1.TabIndex = 0;
            this.week1.TabStop = false;
            this.week1.Text = "Week 1";
            // 
            // listBox6
            // 
            this.listBox6.FormattingEnabled = true;
            this.listBox6.ItemHeight = 29;
            this.listBox6.Location = new System.Drawing.Point(22, 385);
            this.listBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox6.Name = "listBox6";
            this.listBox6.Size = new System.Drawing.Size(204, 207);
            this.listBox6.TabIndex = 6;
            this.listBox6.SelectedIndexChanged += new System.EventHandler(this.listBox6_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "ended task";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Location = new System.Drawing.Point(22, 118);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(187, 178);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.Location = new System.Drawing.Point(22, 40);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 37);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button1.ForeColor = System.Drawing.Color.RosyBrown;
            this.button1.Location = new System.Drawing.Point(174, 40);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // week2
            // 
            this.week2.Controls.Add(this.listBox5);
            this.week2.Controls.Add(this.label2);
            this.week2.Controls.Add(this.listBox2);
            this.week2.Controls.Add(this.textBox2);
            this.week2.Controls.Add(this.button2);
            this.week2.Font = new System.Drawing.Font("Constantia", 12F);
            this.week2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.week2.Location = new System.Drawing.Point(348, 106);
            this.week2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.week2.Name = "week2";
            this.week2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.week2.Size = new System.Drawing.Size(241, 664);
            this.week2.TabIndex = 1;
            this.week2.TabStop = false;
            this.week2.Text = "Week 2";
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.ItemHeight = 29;
            this.listBox5.Location = new System.Drawing.Point(21, 385);
            this.listBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(193, 207);
            this.listBox5.TabIndex = 5;
            this.listBox5.SelectedIndexChanged += new System.EventHandler(this.listBox5_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "ended task";
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 29;
            this.listBox2.Location = new System.Drawing.Point(21, 118);
            this.listBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(193, 178);
            this.listBox2.TabIndex = 1;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox2.Location = new System.Drawing.Point(21, 45);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(138, 37);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button2.ForeColor = System.Drawing.Color.RosyBrown;
            this.button2.Location = new System.Drawing.Point(166, 44);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = "add";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // week3
            // 
            this.week3.Controls.Add(this.listBox7);
            this.week3.Controls.Add(this.label4);
            this.week3.Controls.Add(this.listBox3);
            this.week3.Controls.Add(this.textBox3);
            this.week3.Controls.Add(this.button3);
            this.week3.Font = new System.Drawing.Font("Constantia", 12F);
            this.week3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.week3.Location = new System.Drawing.Point(608, 106);
            this.week3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.week3.Name = "week3";
            this.week3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.week3.Size = new System.Drawing.Size(249, 664);
            this.week3.TabIndex = 2;
            this.week3.TabStop = false;
            this.week3.Text = "Week 3";
            // 
            // listBox7
            // 
            this.listBox7.FormattingEnabled = true;
            this.listBox7.ItemHeight = 29;
            this.listBox7.Location = new System.Drawing.Point(21, 385);
            this.listBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox7.Name = "listBox7";
            this.listBox7.Size = new System.Drawing.Size(205, 207);
            this.listBox7.TabIndex = 7;
            this.listBox7.SelectedIndexChanged += new System.EventHandler(this.listBox7_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "ended task";
            // 
            // listBox3
            // 
            this.listBox3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listBox3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 29;
            this.listBox3.Location = new System.Drawing.Point(21, 124);
            this.listBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(205, 178);
            this.listBox3.TabIndex = 1;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox3.Location = new System.Drawing.Point(21, 44);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(141, 37);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button3.ForeColor = System.Drawing.Color.RosyBrown;
            this.button3.Location = new System.Drawing.Point(173, 44);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 39);
            this.button3.TabIndex = 3;
            this.button3.Text = "add";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // week4
            // 
            this.week4.Controls.Add(this.listBox8);
            this.week4.Controls.Add(this.label5);
            this.week4.Controls.Add(this.listBox4);
            this.week4.Controls.Add(this.textBox4);
            this.week4.Controls.Add(this.button4);
            this.week4.Font = new System.Drawing.Font("Constantia", 12F);
            this.week4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.week4.Location = new System.Drawing.Point(892, 106);
            this.week4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.week4.Name = "week4";
            this.week4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.week4.Size = new System.Drawing.Size(255, 664);
            this.week4.TabIndex = 3;
            this.week4.TabStop = false;
            this.week4.Text = "Week 4";
            this.week4.Enter += new System.EventHandler(this.week4_Enter);
            // 
            // listBox8
            // 
            this.listBox8.FormattingEnabled = true;
            this.listBox8.ItemHeight = 29;
            this.listBox8.Location = new System.Drawing.Point(21, 385);
            this.listBox8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox8.Name = "listBox8";
            this.listBox8.Size = new System.Drawing.Size(213, 207);
            this.listBox8.TabIndex = 6;
            this.listBox8.SelectedIndexChanged += new System.EventHandler(this.listBox8_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "ended task";
            // 
            // listBox4
            // 
            this.listBox4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listBox4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 29;
            this.listBox4.Location = new System.Drawing.Point(21, 124);
            this.listBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(213, 178);
            this.listBox4.TabIndex = 1;
            this.listBox4.SelectedIndexChanged += new System.EventHandler(this.listBox4_SelectedIndexChanged);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox4.Location = new System.Drawing.Point(21, 44);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(145, 37);
            this.textBox4.TabIndex = 2;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button4.ForeColor = System.Drawing.Color.RosyBrown;
            this.button4.Location = new System.Drawing.Point(173, 46);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(68, 39);
            this.button4.TabIndex = 3;
            this.button4.Text = "add";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::planner.Properties.Resources.image_prject;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1550, 936);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.week1.ResumeLayout(false);
            this.week1.PerformLayout();
            this.week2.ResumeLayout(false);
            this.week2.PerformLayout();
            this.week3.ResumeLayout(false);
            this.week3.PerformLayout();
            this.week4.ResumeLayout(false);
            this.week4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox week1;
        private System.Windows.Forms.GroupBox week2;
        private System.Windows.Forms.GroupBox week3;
        private System.Windows.Forms.GroupBox week4;
        private System.Windows.Forms.Label label_notes;
        private System.Windows.Forms.TextBox notes;
        private System.Windows.Forms.Button back_btn;
        private ListBox listBox1;
        private TextBox textBox1;
        private Button button1;
        private ListBox listBox2;
        private TextBox textBox2;
        private Button button2;
        private ListBox listBox3;
        private TextBox textBox3;
        private Button button3;
        private ListBox listBox4;
        private TextBox textBox4;
        private Button button4;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private ListBox listBox6;
        private ListBox listBox5;
        private ListBox listBox7;
        private ListBox listBox8;
    }
}
