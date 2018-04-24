namespace WindowsFormsApplication1
{
    partial class frmPrincipal
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
            this.lblValor1 = new System.Windows.Forms.Label();
            this.lblValor2 = new System.Windows.Forms.Label();
            this.lblResultadoSoma = new System.Windows.Forms.Label();
            this.txbValor2 = new System.Windows.Forms.TextBox();
            this.txbValor1 = new System.Windows.Forms.TextBox();
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.lblResultadoSubtracao = new System.Windows.Forms.Label();
            this.lblResultadoMult = new System.Windows.Forms.Label();
            this.lblResultadoDiv = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblValor1
            // 
            this.lblValor1.AutoSize = true;
            this.lblValor1.Location = new System.Drawing.Point(38, 52);
            this.lblValor1.Name = "lblValor1";
            this.lblValor1.Size = new System.Drawing.Size(40, 13);
            this.lblValor1.TabIndex = 0;
            this.lblValor1.Text = "Valor 1";
            // 
            // lblValor2
            // 
            this.lblValor2.AutoSize = true;
            this.lblValor2.Location = new System.Drawing.Point(38, 126);
            this.lblValor2.Name = "lblValor2";
            this.lblValor2.Size = new System.Drawing.Size(40, 13);
            this.lblValor2.TabIndex = 1;
            this.lblValor2.Text = "Valor 2";
            // 
            // lblResultadoSoma
            // 
            this.lblResultadoSoma.AutoSize = true;
            this.lblResultadoSoma.Location = new System.Drawing.Point(253, 31);
            this.lblResultadoSoma.Name = "lblResultadoSoma";
            this.lblResultadoSoma.Size = new System.Drawing.Size(0, 13);
            this.lblResultadoSoma.TabIndex = 2;
            // 
            // txbValor2
            // 
            this.txbValor2.Location = new System.Drawing.Point(41, 142);
            this.txbValor2.Name = "txbValor2";
            this.txbValor2.Size = new System.Drawing.Size(100, 20);
            this.txbValor2.TabIndex = 3;
            // 
            // txbValor1
            // 
            this.txbValor1.Location = new System.Drawing.Point(41, 73);
            this.txbValor1.Name = "txbValor1";
            this.txbValor1.Size = new System.Drawing.Size(100, 20);
            this.txbValor1.TabIndex = 4;
            // 
            // btnSomar
            // 
            this.btnSomar.Location = new System.Drawing.Point(162, 26);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(75, 23);
            this.btnSomar.TabIndex = 5;
            this.btnSomar.Text = "Somar";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.Location = new System.Drawing.Point(162, 86);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(75, 23);
            this.btnSubtrair.TabIndex = 6;
            this.btnSubtrair.Text = "Subtrair";
            this.btnSubtrair.UseVisualStyleBackColor = true;
            this.btnSubtrair.Click += new System.EventHandler(this.btnSubtrair_Click);
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(162, 153);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(75, 23);
            this.btnMult.TabIndex = 7;
            this.btnMult.Text = "Multiplicar";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(162, 217);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(75, 23);
            this.btnDividir.TabIndex = 8;
            this.btnDividir.Text = "Dividir";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // lblResultadoSubtracao
            // 
            this.lblResultadoSubtracao.AutoSize = true;
            this.lblResultadoSubtracao.Location = new System.Drawing.Point(253, 91);
            this.lblResultadoSubtracao.Name = "lblResultadoSubtracao";
            this.lblResultadoSubtracao.Size = new System.Drawing.Size(0, 13);
            this.lblResultadoSubtracao.TabIndex = 9;
            // 
            // lblResultadoMult
            // 
            this.lblResultadoMult.AutoSize = true;
            this.lblResultadoMult.Location = new System.Drawing.Point(253, 158);
            this.lblResultadoMult.Name = "lblResultadoMult";
            this.lblResultadoMult.Size = new System.Drawing.Size(0, 13);
            this.lblResultadoMult.TabIndex = 10;
            // 
            // lblResultadoDiv
            // 
            this.lblResultadoDiv.AutoSize = true;
            this.lblResultadoDiv.Location = new System.Drawing.Point(253, 222);
            this.lblResultadoDiv.Name = "lblResultadoDiv";
            this.lblResultadoDiv.Size = new System.Drawing.Size(0, 13);
            this.lblResultadoDiv.TabIndex = 11;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 262);
            this.Controls.Add(this.lblResultadoDiv);
            this.Controls.Add(this.lblResultadoMult);
            this.Controls.Add(this.lblResultadoSubtracao);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.txbValor1);
            this.Controls.Add(this.txbValor2);
            this.Controls.Add(this.lblResultadoSoma);
            this.Controls.Add(this.lblValor2);
            this.Controls.Add(this.lblValor1);
            this.Name = "frmPrincipal";
            this.Text = "Calculadora Básica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValor1;
        private System.Windows.Forms.Label lblValor2;
        private System.Windows.Forms.Label lblResultadoSoma;
        private System.Windows.Forms.TextBox txbValor2;
        private System.Windows.Forms.TextBox txbValor1;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Label lblResultadoSubtracao;
        private System.Windows.Forms.Label lblResultadoMult;
        private System.Windows.Forms.Label lblResultadoDiv;
    }
}

