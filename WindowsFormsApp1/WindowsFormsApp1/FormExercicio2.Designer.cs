namespace WindowsFormsApp1
{
    partial class FormExercicio2
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
            this.btnCalculo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrimNum = new System.Windows.Forms.TextBox();
            this.txtSegNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalculo
            // 
            this.btnCalculo.Location = new System.Drawing.Point(234, 135);
            this.btnCalculo.Name = "btnCalculo";
            this.btnCalculo.Size = new System.Drawing.Size(75, 23);
            this.btnCalculo.TabIndex = 0;
            this.btnCalculo.Text = "Calcular";
            this.btnCalculo.UseVisualStyleBackColor = true;
            this.btnCalculo.Click += new System.EventHandler(this.BtnCalculo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite o Primeiro Numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Digite o Segundo Numero";
            // 
            // txtPrimNum
            // 
            this.txtPrimNum.Location = new System.Drawing.Point(234, 36);
            this.txtPrimNum.Name = "txtPrimNum";
            this.txtPrimNum.Size = new System.Drawing.Size(100, 20);
            this.txtPrimNum.TabIndex = 3;
            this.txtPrimNum.TextChanged += new System.EventHandler(this.TxtPrimNum_TextChanged);
            // 
            // txtSegNum
            // 
            this.txtSegNum.Location = new System.Drawing.Point(234, 90);
            this.txtSegNum.Name = "txtSegNum";
            this.txtSegNum.Size = new System.Drawing.Size(100, 20);
            this.txtSegNum.TabIndex = 4;
            // 
            // FormExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 354);
            this.Controls.Add(this.txtSegNum);
            this.Controls.Add(this.txtPrimNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculo);
            this.Name = "FormExercicio2";
            this.Text = "FormExercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrimNum;
        private System.Windows.Forms.TextBox txtSegNum;
    }
}