namespace G09
{
    partial class AppG09
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEmpleados = new Button();
            btnDepartamentos = new Button();
            btnProyectos = new Button();
            dgEmpleados = new DataGridView();
            dgDepartamentos = new DataGridView();
            dgProyectos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgEmpleados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgDepartamentos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgProyectos).BeginInit();
            SuspendLayout();
            // 
            // btnEmpleados
            // 
            btnEmpleados.Location = new Point(37, 21);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(165, 29);
            btnEmpleados.TabIndex = 0;
            btnEmpleados.Text = "Mostrar Empleados";
            btnEmpleados.UseVisualStyleBackColor = true;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // btnDepartamentos
            // 
            btnDepartamentos.Location = new Point(19, 210);
            btnDepartamentos.Name = "btnDepartamentos";
            btnDepartamentos.Size = new Size(183, 29);
            btnDepartamentos.TabIndex = 1;
            btnDepartamentos.Text = "Mostrar Departamentos";
            btnDepartamentos.Click += btnDepartamentos_Click;
            // 
            // btnProyectos
            // 
            btnProyectos.Location = new Point(19, 409);
            btnProyectos.Name = "btnProyectos";
            btnProyectos.Size = new Size(183, 29);
            btnProyectos.TabIndex = 2;
            btnProyectos.Text = "Mostrar Proyectos";
            btnProyectos.UseVisualStyleBackColor = true;
            btnProyectos.Click += btnProyectos_Click;
            // 
            // dgEmpleados
            // 
            dgEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgEmpleados.Location = new Point(267, 12);
            dgEmpleados.Name = "dgEmpleados";
            dgEmpleados.ReadOnly = true;
            dgEmpleados.RowHeadersWidth = 51;
            dgEmpleados.Size = new Size(453, 166);
            dgEmpleados.TabIndex = 3;
            // 
            // dgDepartamentos
            // 
            dgDepartamentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgDepartamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDepartamentos.Location = new Point(267, 210);
            dgDepartamentos.Name = "dgDepartamentos";
            dgDepartamentos.ReadOnly = true;
            dgDepartamentos.RowHeadersWidth = 51;
            dgDepartamentos.Size = new Size(453, 166);
            dgDepartamentos.TabIndex = 4;
            // 
            // dgProyectos
            // 
            dgProyectos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgProyectos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProyectos.Location = new Point(267, 409);
            dgProyectos.Name = "dgProyectos";
            dgProyectos.ReadOnly = true;
            dgProyectos.RowHeadersWidth = 51;
            dgProyectos.Size = new Size(453, 166);
            dgProyectos.TabIndex = 5;
            // 
            // AppG09
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 589);
            Controls.Add(dgProyectos);
            Controls.Add(dgDepartamentos);
            Controls.Add(dgEmpleados);
            Controls.Add(btnProyectos);
            Controls.Add(btnDepartamentos);
            Controls.Add(btnEmpleados);
            Name = "AppG09";
            Text = "G09 App";
            ((System.ComponentModel.ISupportInitialize)dgEmpleados).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgDepartamentos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgProyectos).EndInit();
            ResumeLayout(false);
        }

        private void NewMethod()
        {
            btnEmpleados.Click += this.btnEmpleados_Click;
        }

        #endregion

        private Button btnEmpleados;
        private Button btnDepartamentos;
        private Button btnProyectos;
        private DataGridView dgEmpleados;
        private DataGridView dgDepartamentos;
        private DataGridView dgProyectos;
    }
}
