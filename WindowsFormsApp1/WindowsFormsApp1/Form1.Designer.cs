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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnChamarForm3 = new System.Windows.Forms.Button();
            this.btnChamarForm4 = new System.Windows.Forms.Button();
            this.btnChamarForm5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(290, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(163, 132);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Testando Variaveis";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(163, 176);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(159, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Chamar Form2";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // btnChamarForm3
            // 
            this.btnChamarForm3.Location = new System.Drawing.Point(163, 219);
            this.btnChamarForm3.Name = "btnChamarForm3";
            this.btnChamarForm3.Size = new System.Drawing.Size(159, 23);
            this.btnChamarForm3.TabIndex = 4;
            this.btnChamarForm3.Text = "Chamar Form3";
            this.btnChamarForm3.UseVisualStyleBackColor = true;
            this.btnChamarForm3.Click += new System.EventHandler(this.BtnChamarForm3_Click);
            // 
            // btnChamarForm4
            // 
            this.btnChamarForm4.Location = new System.Drawing.Point(163, 261);
            this.btnChamarForm4.Name = "btnChamarForm4";
            this.btnChamarForm4.Size = new System.Drawing.Size(159, 23);
            this.btnChamarForm4.TabIndex = 5;
            this.btnChamarForm4.Text = "Chamar Form4";
            this.btnChamarForm4.UseVisualStyleBackColor = true;
            this.btnChamarForm4.Click += new System.EventHandler(this.BtnChamarForm4_Click);
            // 
            // btnChamarForm5
            // 
            this.btnChamarForm5.Location = new System.Drawing.Point(163, 308);
            this.btnChamarForm5.Name = "btnChamarForm5";
            this.btnChamarForm5.Size = new System.Drawing.Size(159, 23);
            this.btnChamarForm5.TabIndex = 6;
            this.btnChamarForm5.Text = "Chamar Form5";
            this.btnChamarForm5.UseVisualStyleBackColor = true;
            this.btnChamarForm5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChamarForm5);
            this.Controls.Add(this.btnChamarForm4);
            this.Controls.Add(this.btnChamarForm3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnChamarForm3;
        private System.Windows.Forms.Button btnChamarForm4;
        private System.Windows.Forms.Button btnChamarForm5;
    }
}

