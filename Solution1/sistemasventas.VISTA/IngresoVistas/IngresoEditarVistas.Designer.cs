namespace sistemasventas.VISTA.IngresoVistas
{
    partial class IngresoEditarVistas
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
            textBox3 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(560, 87);
            button3.Name = "button3";
            button3.Size = new Size(126, 29);
            button3.TabIndex = 72;
            button3.Text = "SELECCIONAR";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(414, 319);
            button2.Name = "button2";
            button2.Size = new Size(130, 45);
            button2.TabIndex = 71;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(242, 319);
            button1.Name = "button1";
            button1.Size = new Size(130, 45);
            button1.TabIndex = 70;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(231, 265);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(322, 27);
            textBox4.TabIndex = 69;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(231, 205);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(322, 27);
            textBox3.TabIndex = 68;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(115, 275);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 67;
            label4.Text = "ESTADO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(115, 215);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 66;
            label3.Text = "TOTAL";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(231, 146);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(322, 27);
            dateTimePicker1.TabIndex = 65;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(231, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(322, 27);
            textBox1.TabIndex = 64;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(115, 157);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 63;
            label2.Text = "FECHA INGRESO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 97);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 62;
            label1.Text = "PROVEEDOR";
            // 
            // IngresoEditarVistas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "IngresoEditarVistas";
            Text = "IngresoEditarVistas";
            Load += IngresoEditarVistas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label4;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
    }
}