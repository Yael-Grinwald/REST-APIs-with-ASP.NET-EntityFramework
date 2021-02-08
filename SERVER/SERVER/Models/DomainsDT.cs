using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SERVER.Models
{
  public class DomainsDT
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Descreption { get; set; }
    public string Image { get; set; }
    TimeBankEntities DB = new TimeBankEntities();
    public DomainsDT()
    {

    }
    public DomainsDT(Domains d)
    {
      this.Id = d.Id;
      this.Name = d.Name;
      this.Descreption = d.Descreption;
      this.Image = d.Image;

    }

    public Domains ConvertToDomains()
    {
      return new Domains()
      {
        Id = this.Id,
        Name = this.Name,
        Descreption = this.Descreption,
        Image = this.Image
      };
    }

    public static List<DomainsDT> ConvertToDto(List<Domains> list)
    {
      var res = from d in list
                select new DomainsDT(d);
      return res.ToList();
    }
  }
}
