namespace sistemasventas.VISTA.ClienteVistas
{
    partial class ClienteEditarVista
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(562, 85);
            button3.Name = "button3";
            button3.Size = new Size(126, 29);
            button3.TabIndex = 39;
            button3.Text = "SELECCIONAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(417, 320);
            button2.Name = "button2";
            button2.Size = new Size(130, 45);
            button2.TabIndex = 38;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(245, 320);
            button1.Name = "button1";
            button1.Size = new Size(130, 45);
            button1.TabIndex = 37;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(233, 266);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(322, 27);
            textBox4.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(112, 280);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 35;
            label4.Text = "ESTADO";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(233, 206);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(322, 27);
            textBox3.TabIndex = 34;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(233, 146);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(322, 27);
            textBox2.TabIndex = 33;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(233, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(322, 27);
            textBox1.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(112, 218);
            label3.Name = "label3";
            label3.Size = new Size(124, 20);
            label3.TabIndex = 31;
            label3.Text = "CODIGO CLIENTE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 158);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 30;
            label2.Text = "TIPO CLIENTE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 97);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 29;
            label1.Text = "PERSONA";
            // 
            // ClienteEditarVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ClienteEditarVista";
            Text = "ClienteInsertarVista";
            Load += ClienteEditarVista_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}