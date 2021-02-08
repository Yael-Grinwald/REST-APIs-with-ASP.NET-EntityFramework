using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SERVER.Controllers
{
  [RoutePrefix("api/HoursDeposit")]

  public class HoursDepositController : ApiController
  {
    TimeBankEntities DB = new TimeBankEntities();

    // GET: api/HoursDeposit
    public IEnumerable<string> Get()
    {
      return new string[] { "value1", "value2" };
    }

    // GET: api/HoursDeposit/5
    public string Get(int id)
    {
      return "value";
    }

    // POST: api/HoursDeposit
    public void Post([FromBody]string value)
    {
    }

    [HttpPut]
    // PUT: api/HoursDeposit/5
    [Route("Redeem/{Id1}/{Id2}")]
    public IHttpActionResult EditMember( int Id1,int Id2)
    {
      Members m = DB.Members.Where(x => x.Id == Id1).First();
      m.HoursDeposit += 1;
      m = DB.Members.Where(x => x.Id == Id2).First();
      m.HoursDeposit -= 1;
      DB.SaveChanges();
      return Ok(1);
    }

    // DELETE: api/HoursDeposit/5
    public void Delete(int id)
        {
        }
    }
}
