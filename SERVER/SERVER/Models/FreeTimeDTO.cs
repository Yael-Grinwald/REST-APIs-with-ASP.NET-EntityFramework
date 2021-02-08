using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SERVER.Models
{
  public class FreeTimeDTO
  {
    public int Id { get; set; }
    public string DayInWeek { get; set; }
    public int StartTime { get; set; }
    public int EndTime { get; set; }
    TimeBankEntities DB = new TimeBankEntities();
    public FreeTimeDTO()
    {
        
    }
    public FreeTimeDTO(FreeTime f)
    {
      this.Id = f.Id;
      this.DayInWeek = f.DayInWeek;
      this.StartTime = f.StartTime;
      this.EndTime = f.EndTime;

    }

    public FreeTime ConvertToFreeTime()
    {
      return new FreeTime()
      {
        Id = this.Id,
        DayInWeek = this.DayInWeek,
        StartTime = this.StartTime,
        EndTime = this.EndTime
      };
    }

    public static List<FreeTimeDTO> ConvertToDto(List<FreeTime> list)
    {
      var res = from f in list
                select new FreeTimeDTO(f);
      return res.ToList();
    }
  }
}
