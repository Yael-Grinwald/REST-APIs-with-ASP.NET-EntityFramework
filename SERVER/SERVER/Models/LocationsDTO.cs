using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SERVER.Models
{
  public class LocationsDTO
  {
    public int Id { get; set; }
    public string Area { get; set; }
    TimeBankEntities DB = new TimeBankEntities();
    public LocationsDTO()
    {
        
    }
    public LocationsDTO(Locations l)
    {
      this.Id = l.Id;
      this.Area = l.Area;

    }
    public Locations ConvertToLocations()
    {
      return new Locations()
      {
        Id = this.Id,
        Area = this.Area
      };
    }

    public static List<LocationsDTO> ConvertToDto(List<Locations> list)
    {
      var res = from l in list
                select new LocationsDTO(l);
      return res.ToList();
    }
  }
}
