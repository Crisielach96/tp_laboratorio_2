namespace MiCalculadora
{
    partial class LaCalculadora
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
            this.btnOperar = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnAdec = new System.Windows.Forms.Button();
            this.btnABin = new System.Windows.Forms.Button();
            this.txtIn = new System.Windows.Forms.TextBox();
            this.cmbSelec = new System.Windows.Forms.ComboBox();
            this.txtIn2 = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOperar
            // 
            this.btnOperar.AccessibleName = "btnOperar";
            this.btnOperar.Location = new System.Drawing.Point(12, 79);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(110, 49);
            this.btnOperar.TabIndex = 0;
            this.btnOperar.Text = "Operar\r\n";
            this.btnOperar.UseVisualStyleBackColor = true;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(128, 79);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 49);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(244, 79);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(110, 49);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // btnAdec
            // 
            this.btnAdec.Location = new System.Drawing.Point(188, 134);
            this.btnAdec.Name = "btnAdec";
            this.btnAdec.Size = new System.Drawing.Size(166, 43);
            this.btnAdec.TabIndex = 3;
            this.btnAdec.Text = "Convertir a Decimal";
            this.btnAdec.UseVisualStyleBackColor = true;
            this.btnAdec.Click += new System.EventHandler(this.btnAdec_Click);
            // 
            // btnABin
            // 
            this.btnABin.Location = new System.Drawing.Point(12, 134);
            this.btnABin.Name = "btnABin";
            this.btnABin.Size = new System.Drawing.Size(170, 43);
            this.btnABin.TabIndex = 4;
            this.btnABin.Text = "Convertir a Binario";
            this.btnABin.UseVisualStyleBackColor = true;
            this.btnABin.Click += new System.EventHandler(this.btnABin_Click);
            // 
            // txtIn
            // 
            this.txtIn.Location = new System.Drawing.Point(12, 53);
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(110, 20);
            this.txtIn.TabIndex = 5;
            this.txtIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbSelec
            // 
            this.cmbSelec.Items.AddRange(new object[] {
            "",
            "+",
            "-",
            "*",
            "/"});
            this.cmbSelec.Location = new System.Drawing.Point(150, 52);
            this.cmbSelec.Name = "cmbSelec";
            this.cmbSelec.Size = new System.Drawing.Size(70, 21);
            this.cmbSelec.TabIndex = 8;
            // 
            // txtIn2
            // 
            this.txtIn2.Location = new System.Drawing.Point(245, 52);
            this.txtIn2.Name = "txtIn2";
            this.txtIn2.Size = new System.Drawing.Size(110, 20);
            this.txtIn2.TabIndex = 7;
            this.txtIn2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(128, 9);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(227, 25);
            this.lblResult.TabIndex = 0;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LaCalculadora
            // 
            this.AccessibleDescription = "";
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(367, 189);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtIn2);
            this.Controls.Add(this.cmbSelec);
            this.Controls.Add(this.txtIn);
            this.Controls.Add(this.btnABin);
            this.Controls.Add(this.btnAdec);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOperar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LaCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Cristian Sielach 2ºA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnAdec;
        private System.Windows.Forms.Button btnABin;
        private System.Windows.Forms.TextBox txtIn;
        private System.Windows.Forms.ComboBox cmbSelec;
        private System.Windows.Forms.TextBox txtIn2;
        private System.Windows.Forms.Label lblResult;
    }
}

