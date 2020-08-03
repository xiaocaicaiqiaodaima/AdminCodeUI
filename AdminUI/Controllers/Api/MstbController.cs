using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AdminUI.Code.Web;
using AdminUI.Date.Models;
using AdminUI.Date.Repostiory;
using AdminUI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AdminUI.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class MstbController : Controller
    {


      
        public IRepositoryBase<mstb_monitorcurrent> Monitorcurrent { get; }
        public IRepositoryBase<mstb_monitorhistory> Monitorhistory { get; }
        public IRepositoryBase<mstb_monitorstate> Monitorstate { get; }

        public MstbController(IRepositoryBase<mstb_monitorcurrent> monitorcurrent, IRepositoryBase<mstb_monitorhistory> monitorhistory, IRepositoryBase<mstb_monitorstate> monitorstate)
        {
            Monitorcurrent = monitorcurrent;
            Monitorhistory = monitorhistory;
            Monitorstate = monitorstate;
        }
        // GET: api/<controller>
        [HttpGet("Getmonitorcurrent")]
        public object Getmonitorcurrent(int page, int limit)
        {
            try
            {
                var lsq = from n in Monitorcurrent.Query().Result
                         group n by n.Mac
                         into s
                         select new {
                             Ip_Address=s.Select(p=>p.Ip_Address).Take(1),
                             Mac=s.Select(p=>p.Mac).Take(1),
                             Monitor_Name = s.Select(p => p.Monitor_Name),
                             Monitor_Value=s.Select(p=>p.Monitor_Value),
                             Monitor_Time=s.Select(p=>p.Monitor_Time).Take(1)
                         };
                var ret = new{ code = 0, msg = "", data = lsq, count = lsq.Count() };
                return ret.ToJson();
            }
            catch (Exception)
            {

                return "数据错误";
            }  
        }

        [HttpGet("Getmonitorhistory")]
        public object Getmonitorhistory(string id) {

            try
            {

                    var ret = from n in Monitorcurrent.Query(t => t.Mac == id).Result
                              group n by n.Monitor_Time
                                into s
                              select new
                              {
                                  Ip_Address = s.Select(t => t.Ip_Address).Take(1),
                                  Mac = s.Select(p => p.Mac).Take(1),
                                  Monitor_Name = s.Select(t => t.Monitor_Name),
                                  Monitor_Value = s.Select(t => t.Monitor_Value),
                                  Monitor_Time = s.Select(t => t.Monitor_Time).Take(1)
                              };
                    Console.WriteLine(ret.ToJson());


                return ret.ToJson();

            }
            catch (Exception)
            {

                return "数据错误";
            }
        }


        [HttpGet("GetMonitorstate")]
        public object GetMonitorstate() {
            try
            {
                var ret = from t in Monitorstate.Query().Result
                          orderby t.Monitor_Time descending
                          select  t;
                return ret.ToJson();
            }
            catch (Exception)
            {

                return "数据错误";
            }
        }
   
       
    }
}
