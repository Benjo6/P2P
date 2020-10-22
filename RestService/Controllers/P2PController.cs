using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Constraints;
using Peers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class P2PController : ControllerBase
    {
        private static Dictionary<string, FileEndPoint> list = new Dictionary<string, FileEndPoint>()
        {

        };
        // GET: api/<P2PController>
        [HttpGet ("{filename}")]
        public FileEndPoint GetFileName(string filename)
        {
            return list[filename];
        }


        // POST api/<P2PController>
        [HttpPost ("{filename}")]
        public void Register(string filename, [FromBody] FileEndPoint value)
        {
            list.Add(filename, value);
        }

        // PUT api/<P2PController>/5
        [HttpDelete("{filename}")]
        public void Deregister(string filename, [FromBody] FileEndPoint value)
        {
            list.Remove(filename);
        }
    }
}
