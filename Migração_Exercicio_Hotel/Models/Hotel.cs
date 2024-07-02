using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Migração_Exercicio_Hotel.Models
{
    public class Hotel
    {
        [Key]
        public int HotelId { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
}
