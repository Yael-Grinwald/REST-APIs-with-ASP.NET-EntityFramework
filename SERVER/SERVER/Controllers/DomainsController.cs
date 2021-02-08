using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SERVER;
using SERVER.Models;

namespace SERVER.Controllers
{
  [RoutePrefix("api/Domains")]
  public class DomainsController : ApiController
  {
    TimeBankEntities DB = new TimeBankEntities();
    // GET: api/Domains
    public IEnumerable<string> Get()
    {
      return new string[] { "value1", "value2" };
    }
    //שליפת רשימת תחומים
    // GET: api/BankMembers/5
    [HttpGet]
    [Route("GetAllDomains")]
    public IHttpActionResult GetAllDomains()
    {

      List<DomainsDT> res = DomainsDT.ConvertToDto(DB.Domains.ToList());
      return Ok(res);

      //DB.Configuration.ProxyCreationEnabled = false;
      //return Ok(DB.Domains);
    }
    //הוספת תחום
    [HttpPost]
    [Route("AddField")]
    public IHttpActionResult AddField(DomainsDT domainsDT)
    {
      Domains D = domainsDT.ConvertToDomains();
     
      DB.Domains.Add(D);
      DB.SaveChanges();
      int ND = DB.Domains.First(x => x.Name == D.Name).Id;
      return Ok(ND);
    }

    // GET: api/Domains/5
    public string Get(int id)
    {
      return "value";
    }

    // POST: api/Domains
    public void Post([FromBody]string value)
    {
    }

    // PUT: api/Domains/5
    public void Put(int id, [FromBody]string value)
    {
    }

    // DELETE: api/Domains/5
    public void Delete(int id)
    {
    }
  }
}
