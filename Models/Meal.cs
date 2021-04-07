using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YemekTarifleriWeb.Models
{
    public class Meal
    {
        public int Id { get; set; }
        public int Kategori { get; set; }
        public String Ad { get; set; }
        public String Malzemeler {
            get; set; }
        public String Tarif { get; set; }
    }
}
