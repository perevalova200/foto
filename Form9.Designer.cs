namespace практика
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            textBoxFio = new TextBox();
            textBoxDate = new TextBox();
            textBoxTime = new TextBox();
            comboBoxServices = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-277, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(975, 600);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Linen;
            label1.Font = new Font("Liberation Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(159, 66);
            label1.Name = "label1";
            label1.Size = new Size(102, 33);
            label1.TabIndex = 1;
            label1.Text = "Запись";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Linen;
            label2.Font = new Font("Liberation Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(54, 118);
            label2.Name = "label2";
            label2.Size = new Size(54, 22);
            label2.TabIndex = 2;
            label2.Text = "ФИО";
            // 
            // textBoxFio
            // 
            textBoxFio.BackColor = Color.Linen;
            textBoxFio.Font = new Font("Liberation Serif", 14F);
            textBoxFio.Location = new Point(54, 143);
            textBoxFio.Name = "textBoxFio";
            textBoxFio.Size = new Size(231, 34);
            textBoxFio.TabIndex = 3;
            // 
            // textBoxDate
            // 
            textBoxDate.BackColor = Color.Linen;
            textBoxDate.Font = new Font("Liberation Serif", 14F);
            textBoxDate.Location = new Point(58, 215);
            textBoxDate.Name = "textBoxDate";
            textBoxDate.Size = new Size(231, 34);
            textBoxDate.TabIndex = 4;
            // 
            // textBoxTime
            // 
            textBoxTime.BackColor = Color.Linen;
            textBoxTime.Font = new Font("Liberation Serif", 14F);
            textBoxTime.Location = new Point(58, 286);
            textBoxTime.Name = "textBoxTime";
            textBoxTime.Size = new Size(231, 34);
            textBoxTime.TabIndex = 5;
            // 
            // comboBoxServices
            // 
            comboBoxServices.BackColor = Color.Linen;
            comboBoxServices.Font = new Font("Liberation Serif", 14F);
            comboBoxServices.FormattingEnabled = true;
            comboBoxServices.Location = new Point(54, 370);
            comboBoxServices.Name = "comboBoxServices";
            comboBoxServices.Size = new Size(252, 33);
            comboBoxServices.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Linen;
            label3.Font = new Font("Liberation Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(58, 190);
            label3.Name = "label3";
            label3.Size = new Size(50, 22);
            label3.TabIndex = 7;
            label3.Text = "Дата";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Linen;
            label4.Font = new Font("Liberation Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(58, 261);
            label4.Name = "label4";
            label4.Size = new Size(64, 22);
            label4.TabIndex = 8;
            label4.Text = "Время";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Linen;
            label5.Font = new Font("Liberation Serif", 12F);
            label5.Location = new Point(54, 333);
            label5.Name = "label5";
            label5.Size = new Size(223, 22);
            label5.TabIndex = 9;
            label5.Text = "Предоставляемые услуги";
            // 
            // button1
            // 
            button1.BackColor = Color.Snow;
            button1.Font = new Font("Liberation Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(68, 422);
            button1.Name = "button1";
            button1.Size = new Size(143, 44);
            button1.TabIndex = 10;
            button1.Text = "Записаться";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Snow;
            button2.Font = new Font("Liberation Serif", 12F);
            button2.Location = new Point(221, 470);
            button2.Name = "button2";
            button2.Size = new Size(126, 38);
            button2.TabIndex = 11;
            button2.Text = "Назад";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 594);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBoxServices);
            Controls.Add(textBoxTime);
            Controls.Add(textBoxDate);
            Controls.Add(textBoxFio);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form9";
            Text = "Запись";
            Load += Form9_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox textBoxFio;
        private TextBox textBoxDate;
        private TextBox textBoxTime;
        private ComboBox comboBoxServices;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button button2;
    }
}