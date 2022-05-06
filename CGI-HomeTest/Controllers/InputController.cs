using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CGI_HomeTest.Controllers
{
    [Route("")]
    [ApiController]
    public class InputController : ControllerBase
    {
        [HttpPost("count")]
        [Consumes("text/plain")]
        public ActionResult<string> Count([FromBody] string data)
        {
            var map = new Dictionary<string, int>();
            string[] split = data.ToLower().Split(" ");
         
            foreach (var word in split)
            {
                if (map.ContainsKey(word))
                {
                    map[word] += 1;
                }
                else
                {
                    map.Add(word, 1);
                }
            }

            var sortedDict = from entry in map orderby entry.Value descending select entry;

            var sortedList = new List<KeyValuePair<string, int>>(sortedDict.Take(10));

            return JsonConvert.SerializeObject(sortedList).ToString();
        }
    }
}