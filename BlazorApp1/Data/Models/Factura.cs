using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp.Data.Models
{
    public class Factura
    {
        public int IdFactura { get; set; }
        public int IdLocatie { get; set; }

        public string NumarFactura { get; set; }
        public DateTime DataFactura { get; set; }
        public string NumeClient { get; set; }
        
    }
}
