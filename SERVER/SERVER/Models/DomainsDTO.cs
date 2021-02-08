using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SERVER.Models
{
    public class DomainsDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descreption { get; set; }
        public string Image { get; set; }
        TimeBankEntities DB = new TimeBankEntities();
        public DomainsDTO()
        {

        }
        public DomainsDTO(Domains d)
        {
            this.Id = d.Id;
            this.Name = d.Name;
            this.Descreption = d.Descreption;
            this.Image = d.Image;

        }
    }
}
