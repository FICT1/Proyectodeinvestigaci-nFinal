namespace Investigacion_Final
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
            this.cmbTamaño = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnLineal = new System.Windows.Forms.Button();
            this.btnBinaria = new System.Windows.Forms.Button();
            this.btnInsertion = new System.Windows.Forms.Button();
            this.btnQuick = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbTamaño
            // 
            this.cmbTamaño.FormattingEnabled = true;
            this.cmbTamaño.Location = new System.Drawing.Point(35, 37);
            this.cmbTamaño.Name = "cmbTamaño";
            this.cmbTamaño.Size = new System.Drawing.Size(184, 24);
            this.cmbTamaño.TabIndex = 0;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(35, 102);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(180, 22);
            this.txtBuscar.TabIndex = 1;
            // 
            // lblInfo
            // 
            this.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInfo.Location = new System.Drawing.Point(149, 335);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(299, 46);
            this.lblInfo.TabIndex = 3;
            // 
            // lblResultado
            // 
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultado.Location = new System.Drawing.Point(149, 246);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(299, 46);
            this.lblResultado.TabIndex = 4;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(279, 37);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(143, 62);
            this.btnGenerar.TabIndex = 5;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnLineal
            // 
            this.btnLineal.Location = new System.Drawing.Point(200, 171);
            this.btnLineal.Name = "btnLineal";
            this.btnLineal.Size = new System.Drawing.Size(101, 38);
            this.btnLineal.TabIndex = 6;
            this.btnLineal.Text = "Lineal";
            this.btnLineal.UseVisualStyleBackColor = true;
            // 
            // btnBinaria
            // 
            this.btnBinaria.Location = new System.Drawing.Point(341, 171);
            this.btnBinaria.Name = "btnBinaria";
            this.btnBinaria.Size = new System.Drawing.Size(101, 38);
            this.btnBinaria.TabIndex = 7;
            this.btnBinaria.Text = "Binaria";
            this.btnBinaria.UseVisualStyleBackColor = true;
            // 
            // btnInsertion
            // 
            this.btnInsertion.Location = new System.Drawing.Point(471, 171);
            this.btnInsertion.Name = "btnInsertion";
            this.btnInsertion.Size = new System.Drawing.Size(101, 38);
            this.btnInsertion.TabIndex = 8;
            this.btnInsertion.Text = "Insertion ";
            this.btnInsertion.UseVisualStyleBackColor = true;
            // 
            // btnQuick
            // 
            this.btnQuick.Location = new System.Drawing.Point(69, 171);
            this.btnQuick.Name = "btnQuick";
            this.btnQuick.Size = new System.Drawing.Size(101, 38);
            this.btnQuick.TabIndex = 9;
            this.btnQuick.Text = "Quick";
            this.btnQuick.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "TIPO DE BUSQUEDAS (IMPAR)";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tamaño de datos:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Número a buscar: ";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(254, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Resultado";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(250, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Informacion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 401);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.cmbTamaño);
            this.Controls.Add(this.btnQuick);
            this.Controls.Add(this.btnInsertion);
            this.Controls.Add(this.btnBinaria);
            this.Controls.Add(this.btnLineal);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblInfo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "`";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTamaño;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnLineal;
        private System.Windows.Forms.Button btnBinaria;
        private System.Windows.Forms.Button btnInsertion;
        private System.Windows.Forms.Button btnQuick;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

