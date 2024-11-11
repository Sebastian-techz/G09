
using System.ComponentModel.DataAnnotations;

namespace G09.Modelo
{
    public class Proyecto
    {
        [Key]
        public int Id_Proyecto { get; set; }
        required public string NombreProyecto { get; set; }
        required public string Descripcion { get; set; }
    }
}
