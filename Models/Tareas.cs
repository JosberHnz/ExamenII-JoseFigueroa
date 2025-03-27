using System.ComponentModel.DataAnnotations;

namespace ExamenII.Models;

public class Tareas
{
    [Key]
    public Guid Id { get; set; }
    public string Titulo { get; set; }
    public string Descripcion { get; set; }
    public DateTime FechaCreacion { get; set; }
}
