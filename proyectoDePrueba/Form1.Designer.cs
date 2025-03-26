
namespace proyectoDePrueba
{
    partial class proyectoPrueba
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
            this.lblPrueba = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblparticipantes = new System.Windows.Forms.Label();
            this.txtparticipantes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPrueba
            // 
            this.lblPrueba.AutoSize = true;
            this.lblPrueba.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrueba.Location = new System.Drawing.Point(313, 108);
            this.lblPrueba.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrueba.Name = "lblPrueba";
            this.lblPrueba.Size = new System.Drawing.Size(379, 39);
            this.lblPrueba.TabIndex = 0;
            this.lblPrueba.Text = "Probando Git y GitHub";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(659, 240);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 28);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblparticipantes
            // 
            this.lblparticipantes.AutoSize = true;
            this.lblparticipantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblparticipantes.Location = new System.Drawing.Point(157, 244);
            this.lblparticipantes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblparticipantes.Name = "lblparticipantes";
            this.lblparticipantes.Size = new System.Drawing.Size(215, 25);
            this.lblparticipantes.TabIndex = 2;
            this.lblparticipantes.Text = "Igresar participantes:";
            this.lblparticipantes.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtparticipantes
            // 
            this.txtparticipantes.Location = new System.Drawing.Point(416, 244);
            this.txtparticipantes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtparticipantes.Name = "txtparticipantes";
            this.txtparticipantes.Size = new System.Drawing.Size(219, 22);
            this.txtparticipantes.TabIndex = 3;
            // 
            // proyectoPrueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtparticipantes);
            this.Controls.Add(this.lblparticipantes);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblPrueba);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "proyectoPrueba";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyecto de prueba";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.proyectoPrueba_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrueba;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblparticipantes;
        private System.Windows.Forms.TextBox txtparticipantes;
    }
}

