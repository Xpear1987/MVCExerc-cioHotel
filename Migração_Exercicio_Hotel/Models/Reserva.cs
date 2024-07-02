using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Migração_Exercicio_Hotel.Models
{
    public class Reserva
    {
        [Key]
        public int ReservaId { get; set; }
        public string DataEntrada { get; set; }
        public string DataSaida { get; set; }
        [ForeignKey("Hotel")]
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
    }
}
