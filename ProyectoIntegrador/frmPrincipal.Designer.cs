
namespace ProyectoIntegrador
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
            this.btnInsciribrPostulante = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAsignarCurso = new System.Windows.Forms.Button();
            this.btnPagarCurso = new System.Windows.Forms.Button();
            this.btnEmitirComprobante = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInsciribrPostulante
            // 
            this.btnInsciribrPostulante.Location = new System.Drawing.Point(119, 122);
            this.btnInsciribrPostulante.Name = "btnInsciribrPostulante";
            this.btnInsciribrPostulante.Size = new System.Drawing.Size(211, 100);
            this.btnInsciribrPostulante.TabIndex = 0;
            this.btnInsciribrPostulante.Text = "Inscribir Postulante";
            this.btnInsciribrPostulante.UseVisualStyleBackColor = true;
            this.btnInsciribrPostulante.Click += new System.EventHandler(this.btnInsciribrPostulante_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(637, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(115, 40);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // btnAsignarCurso
            // 
            this.btnAsignarCurso.Location = new System.Drawing.Point(434, 122);
            this.btnAsignarCurso.Name = "btnAsignarCurso";
            this.btnAsignarCurso.Size = new System.Drawing.Size(211, 100);
            this.btnAsignarCurso.TabIndex = 6;
            this.btnAsignarCurso.Text = "Asignar Curso";
            this.btnAsignarCurso.UseVisualStyleBackColor = true;
            // 
            // btnPagarCurso
            // 
            this.btnPagarCurso.Location = new System.Drawing.Point(119, 274);
            this.btnPagarCurso.Name = "btnPagarCurso";
            this.btnPagarCurso.Size = new System.Drawing.Size(211, 100);
            this.btnPagarCurso.TabIndex = 7;
            this.btnPagarCurso.Text = "Pagar Curso";
            this.btnPagarCurso.UseVisualStyleBackColor = true;
            // 
            // btnEmitirComprobante
            // 
            this.btnEmitirComprobante.Location = new System.Drawing.Point(434, 274);
            this.btnEmitirComprobante.Name = "btnEmitirComprobante";
            this.btnEmitirComprobante.Size = new System.Drawing.Size(211, 100);
            this.btnEmitirComprobante.TabIndex = 8;
            this.btnEmitirComprobante.Text = "Emitir Comprobante del Curso";
            this.btnEmitirComprobante.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 441);
            this.Controls.Add(this.btnEmitirComprobante);
            this.Controls.Add(this.btnPagarCurso);
            this.Controls.Add(this.btnAsignarCurso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnInsciribrPostulante);
            this.Name = "frmPrincipal";
            this.Text = "Ventana Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsciribrPostulante;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAsignarCurso;
        private System.Windows.Forms.Button btnPagarCurso;
        private System.Windows.Forms.Button btnEmitirComprobante;
    }
}