
namespace plants
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.starttimeBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timelapseBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openbtn = new System.Windows.Forms.Button();
            this.startbtn = new System.Windows.Forms.Button();
            this.timelapsetimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.endtimeBox = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.endtimeBox);
            this.groupBox1.Controls.Add(this.starttimeBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.timelapseBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 236);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // starttimeBox
            // 
            this.starttimeBox.Location = new System.Drawing.Point(169, 32);
            this.starttimeBox.Mask = "00:00";
            this.starttimeBox.Name = "starttimeBox";
            this.starttimeBox.Size = new System.Drawing.Size(69, 31);
            this.starttimeBox.TabIndex = 6;
            this.starttimeBox.Text = "0830";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Частота (Минуты)";
            // 
            // timelapseBox
            // 
            this.timelapseBox.Location = new System.Drawing.Point(169, 103);
            this.timelapseBox.Name = "timelapseBox";
            this.timelapseBox.Size = new System.Drawing.Size(69, 31);
            this.timelapseBox.TabIndex = 6;
            this.timelapseBox.Text = "15";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Конец съемки";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Начало съемки";
            // 
            // openbtn
            // 
            this.openbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.openbtn.Location = new System.Drawing.Point(161, 27);
            this.openbtn.Name = "openbtn";
            this.openbtn.Size = new System.Drawing.Size(150, 50);
            this.openbtn.TabIndex = 5;
            this.openbtn.Text = "Открыть папку";
            this.openbtn.UseVisualStyleBackColor = true;
            this.openbtn.Click += new System.EventHandler(this.openbtn_Click);
            // 
            // startbtn
            // 
            this.startbtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.startbtn.Location = new System.Drawing.Point(3, 27);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(150, 50);
            this.startbtn.TabIndex = 0;
            this.startbtn.Text = "Старт";
            this.startbtn.UseVisualStyleBackColor = true;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // timelapsetimer
            // 
            this.timelapsetimer.Interval = 100000;
            this.timelapsetimer.Tick += new System.EventHandler(this.timelapsetimer_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.startbtn);
            this.groupBox2.Controls.Add(this.openbtn);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 80);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // endtimeBox
            // 
            this.endtimeBox.Location = new System.Drawing.Point(169, 67);
            this.endtimeBox.Mask = "00:00";
            this.endtimeBox.Name = "endtimeBox";
            this.endtimeBox.Size = new System.Drawing.Size(69, 31);
            this.endtimeBox.TabIndex = 8;
            this.endtimeBox.Text = "1930";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(314, 240);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timelapsetimer;
        private System.Windows.Forms.Button openbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox timelapseBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox starttimeBox;
        private System.Windows.Forms.MaskedTextBox endtimeBox;
    }
}

