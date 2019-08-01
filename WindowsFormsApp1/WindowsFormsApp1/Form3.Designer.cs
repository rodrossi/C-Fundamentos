namespace WindowsFormsApp1
{
    partial class Form3
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
            this.txtValorInteiro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorDecimal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnFormula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Testando Valores Inteiros";
            // 
            // txtValorInteiro
            // 
            this.txtValorInteiro.Location = new System.Drawing.Point(200, 21);
            this.txtValorInteiro.Name = "txtValorInteiro";
            this.txtValorInteiro.Size = new System.Drawing.Size(219, 20);
            this.txtValorInteiro.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Testando Valores Decimais";
            // 
            // txtValorDecimal
            // 
            this.txtValorDecimal.Location = new System.Drawing.Point(200, 55);
            this.txtValorDecimal.Name = "txtValorDecimal";
            this.txtValorDecimal.Size = new System.Drawing.Size(219, 20);
            this.txtValorDecimal.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Testando Datas";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(200, 87);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(219, 20);
            this.txtData.TabIndex = 5;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(200, 129);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // btnSomar
            // 
            this.btnSomar.Location = new System.Drawing.Point(319, 129);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(100, 23);
            this.btnSomar.TabIndex = 7;
            this.btnSomar.Text = "Somar +";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.BtnSomar_Click);
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.Location = new System.Drawing.Point(200, 169);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(100, 23);
            this.btnSubtrair.TabIndex = 8;
            this.btnSubtrair.Text = "Subtrair -";
            this.btnSubtrair.UseVisualStyleBackColor = true;
            this.btnSubtrair.Click += new System.EventHandler(this.BtnSubtrair_Click);
            // 
            // btnFormula
            // 
            this.btnFormula.Location = new System.Drawing.Point(319, 169);
            this.btnFormula.Name = "btnFormula";
            this.btnFormula.Size = new System.Drawing.Size(100, 23);
            this.btnFormula.TabIndex = 9;
            this.btnFormula.Text = "Formula";
            this.btnFormula.UseVisualStyleBackColor = true;
            this.btnFormula.Click += new System.EventHandler(this.BtnFormula_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFormula);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValorDecimal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValorInteiro);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValorInteiro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValorDecimal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnFormula;
    }
}