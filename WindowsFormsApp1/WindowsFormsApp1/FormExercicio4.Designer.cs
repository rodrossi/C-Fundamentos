namespace WindowsFormsApp1
{
    partial class FormExercicio4
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
            this.btnCalcQtdLitros = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTempoGasto = new System.Windows.Forms.TextBox();
            this.txtVelocidadeMedia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalcQtdLitros
            // 
            this.btnCalcQtdLitros.Location = new System.Drawing.Point(23, 86);
            this.btnCalcQtdLitros.Name = "btnCalcQtdLitros";
            this.btnCalcQtdLitros.Size = new System.Drawing.Size(112, 23);
            this.btnCalcQtdLitros.TabIndex = 0;
            this.btnCalcQtdLitros.Text = "Calculo Qtd Litros";
            this.btnCalcQtdLitros.UseVisualStyleBackColor = true;
            this.btnCalcQtdLitros.Click += new System.EventHandler(this.BtnCalcQtdLitros_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tempo Gasto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Velocidade Média";
            // 
            // txtTempoGasto
            // 
            this.txtTempoGasto.Location = new System.Drawing.Point(178, 13);
            this.txtTempoGasto.Name = "txtTempoGasto";
            this.txtTempoGasto.Size = new System.Drawing.Size(100, 20);
            this.txtTempoGasto.TabIndex = 3;
            // 
            // txtVelocidadeMedia
            // 
            this.txtVelocidadeMedia.Location = new System.Drawing.Point(178, 43);
            this.txtVelocidadeMedia.Name = "txtVelocidadeMedia";
            this.txtVelocidadeMedia.Size = new System.Drawing.Size(100, 20);
            this.txtVelocidadeMedia.TabIndex = 4;
            // 
            // FormExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtVelocidadeMedia);
            this.Controls.Add(this.txtTempoGasto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcQtdLitros);
            this.Name = "FormExercicio4";
            this.Text = "FormExercicio4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcQtdLitros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTempoGasto;
        private System.Windows.Forms.TextBox txtVelocidadeMedia;
    }
}