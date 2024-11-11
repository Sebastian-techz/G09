

using System.ComponentModel.DataAnnotations;

namespace G09.Modelo
{
    public class Empleado
    {
        [Key]
        public int  Id_Empleado { get; set; }
        required public string Nombre { get; set; }
        required public string Apellido { get; set; }
        required public int DNI { get; set; }
    }
}
