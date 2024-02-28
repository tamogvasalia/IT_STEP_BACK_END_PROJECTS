using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagmentSystemApp.Entities
{
    public abstract class AbstractEntity
    {
        [Key]
        public string Identificator { get; set; }

        protected AbstractEntity(string Identific)
        {
            this.Identificator = Identific;
      
        }

        public AbstractEntity()
        {
         
        }

        public override string ToString()
        {
            return $"ID:{Identificator};";
        }

    }
}
