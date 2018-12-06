using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LogicLayer.Entities
{
    public class Tussendoor : BaseEntity
    {
        public string ImagePath { get; set; }
        public string Beschrijving { get; set; }
        public string Thema { get; set; }

        [NotMapped]
        public List<Doel> Doelen { get; set; }
    }
}
