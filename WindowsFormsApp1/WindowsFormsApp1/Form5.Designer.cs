namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDtNascimento = new System.Windows.Forms.TextBox();
            this.btnCalcIdade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data de Nascimento";
            // 
            // txtDtNascimento
            // 
            this.txtDtNascimento.Location = new System.Drawing.Point(178, 22);
            this.txtDtNascimento.Name = "txtDtNascimento";
            this.txtDtNascimento.Size = new System.Drawing.Size(100, 20);
            this.txtDtNascimento.TabIndex = 1;
            // 
            // btnCalcIdade
            // 
            this.btnCalcIdade.Location = new System.Drawing.Point(187, 77);
            this.btnCalcIdade.Name = "btnCalcIdade";
            this.btnCalcIdade.Size = new System.Drawing.Size(75, 23);
            this.btnCalcIdade.TabIndex = 2;
            this.btnCalcIdade.Text = "Calcular";
            this.btnCalcIdade.UseVisualStyleBackColor = true;
            this.btnCalcIdade.Click += new System.EventHandler(this.BtnCalcIdade_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcIdade);
            this.Controls.Add(this.txtDtNascimento);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDtNascimento;
        private System.Windows.Forms.Button btnCalcIdade;
    }
}