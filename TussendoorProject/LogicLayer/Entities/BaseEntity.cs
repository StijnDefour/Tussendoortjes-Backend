using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LogicLayer.Entities
{
    public abstract class BaseEntity : IEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
