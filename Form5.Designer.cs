namespace практика
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            textBox1 = new TextBox();
            deleteButton = new Button();
            updateButton = new Button();
            insertButton = new Button();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Location = new Point(12, 39);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1051, 429);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.AntiqueWhite;
            tabPage1.Font = new Font("Liberation Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tabPage1.ForeColor = SystemColors.ActiveCaptionText;
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1043, 396);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "appointments";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.AntiqueWhite;
            tabPage2.Font = new Font("Liberation Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1043, 396);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "fotograf";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.AntiqueWhite;
            tabPage3.Font = new Font("Liberation Serif", 10.2F);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1043, 396);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "services";
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.AntiqueWhite;
            tabPage4.Font = new Font("Liberation Serif", 10.2F);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1043, 396);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "svobodnoetime";
            // 
            // tabPage5
            // 
            tabPage5.BackColor = Color.AntiqueWhite;
            tabPage5.Font = new Font("Liberation Serif", 10.2F);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(1043, 396);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "users";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(503, 626);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 34);
            textBox1.TabIndex = 1;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(240, 625);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(94, 29);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "button1";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(366, 625);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(94, 29);
            updateButton.TabIndex = 3;
            updateButton.Text = "button2";
            updateButton.UseVisualStyleBackColor = true;
            // 
            // insertButton
            // 
            insertButton.Location = new Point(680, 625);
            insertButton.Name = "insertButton";
            insertButton.Size = new Size(94, 29);
            insertButton.TabIndex = 4;
            insertButton.Text = "button3";
            insertButton.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1094, 611);
            Controls.Add(insertButton);
            Controls.Add(updateButton);
            Controls.Add(deleteButton);
            Controls.Add(textBox1);
            Controls.Add(tabControl1);
            Name = "Form5";
            Text = "Представление таблиц";
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TextBox textBox1;
        private Button deleteButton;
        private Button updateButton;
        private Button insertButton;
    }
}