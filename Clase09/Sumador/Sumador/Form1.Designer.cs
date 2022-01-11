namespace Sumador
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
            this.lblNumeroUno = new System.Windows.Forms.Label();
            this.lblNumeroDos = new System.Windows.Forms.Label();
            this.txtNumeroUno = new System.Windows.Forms.TextBox();
            this.txtNumeroDos = new System.Windows.Forms.TextBox();
            this.btnSumar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumeroUno
            // 
            this.lblNumeroUno.AutoSize = true;
            this.lblNumeroUno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroUno.Location = new System.Drawing.Point(12, 9);
            this.lblNumeroUno.Name = "lblNumeroUno";
            this.lblNumeroUno.Size = new System.Drawing.Size(160, 30);
            this.lblNumeroUno.TabIndex = 0;
            this.lblNumeroUno.Text = "Numero Uno";
            // 
            // lblNumeroDos
            // 
            this.lblNumeroDos.AutoSize = true;
            this.lblNumeroDos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroDos.Location = new System.Drawing.Point(12, 39);
            this.lblNumeroDos.Name = "lblNumeroDos";
            this.lblNumeroDos.Size = new System.Drawing.Size(159, 30);
            this.lblNumeroDos.TabIndex = 1;
            this.lblNumeroDos.Text = "Numero Dos";
            // 
            // txtNumeroUno
            // 
            this.txtNumeroUno.Location = new System.Drawing.Point(158, 12);
            this.txtNumeroUno.MaxLength = 10;
            this.txtNumeroUno.Name = "txtNumeroUno";
            this.txtNumeroUno.Size = new System.Drawing.Size(234, 22);
            this.txtNumeroUno.TabIndex = 2;
            // 
            // txtNumeroDos
            // 
            this.txtNumeroDos.Location = new System.Drawing.Point(158, 42);
            this.txtNumeroDos.MaxLength = 10;
            this.txtNumeroDos.Name = "txtNumeroDos";
            this.txtNumeroDos.Size = new System.Drawing.Size(234, 22);
            this.txtNumeroDos.TabIndex = 3;
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(158, 85);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(75, 23);
            this.btnSumar.TabIndex = 4;
            this.btnSumar.Text = "Sumar";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(13, 147);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(45, 49);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 214);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.txtNumeroDos);
            this.Controls.Add(this.txtNumeroUno);
            this.Controls.Add(this.lblNumeroDos);
            this.Controls.Add(this.lblNumeroUno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sumador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroUno;
        private System.Windows.Forms.Label lblNumeroDos;
        private System.Windows.Forms.TextBox txtNumeroUno;
        private System.Windows.Forms.TextBox txtNumeroDos;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Label lblResultado;
    }
}

