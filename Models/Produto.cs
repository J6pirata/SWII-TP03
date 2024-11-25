using System.ComponentModel.DataAnnotations;

namespace TP03.Models
{
   
        public class Produto
        {
        [Key]
            public int Id { get; set; }

        [Required]
        [StringLength(100)]
            public string Nome { get; set; }

        [StringLength(500)]
            public string Descricao { get; set; }

        [Required]
        [DataType(DataType.Currency)]   
            public decimal Preco { get; set; }

        [Required]  
            public int Quantidade { get; set; }
        }

    
}
