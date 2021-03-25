
namespace GeneradorRFC
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
            this.lstBxContenedor = new System.Windows.Forms.ListBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnBlock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBxContenedor
            // 
            this.lstBxContenedor.FormattingEnabled = true;
            this.lstBxContenedor.Location = new System.Drawing.Point(12, 47);
            this.lstBxContenedor.Name = "lstBxContenedor";
            this.lstBxContenedor.Size = new System.Drawing.Size(363, 160);
            this.lstBxContenedor.TabIndex = 0;
            this.lstBxContenedor.DoubleClick += new System.EventHandler(this.lstBxContenedor_DoubleClick);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(194, 14);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 1;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(300, 11);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnBlock
            // 
            this.btnBlock.Location = new System.Drawing.Point(12, 14);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(44, 23);
            this.btnBlock.TabIndex = 3;
            this.btnBlock.Text = "Blk";
            this.btnBlock.UseVisualStyleBackColor = true;
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 223);
            this.Controls.Add(this.btnBlock);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lstBxContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Generador de RFC\'s falsos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBxContenedor;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnBlock;
    }
}

