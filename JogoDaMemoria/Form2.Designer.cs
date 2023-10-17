namespace JogoDaMemoria
{
    partial class Form2
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
            label1 = new Label();
            Facil = new Button();
            Medio = new Button();
            Dificil = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(123, 66);
            label1.Name = "label1";
            label1.Size = new Size(224, 22);
            label1.TabIndex = 0;
            label1.Text = "Selecione a dificuldade";
            label1.Click += label1_Click;
            // 
            // Facil
            // 
            Facil.Location = new Point(189, 109);
            Facil.Name = "Facil";
            Facil.Size = new Size(70, 23);
            Facil.TabIndex = 1;
            Facil.Text = "Fácil";
            Facil.UseVisualStyleBackColor = true;
            Facil.Click += Facil_Click;
            // 
            // Medio
            // 
            Medio.Location = new Point(189, 148);
            Medio.Name = "Medio";
            Medio.Size = new Size(70, 23);
            Medio.TabIndex = 2;
            Medio.Text = "Normal";
            Medio.UseVisualStyleBackColor = true;
            // 
            // Dificil
            // 
            Dificil.Location = new Point(189, 188);
            Dificil.Name = "Dificil";
            Dificil.Size = new Size(70, 23);
            Dificil.TabIndex = 3;
            Dificil.Text = "Dificil";
            Dificil.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 259);
            Controls.Add(Dificil);
            Controls.Add(Medio);
            Controls.Add(Facil);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Jogo da Memoria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Facil;
        private Button Medio;
        private Button Dificil;
    }
}