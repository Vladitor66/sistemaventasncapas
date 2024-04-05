namespace sistemasventas.VISTA.ProveeVistas
{
    partial class ProveeInsertarVistas
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
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox3 = new TextBox();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(550, 146);
            button4.Name = "button4";
            button4.Size = new Size(126, 29);
            button4.TabIndex = 69;
            button4.Text = "SELECCIONAR";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(550, 89);
            button3.Name = "button3";
            button3.Size = new Size(126, 29);
            button3.TabIndex = 68;
            button3.Text = "SELECCIONAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(397, 318);
            button2.Name = "button2";
            button2.Size = new Size(130, 45);
            button2.TabIndex = 67;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(225, 318);
            button1.Name = "button1";
            button1.Size = new Size(130, 45);
            button1.TabIndex = 66;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(221, 265);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(322, 27);
            textBox3.TabIndex = 65;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(124, 276);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 64;
            label5.Text = "PRECIO";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(221, 205);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(322, 27);
            dateTimePicker1.TabIndex = 63;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(221, 146);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(322, 27);
            textBox2.TabIndex = 62;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(221, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(322, 27);
            textBox1.TabIndex = 61;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(124, 217);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 60;
            label4.Text = "FECHA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(124, 157);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 59;
            label3.Text = "PROVEEDOR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 98);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 58;
            label2.Text = "PRODUCTO";
            // 
            // ProveeInsertarVistas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "ProveeInsertarVistas";
            Text = "ProveeInsertarVistas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox3;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}