using SERVER.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace SERVER.Controllers
{
  [RoutePrefix("api/BankMembers")]
  public class BankMembersController : ApiController
  {
    TimeBankEntities DB = new TimeBankEntities();

    //Bank members list
    // GET: api/BankMembers/5
    [HttpGet]
    [Route("GetAllMembers")]
    public IHttpActionResult GetAllMembers()
    {

      List<MembersDTO> res = MembersDTO.ConvertToDto(DB.Members.ToList());
      return Ok(res);

    }
    //קבלת רשימת זמנים
    [HttpGet]
    [Route("GetFreeTimeList")]
    public IHttpActionResult GetFreeTimeList()
    {

      List<FreeTimeDTO> res = FreeTimeDTO.ConvertToDto(DB.FreeTime.ToList());
      return Ok(res);

    }

    //Add member 
    // POST: api/BankMembers
    [HttpPost ]
      [Route("AddMember")]
    public IHttpActionResult AddMember(MembersDTO membersDTO)//[FromBody]Members NewMember
    {
      Members members = membersDTO.ConvertToMembers();
      DB.Members.Add(members);
      DB.SaveChanges();
      return Ok(DB.Members);
    }
    [HttpPut]
    // PUT: api/BankMembers/5
    [Route("EditMember")]
    public IHttpActionResult EditMember(MembersDTO NewMember)
    {
      Members m = NewMember.ConvertToMembers();
      Members m2 = DB.Members.Where(x => x.Id == m.Id).First();
      m2.FreeTime = m.FreeTime;

      DB.SaveChanges();
      return Ok(DB.Members);
    }

    //מחיקת חבר
    [HttpDelete]
    [Route("RemoveMember/{id}")]

    public IHttpActionResult RemoveMember(int id)
    {
      DB.Members.Remove(DB.Members.Where(x=>x.Id==id).First());
      DB.SaveChanges();
      return Ok(DB.Members);
    }

    //הוספת זמן פניות
    [HttpPost]
    [Route("AddFreeTime")]
    public IHttpActionResult AddFreeTime(FreeTimeDTO freeTimeDTO)//[FromBody]Members NewMember
    {
      FreeTime freeTime = freeTimeDTO.ConvertToFreeTime();
      freeTime.StartTime = freeTimeDTO.StartTime;
      freeTime.DayInWeek = freeTimeDTO.DayInWeek;
      freeTime.EndTime = freeTimeDTO.EndTime;
      DB.FreeTime.Add(freeTime);
      DB.SaveChanges();
      freeTime= DB.FreeTime.First(x =>x.StartTime==freeTime.StartTime && x.EndTime==freeTime.EndTime && x.DayInWeek==freeTime.DayInWeek);
      return Ok(freeTime.Id);
    }

    //החזרת רשימת אזורים
    // GET: api/BankMembers/5
    [HttpGet]
    [Route("GetAllLocations")]
    public IHttpActionResult GetAllLocations()
    {
      List<LocationsDTO> res = LocationsDTO.ConvertToDto(DB.Locations.ToList());
      return Ok(res);
    }
  }
}
