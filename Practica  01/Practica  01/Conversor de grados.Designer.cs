namespace Practica__01
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtEntrada = new System.Windows.Forms.TextBox();
            this.BtnC_K = new System.Windows.Forms.Button();
            this.BtnF_K = new System.Windows.Forms.Button();
            this.BtnF_C = new System.Windows.Forms.Button();
            this.BtnC_F = new System.Windows.Forms.Button();
            this.LbResultado = new System.Windows.Forms.Label();
            this.BtnK_C = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtEntrada
            // 
            this.TxtEntrada.Location = new System.Drawing.Point(316, 55);
            this.TxtEntrada.Name = "TxtEntrada";
            this.TxtEntrada.Size = new System.Drawing.Size(168, 22);
            this.TxtEntrada.TabIndex = 0;
            this.TxtEntrada.TextChanged += new System.EventHandler(this.TxtEntrada_TextChanged);
            // 
            // BtnC_K
            // 
            this.BtnC_K.Location = new System.Drawing.Point(62, 83);
            this.BtnC_K.Name = "BtnC_K";
            this.BtnC_K.Size = new System.Drawing.Size(186, 52);
            this.BtnC_K.TabIndex = 1;
            this.BtnC_K.Text = "°C to °K";
            this.BtnC_K.UseVisualStyleBackColor = true;
            this.BtnC_K.Click += new System.EventHandler(this.BtnC_K_Click);
            // 
            // BtnF_K
            // 
            this.BtnF_K.Location = new System.Drawing.Point(62, 212);
            this.BtnF_K.Name = "BtnF_K";
            this.BtnF_K.Size = new System.Drawing.Size(186, 52);
            this.BtnF_K.TabIndex = 2;
            this.BtnF_K.Text = "°F to °K";
            this.BtnF_K.UseVisualStyleBackColor = true;
            this.BtnF_K.Click += new System.EventHandler(this.BtnF_K_Click);
            // 
            // BtnF_C
            // 
            this.BtnF_C.Location = new System.Drawing.Point(62, 148);
            this.BtnF_C.Name = "BtnF_C";
            this.BtnF_C.Size = new System.Drawing.Size(186, 52);
            this.BtnF_C.TabIndex = 3;
            this.BtnF_C.Text = "°F to °C";
            this.BtnF_C.UseVisualStyleBackColor = true;
            this.BtnF_C.Click += new System.EventHandler(this.BtnF_C_Click);
            // 
            // BtnC_F
            // 
            this.BtnC_F.Location = new System.Drawing.Point(62, 19);
            this.BtnC_F.Name = "BtnC_F";
            this.BtnC_F.Size = new System.Drawing.Size(186, 52);
            this.BtnC_F.TabIndex = 4;
            this.BtnC_F.Text = "°C to °F";
            this.BtnC_F.UseVisualStyleBackColor = true;
            this.BtnC_F.Click += new System.EventHandler(this.BtnC_F_Click);
            // 
            // LbResultado
            // 
            this.LbResultado.AutoSize = true;
            this.LbResultado.Location = new System.Drawing.Point(322, 140);
            this.LbResultado.Name = "LbResultado";
            this.LbResultado.Size = new System.Drawing.Size(69, 16);
            this.LbResultado.TabIndex = 5;
            this.LbResultado.Text = "Resultado";
            this.LbResultado.Click += new System.EventHandler(this.LbResultado_Click);
            // 
            // BtnK_C
            // 
            this.BtnK_C.Location = new System.Drawing.Point(62, 287);
            this.BtnK_C.Name = "BtnK_C";
            this.BtnK_C.Size = new System.Drawing.Size(186, 52);
            this.BtnK_C.TabIndex = 6;
            this.BtnK_C.Text = "°K to °C";
            this.BtnK_C.UseVisualStyleBackColor = true;
            this.BtnK_C.Click += new System.EventHandler(this.BtnK_C_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(298, 234);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(186, 52);
            this.BtnClear.TabIndex = 7;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ingresa la cantidad a convertir";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 351);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnK_C);
            this.Controls.Add(this.LbResultado);
            this.Controls.Add(this.BtnC_F);
            this.Controls.Add(this.BtnF_C);
            this.Controls.Add(this.BtnF_K);
            this.Controls.Add(this.BtnC_K);
            this.Controls.Add(this.TxtEntrada);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtEntrada;
        private System.Windows.Forms.Button BtnC_K;
        private System.Windows.Forms.Button BtnF_K;
        private System.Windows.Forms.Button BtnF_C;
        private System.Windows.Forms.Button BtnC_F;
        private System.Windows.Forms.Label LbResultado;
        private System.Windows.Forms.Button BtnK_C;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Label label1;
    }
}

