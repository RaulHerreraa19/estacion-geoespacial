using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class CarModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public double Latitud { get; set; }
        public double Longitud { get; set; }
        public double Altitud { get; set; }
        public double PresionAtmosferica { get; set; }
        public double Temperatura { get; set; }

        //RELACIONES
        public virtual ICollection<UsersModel>? Users { get; set; }

    }
}

