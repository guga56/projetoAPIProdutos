using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Desenvolvimento.Entidade.Entidade
{
    [Table("tb_Produto")]
    public class Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProduto { get; set; }

        public string NomeProd { get; set; }

        public string DescricaqoProd { get; set; }

        public int Id_Loja { get; set; }

        [ForeignKey("Id_Loja")]
        public Loja Loja { get; set; }
    }
}
