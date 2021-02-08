using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SERVER.Models
{
  public class MembersDTO
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Password { get; set; }
    public string Adress { get; set; }
    public string Phone { get; set; }
    public int locationId { get; set; }
    public int DomainsId { get; set; }
    public int FreeTimeId { get; set; }
    public int HoursDeposit { get; set; }

    TimeBankEntities DB = new TimeBankEntities();

    public MembersDTO()
    {

    }
    public MembersDTO(Members M)
    {
      this.Id = M.Id;
      this.Name = M.Name;
      this.Password = M.Password;
      this.Adress = M.Adress;
      this.Phone = M.Phone;
      this.locationId = M.locationId;
      this.DomainsId = M.DomainsId;
      this.FreeTimeId = M.FreeTimeId;
      this.HoursDeposit = M.HoursDeposit;
    }

    public Members ConvertToMembers()
    {
      return new Members()
      {
        Id = this.Id,
        HoursDeposit = this.HoursDeposit,
        FreeTimeId = this.FreeTimeId,
        DomainsId = this.DomainsId,
        Adress = this.Adress,
        locationId = this.locationId,
        Name = this.Name,
        Phone = this.Phone,
        Password = this.Password
      };
    }

    public static List<MembersDTO> ConvertToDto(List<Members> list)
    {
      var res = from m in list
                select new MembersDTO(m);
      return res.ToList();
    }
  }
}
