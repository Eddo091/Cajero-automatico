namespace Cajero_automatico
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
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRetirar2 = new System.Windows.Forms.Button();
            this.txtcCant = new System.Windows.Forms.TextBox();
            this.lblTotal2 = new System.Windows.Forms.Label();
            this.btnFibo = new System.Windows.Forms.Button();
            this.txtfibo = new System.Windows.Forms.TextBox();
            this.lblFiboResp = new System.Windows.Forms.Label();
            this.lblFibo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrimo = new System.Windows.Forms.TextBox();
            this.lblPrimoResp = new System.Windows.Forms.Label();
            this.btnPrimo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(12, 9);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(149, 24);
            this.lblCantidad.TabIndex = 0;
            this.lblCantidad.Text = "Cantidad a sacar";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(579, 13);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(61, 20);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total: ?";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(167, 13);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 2;
            // 
            // btnRetirar
            // 
            this.btnRetirar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetirar.Location = new System.Drawing.Point(319, 4);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(98, 35);
            this.btnRetirar.TabIndex = 3;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = true;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cantidad a pagar";
            // 
            // btnRetirar2
            // 
            this.btnRetirar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetirar2.Location = new System.Drawing.Point(701, 59);
            this.btnRetirar2.Name = "btnRetirar2";
            this.btnRetirar2.Size = new System.Drawing.Size(98, 35);
            this.btnRetirar2.TabIndex = 5;
            this.btnRetirar2.Text = "Pagar";
            this.btnRetirar2.UseVisualStyleBackColor = true;
            this.btnRetirar2.Click += new System.EventHandler(this.btnRetirar2_Click);
            // 
            // txtcCant
            // 
            this.txtcCant.Location = new System.Drawing.Point(452, 66);
            this.txtcCant.Name = "txtcCant";
            this.txtcCant.Size = new System.Drawing.Size(100, 20);
            this.txtcCant.TabIndex = 6;
            // 
            // lblTotal2
            // 
            this.lblTotal2.AutoSize = true;
            this.lblTotal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal2.Location = new System.Drawing.Point(579, 68);
            this.lblTotal2.Name = "lblTotal2";
            this.lblTotal2.Size = new System.Drawing.Size(61, 20);
            this.lblTotal2.TabIndex = 7;
            this.lblTotal2.Text = "Total: ?";
            // 
            // btnFibo
            // 
            this.btnFibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFibo.Location = new System.Drawing.Point(311, 106);
            this.btnFibo.Name = "btnFibo";
            this.btnFibo.Size = new System.Drawing.Size(106, 35);
            this.btnFibo.TabIndex = 8;
            this.btnFibo.Text = "Realizar";
            this.btnFibo.UseVisualStyleBackColor = true;
            this.btnFibo.Click += new System.EventHandler(this.btnFibo_Click);
            // 
            // txtfibo
            // 
            this.txtfibo.Location = new System.Drawing.Point(167, 113);
            this.txtfibo.Name = "txtfibo";
            this.txtfibo.Size = new System.Drawing.Size(100, 20);
            this.txtfibo.TabIndex = 9;
            // 
            // lblFiboResp
            // 
            this.lblFiboResp.AutoSize = true;
            this.lblFiboResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiboResp.Location = new System.Drawing.Point(453, 115);
            this.lblFiboResp.Name = "lblFiboResp";
            this.lblFiboResp.Size = new System.Drawing.Size(99, 20);
            this.lblFiboResp.TabIndex = 10;
            this.lblFiboResp.Text = "Resultado: ?";
            // 
            // lblFibo
            // 
            this.lblFibo.AutoSize = true;
            this.lblFibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFibo.Location = new System.Drawing.Point(36, 117);
            this.lblFibo.Name = "lblFibo";
            this.lblFibo.Size = new System.Drawing.Size(93, 24);
            this.lblFibo.TabIndex = 11;
            this.lblFibo.Text = "Fibonacci";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Numero Primo";
            // 
            // txtPrimo
            // 
            this.txtPrimo.Location = new System.Drawing.Point(167, 163);
            this.txtPrimo.Name = "txtPrimo";
            this.txtPrimo.Size = new System.Drawing.Size(100, 20);
            this.txtPrimo.TabIndex = 13;
            // 
            // lblPrimoResp
            // 
            this.lblPrimoResp.AutoSize = true;
            this.lblPrimoResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimoResp.Location = new System.Drawing.Point(448, 167);
            this.lblPrimoResp.Name = "lblPrimoResp";
            this.lblPrimoResp.Size = new System.Drawing.Size(104, 20);
            this.lblPrimoResp.TabIndex = 14;
            this.lblPrimoResp.Text = "Respuesta: ?";
            // 
            // btnPrimo
            // 
            this.btnPrimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimo.Location = new System.Drawing.Point(302, 163);
            this.btnPrimo.Name = "btnPrimo";
            this.btnPrimo.Size = new System.Drawing.Size(106, 35);
            this.btnPrimo.TabIndex = 15;
            this.btnPrimo.Text = "Realizar";
            this.btnPrimo.UseVisualStyleBackColor = true;
            this.btnPrimo.Click += new System.EventHandler(this.btnPrimo_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Cantidad de producto";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(209, 65);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 321);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPrimo);
            this.Controls.Add(this.lblPrimoResp);
            this.Controls.Add(this.txtPrimo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblFibo);
            this.Controls.Add(this.lblFiboResp);
            this.Controls.Add(this.txtfibo);
            this.Controls.Add(this.btnFibo);
            this.Controls.Add(this.lblTotal2);
            this.Controls.Add(this.txtcCant);
            this.Controls.Add(this.btnRetirar2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRetirar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblCantidad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRetirar2;
        private System.Windows.Forms.TextBox txtcCant;
        private System.Windows.Forms.Label lblTotal2;
        private System.Windows.Forms.Button btnFibo;
        private System.Windows.Forms.TextBox txtfibo;
        private System.Windows.Forms.Label lblFiboResp;
        private System.Windows.Forms.Label lblFibo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrimo;
        private System.Windows.Forms.Label lblPrimoResp;
        private System.Windows.Forms.Button btnPrimo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrecio;
    }
}

