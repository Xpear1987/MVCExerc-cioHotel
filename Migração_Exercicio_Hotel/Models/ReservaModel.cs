using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Migração_Exercicio_Hotel.Models
{
    public class ReservaModel
    {
        public int ReservaId { get; set; }
        public string DataEntrada { get; set; }
        public string DataSaida { get; set; }
        [ForeignKey("HotelModel")]
        public int HotelId { get; set; }
        public HotelModel Hotel { get; set; }
    }
}
