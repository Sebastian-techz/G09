

using System.ComponentModel.DataAnnotations;

namespace G09.Modelo
{
    public class Departamento
    {
        [Key]
        public int Id_Departamento { get; set; }
        required public string NombreDepartamento { get; set; }
    }
}
