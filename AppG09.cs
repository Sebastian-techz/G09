using G09.Data;

namespace G09
{
    public partial class AppG09 : Form
    {
        public AppG09()
        {
            InitializeComponent();
        }

        private void CargarEmpleados()
        {
            using (var context = new Contexto())
            {
                // Obtenemos los datos de la tabla empleados usando Entity Framework
                var empleados = context.Empleados.ToList();

                // Asignamos la lista de empleados como el origen de datos del DataGridView
                dgEmpleados.DataSource = empleados;
            }
        }
        private void CargarDepartamentos()
        {
            using (var context = new Contexto())
            {
                // Obtenemos los datos de la tabla empleados usando Entity Framework
                var departamentos = context.Departamentos.ToList();

                // Asignamos la lista de empleados como el origen de datos del DataGridView
                dgDepartamentos.DataSource = departamentos;
            }
        }
        private void CargarProyectos()
        {
            using (var context = new Contexto())
            {
                // Obtenemos los datos de la tabla empleados usando Entity Framework
                var proyectos = context.Proyectos.ToList();

                // Asignamos la lista de empleados como el origen de datos del DataGridView
                dgProyectos.DataSource = proyectos;
            }
        }


        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            CargarEmpleados();
        }

        private void btnDepartamentos_Click(object sender, EventArgs e)
        {
            CargarDepartamentos();
        }

        private void btnProyectos_Click(object sender, EventArgs e)
        {
            CargarProyectos();
        }
    }
}
