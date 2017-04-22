using Picturesfromurl.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Http;

namespace Picturesfromurl.Controllers
{
    public class PicturesExtracterController : ApiController
    {
        private WebClient client;
        private string HtmlContent { get; set; }
        public List<string> AllUrls { get; set; }

        // GET: api/PicturesExtracter/url
        public IHttpActionResult Get(string url)
        {
            if (!Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
                return BadRequest("Please enter valid URL!!!");
            if (!url.Contains("http"))
                return BadRequest("Please include \"Http\" URL!!!");
            using (client = new WebClient())
            {
                HtmlContent = client.DownloadString(url);
            }

            AllUrls = new List<string>();

            var imageUrLs = showMatch(HtmlContent, @"<(img)\b[^>]*>");
            string[] split = imageUrLs.Split(new Char[] { '"', '?' });

            foreach (var item in split)
            {
                if (item.Contains(".jpg") || item.Contains(".png") || item.Contains(".svg"))
                {
                    AllUrls.Add(item);
                }
            }
            return Excellent_Method(AllUrls).Result;
        }

        public async Task<IHttpActionResult> Excellent_Method(List<string> coll) 
        {
            HttpClient client = new HttpClient();
            List<Node> list = new List<Node>();
            foreach (string s in coll)
            {
                Node t = new Node { Bytes = await client.GetByteArrayAsync(s) };
                list.Add(t);
            }
            return Ok(list);
        }

        private string showMatch(string text, string expr)
        {
            MatchCollection mc = Regex.Matches(text, expr);
            string result = "";
            foreach (Match m in mc)
            {
                result += m + "\n";
            }
            return result;
        }
    }
}
