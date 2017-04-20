using Picturesfromurl.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
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
                return BadRequest("enter correct uri");
            else if (!url.Contains("http"))
                return BadRequest("Please enter valid URL!!!");
            else
            {
                string path = url;
                using (client = new WebClient())
                {
                    HtmlContent = client.DownloadString(url); 
                }

                AllUrls = new List<string>();

                var imageURLs = showMatch(HtmlContent, @"<(img)\b[^>]*>");
                string[] split = imageURLs.Split(new Char[] { '"', '?' });

                foreach (var item in split)
                {

                    if (item.Contains(".jpg")|| item.Contains(".png") || item.Contains(".svg"))
                    {
                        AllUrls.Add(item);
                    }
                }

            }

            return Ok(AllUrls);
        }

        private string showMatch(string text, string expr)
        {
            MatchCollection mc = Regex.Matches(text, expr);
            string result = "";
            foreach (Match m in mc)
            {
                result += m.ToString() + "\n";
            }
            return result;
        }
    }
}
