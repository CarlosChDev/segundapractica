using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace segundapractica.Models
{
    [Table("t_registro")]
    public class UsuarioModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string? NombreCompleto { get; set; }
        public string? ApellidoPaterno { get; set; }
        public string? ApellidoMaterno { get; set; }
        public string? TipoDocumento { get; set; }
        public string? Telefono { get; set; }
        public string? Genero { get; set; }
        public string? CorreoElectronico { get; set; }
        public string? TipoCuenta { get; set; }
        public string? Pais { get; set; }
        public decimal SaldoInicial { get; set; }

    }
}