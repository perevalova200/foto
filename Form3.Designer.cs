namespace практика
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-139, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(667, 562);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.OldLace;
            button1.Font = new Font("Liberation Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(135, 224);
            button1.Name = "button1";
            button1.Size = new Size(129, 40);
            button1.TabIndex = 1;
            button1.Text = "Услуги";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.OldLace;
            button2.Font = new Font("Liberation Serif", 13.8F);
            button2.Location = new Point(51, 282);
            button2.Name = "button2";
            button2.Size = new Size(288, 37);
            button2.TabIndex = 2;
            button2.Text = "Свободное время и дата";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(103, 68);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(176, 125);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.OldLace;
            button3.Font = new Font("Liberation Serif", 13.8F);
            button3.Location = new Point(120, 344);
            button3.Name = "button3";
            button3.Size = new Size(159, 34);
            button3.TabIndex = 4;
            button3.Text = "Фотографы";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.OldLace;
            button4.Font = new Font("Liberation Serif", 13.8F);
            button4.Location = new Point(145, 405);
            button4.Name = "button4";
            button4.Size = new Size(119, 40);
            button4.TabIndex = 5;
            button4.Text = "Запись";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 542);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(pictureBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Form3";
            Text = "Для клиента";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox2;
        private Button button3;
        private Button button4;
    }
}