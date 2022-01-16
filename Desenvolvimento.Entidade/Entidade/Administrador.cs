using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Desenvolvimento.Entidade.Entidade
{
    [Table("tb_Administrador")]
    public class Administrador
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdAdm { get; set; }

        public string NomeAdm { get; set; }

        public string EmailAdm { get; set; }

        public int Id_Login { get; set; }

        [ForeignKey("Id_Login")]
        public Login Login { get; set; }
    }
}
