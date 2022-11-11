namespace WindowsPresentacion
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
            this.GridDepartamentos = new System.Windows.Forms.DataGridView();
            this.btnEmpleadosDepartamento = new System.Windows.Forms.Button();
            this.lstEmpleados = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridDepartamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // GridDepartamentos
            // 
            this.GridDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDepartamentos.Location = new System.Drawing.Point(12, 139);
            this.GridDepartamentos.Name = "GridDepartamentos";
            this.GridDepartamentos.RowHeadersWidth = 51;
            this.GridDepartamentos.RowTemplate.Height = 24;
            this.GridDepartamentos.Size = new System.Drawing.Size(361, 148);
            this.GridDepartamentos.TabIndex = 0;
            // 
            // btnEmpleadosDepartamento
            // 
            this.btnEmpleadosDepartamento.Location = new System.Drawing.Point(22, 59);
            this.btnEmpleadosDepartamento.Name = "btnEmpleadosDepartamento";
            this.btnEmpleadosDepartamento.Size = new System.Drawing.Size(740, 46);
            this.btnEmpleadosDepartamento.TabIndex = 1;
            this.btnEmpleadosDepartamento.Text = "Mostrar los Empleados  del departamento \"Administracion\"";
            this.btnEmpleadosDepartamento.UseVisualStyleBackColor = true;
            this.btnEmpleadosDepartamento.Click += new System.EventHandler(this.btnEmpleadosDepartamento_Click);
            // 
            // lstEmpleados
            // 
            this.lstEmpleados.FormattingEnabled = true;
            this.lstEmpleados.ItemHeight = 16;
            this.lstEmpleados.Location = new System.Drawing.Point(389, 139);
            this.lstEmpleados.Name = "lstEmpleados";
            this.lstEmpleados.Size = new System.Drawing.Size(373, 148);
            this.lstEmpleados.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstEmpleados);
            this.Controls.Add(this.btnEmpleadosDepartamento);
            this.Controls.Add(this.GridDepartamentos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GridDepartamentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridDepartamentos;
        private System.Windows.Forms.Button btnEmpleadosDepartamento;
        private System.Windows.Forms.ListBox lstEmpleados;
    }
}

