namespace Ejercicio3_1
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
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            checkBox1 = new CheckBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(676, 9);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 0;
            label1.Text = "Ejercicio3.1";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(33, 63);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(742, 124);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(35, 221);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(109, 29);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Urgente?";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 26);
            label2.Name = "label2";
            label2.Size = new Size(53, 25);
            label2.TabIndex = 3;
            label2.Text = "Texto";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(97, 276);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 282);
            label3.Name = "label3";
            label3.Size = new Size(57, 25);
            label3.TabIndex = 5;
            label3.Text = "Coste";
            // 
            // button1
            // 
            button1.Location = new Point(652, 273);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 6;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(checkBox1);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox richTextBox1;
        private CheckBox checkBox1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Button button1;
    }
}
