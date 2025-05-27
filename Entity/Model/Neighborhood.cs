using Entity.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model
{
    // Clase Barrio
    public class Neighborhood : BaseEntity
    {
        //Nombre del barrio
        public string Name { set; get; }
        //Id de la ciudad
        public int CityId { set; get; }
        //Ciudad
        public City city { set; get; }
        // Codigo Postal
        public int ZipCode { get; set; }
    }
}
