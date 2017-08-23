namespace WindowsFormsApp1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.elefantes = new System.Windows.Forms.ComboBox();
            this.chimpances = new System.Windows.Forms.ComboBox();
            this.jirafas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "elija un animal";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ingrese la edad del animal";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // elefantes
            // 
            this.elefantes.FormattingEnabled = true;
            this.elefantes.Location = new System.Drawing.Point(75, 91);
            this.elefantes.Name = "elefantes";
            this.elefantes.Size = new System.Drawing.Size(121, 21);
            this.elefantes.TabIndex = 6;
            this.elefantes.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // chimpances
            // 
            this.chimpances.FormattingEnabled = true;
            this.chimpances.Location = new System.Drawing.Point(75, 148);
            this.chimpances.Name = "chimpances";
            this.chimpances.Size = new System.Drawing.Size(121, 21);
            this.chimpances.TabIndex = 7;
            this.chimpances.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // jirafas
            // 
            this.jirafas.FormattingEnabled = true;
            this.jirafas.Location = new System.Drawing.Point(75, 194);
            this.jirafas.Name = "jirafas";
            this.jirafas.Size = new System.Drawing.Size(121, 21);
            this.jirafas.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.jirafas);
            this.Controls.Add(this.chimpances);
            this.Controls.Add(this.elefantes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox elefantes;
        private System.Windows.Forms.ComboBox chimpances;
        private System.Windows.Forms.ComboBox jirafas;
    }
}

