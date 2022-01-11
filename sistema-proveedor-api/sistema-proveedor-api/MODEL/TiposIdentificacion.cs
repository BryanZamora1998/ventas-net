using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sistema_proveedor_api.MODEL
{
    [Table("tbl_tipos_identificacion")]
    public class TiposIdentificacion
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("SECUENCIA_TIPO_IDENTIFICACION")]
        public int secuenciaTipoIdentificacion { get; set; }
        [Column("es_activo")]
        public string esActivo { get; set; }
        [Column("nombre")]
        public string nombre { get; set; }
    }
}
