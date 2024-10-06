namespace практика
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-77, -7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(505, 527);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(95, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(179, 133);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FloralWhite;
            label1.Font = new Font("Liberation Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(144, 187);
            label1.Name = "label1";
            label1.Size = new Size(78, 33);
            label1.TabIndex = 2;
            label1.Text = "Вход";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FloralWhite;
            button1.Font = new Font("Liberation Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(74, 236);
            button1.Name = "button1";
            button1.Size = new Size(220, 43);
            button1.TabIndex = 3;
            button1.Text = "Регистрация ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FloralWhite;
            button2.Font = new Font("Liberation Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(113, 326);
            button2.Name = "button2";
            button2.Size = new Size(148, 47);
            button2.TabIndex = 4;
            button2.Text = "Для клиента";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FloralWhite;
            button3.Font = new Font("Liberation Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button3.Location = new Point(74, 392);
            button3.Name = "button3";
            button3.Size = new Size(220, 50);
            button3.TabIndex = 5;
            button3.Text = "Для администрации ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 522);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Вход";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
