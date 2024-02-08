using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp.Data.Models
{
    public class DetaliiFactura
    {
        public int IdDetaliiFactura { get; set; }
        public int IdLocatie { get; set; }
        public string NumeProdus { get; set; }
        public decimal Cantitate { get; set; }
        public decimal PretUnitar { get; set; }
        public decimal Valoare { get; set; }

        public int IdFactura { get; set; }
    }
}
