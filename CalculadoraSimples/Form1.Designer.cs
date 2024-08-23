namespace CalculadoraSimples
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
            this.txt_num1 = new System.Windows.Forms.TextBox();
            this.txt_num2 = new System.Windows.Forms.TextBox();
            this.btn_soma = new System.Windows.Forms.Button();
            this.btn_subtracao = new System.Windows.Forms.Button();
            this.btn_multiplicacao = new System.Windows.Forms.Button();
            this.btn_divisao = new System.Windows.Forms.Button();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_num1
            // 
            this.txt_num1.Location = new System.Drawing.Point(12, 12);
            this.txt_num1.Name = "txt_num1";
            this.txt_num1.Size = new System.Drawing.Size(124, 20);
            this.txt_num1.TabIndex = 0;
            // 
            // txt_num2
            // 
            this.txt_num2.Location = new System.Drawing.Point(12, 38);
            this.txt_num2.Name = "txt_num2";
            this.txt_num2.Size = new System.Drawing.Size(124, 20);
            this.txt_num2.TabIndex = 1;
            // 
            // btn_soma
            // 
            this.btn_soma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_soma.Location = new System.Drawing.Point(12, 77);
            this.btn_soma.Name = "btn_soma";
            this.btn_soma.Size = new System.Drawing.Size(56, 46);
            this.btn_soma.TabIndex = 2;
            this.btn_soma.Text = "+";
            this.btn_soma.UseVisualStyleBackColor = true;
            this.btn_soma.Click += new System.EventHandler(this.operacao_click);
            // 
            // btn_subtracao
            // 
            this.btn_subtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_subtracao.Location = new System.Drawing.Point(80, 77);
            this.btn_subtracao.Name = "btn_subtracao";
            this.btn_subtracao.Size = new System.Drawing.Size(56, 46);
            this.btn_subtracao.TabIndex = 3;
            this.btn_subtracao.Text = "-";
            this.btn_subtracao.UseVisualStyleBackColor = true;
            this.btn_subtracao.Click += new System.EventHandler(this.operacao_click);
            // 
            // btn_multiplicacao
            // 
            this.btn_multiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_multiplicacao.Location = new System.Drawing.Point(12, 129);
            this.btn_multiplicacao.Name = "btn_multiplicacao";
            this.btn_multiplicacao.Size = new System.Drawing.Size(56, 46);
            this.btn_multiplicacao.TabIndex = 4;
            this.btn_multiplicacao.Text = "x";
            this.btn_multiplicacao.UseVisualStyleBackColor = true;
            this.btn_multiplicacao.Click += new System.EventHandler(this.operacao_click);
            // 
            // btn_divisao
            // 
            this.btn_divisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_divisao.Location = new System.Drawing.Point(80, 129);
            this.btn_divisao.Name = "btn_divisao";
            this.btn_divisao.Size = new System.Drawing.Size(56, 46);
            this.btn_divisao.TabIndex = 5;
            this.btn_divisao.Text = "%";
            this.btn_divisao.UseVisualStyleBackColor = true;
            this.btn_divisao.Click += new System.EventHandler(this.operacao_click);
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultado.Location = new System.Drawing.Point(154, 12);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(139, 163);
            this.lbl_resultado.TabIndex = 6;
            this.lbl_resultado.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 186);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.btn_divisao);
            this.Controls.Add(this.btn_multiplicacao);
            this.Controls.Add(this.btn_subtracao);
            this.Controls.Add(this.btn_soma);
            this.Controls.Add(this.txt_num2);
            this.Controls.Add(this.txt_num1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_num1;
        private System.Windows.Forms.TextBox txt_num2;
        private System.Windows.Forms.Button btn_soma;
        private System.Windows.Forms.Button btn_subtracao;
        private System.Windows.Forms.Button btn_multiplicacao;
        private System.Windows.Forms.Button btn_divisao;
        private System.Windows.Forms.Label lbl_resultado;
    }
}

