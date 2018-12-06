using System;
using System.Collections.Generic;
using System.Text;

namespace LogicLayer.Entities
{
    public class Doel : BaseEntity
    {
        public string DoelNaam { get; set; }
        public int TussendoorId { get; set; }
    }
}
