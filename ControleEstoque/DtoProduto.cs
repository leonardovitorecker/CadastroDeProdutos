using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque1
{
    [Table("produto", Schema = "public")]

    public  class DtoProduto
    {
        [Key]
        public int Codprod { get; set; }
        public string CodigoBarras { get; set; }
        public string Nome { get; set; }
        public string Fabricante { get; set; }
        public string Validade { get; set; }
    }
}
