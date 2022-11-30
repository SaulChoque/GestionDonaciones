
namespace GestionDonaciones
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.panelInicioSeleccion = new System.Windows.Forms.Panel();
            this.buttonEmpleado = new System.Windows.Forms.Button();
            this.buttonDonante = new System.Windows.Forms.Button();
            this.panelInicioSeleccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInicioSeleccion
            // 
            this.panelInicioSeleccion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInicioSeleccion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelInicioSeleccion.BackgroundImage")));
            this.panelInicioSeleccion.Controls.Add(this.buttonEmpleado);
            this.panelInicioSeleccion.Controls.Add(this.buttonDonante);
            this.panelInicioSeleccion.Location = new System.Drawing.Point(256, 99);
            this.panelInicioSeleccion.Name = "panelInicioSeleccion";
            this.panelInicioSeleccion.Size = new System.Drawing.Size(556, 343);
            this.panelInicioSeleccion.TabIndex = 0;
            // 
            // buttonEmpleado
            // 
            this.buttonEmpleado.Location = new System.Drawing.Point(201, 184);
            this.buttonEmpleado.Name = "buttonEmpleado";
            this.buttonEmpleado.Size = new System.Drawing.Size(148, 44);
            this.buttonEmpleado.TabIndex = 1;
            this.buttonEmpleado.Text = "Soy Empleado";
            this.buttonEmpleado.UseVisualStyleBackColor = true;
            this.buttonEmpleado.Click += new System.EventHandler(this.buttonEmpleado_Click);
            // 
            // buttonDonante
            // 
            this.buttonDonante.Location = new System.Drawing.Point(201, 80);
            this.buttonDonante.Name = "buttonDonante";
            this.buttonDonante.Size = new System.Drawing.Size(148, 44);
            this.buttonDonante.TabIndex = 0;
            this.buttonDonante.Text = "Soy Donante";
            this.buttonDonante.UseVisualStyleBackColor = true;
            this.buttonDonante.Click += new System.EventHandler(this.buttonDonante_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 558);
            this.Controls.Add(this.panelInicioSeleccion);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.panelInicioSeleccion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInicioSeleccion;
        private System.Windows.Forms.Button buttonDonante;
        private System.Windows.Forms.Button buttonEmpleado;
    }
}