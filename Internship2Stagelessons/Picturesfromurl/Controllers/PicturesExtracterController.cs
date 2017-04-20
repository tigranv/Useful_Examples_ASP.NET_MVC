using Picturesfromurl.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;
using System.Web.Http;
using Newtonsoft.Json;
using Picturesfromurl.Formatter;

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
            //if (!Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
            //    return BadRequest("Please enter valid URL!!!");
            //else if (!url.Contains("http"))
            //    return BadRequest("Please include \"Http\" URL!!!");
            //else
            //{
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

                if (item.Contains(".jpg") || item.Contains(".png") || item.Contains(".svg"))
                {
                    AllUrls.Add(item);
                }
            }
            //}
            ImageFormatter d = new ImageFormatter();
            
            return MM(AllUrls);
        }

        public IHttpActionResult MM(List<string> coll)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage mes = new HttpResponseMessage();
            List<byte[]> list = new List<byte[]>();
            foreach (string s in coll)
            {
                var data = client.GetByteArrayAsync(s).Result;
                list.Add(data);
            }
            //mes.Content = new ObjectContent<List<byte[]>>(list, new JsonMediaTypeFormatter());
            return Ok(list);
        }
        // image
        //public HttpResponseMessage Get()
        //{
        //    HttpResponseMessage result = new HttpResponseMessage(HttpStatusCode.OK);
        //    string path = HostingEnvironment.MapPath("~/Images/pic.jpg");

        //    using (FileStream fs = new FileStream(path, FileMode.Open))
        //    using (Image image = Image.FromStream(fs))
        //    using (MemoryStream ms = new MemoryStream())
        //    {
        //        image.Save(ms, ImageFormat.Jpeg);
        //        result.Content = new ByteArrayContent(ms.ToArray()); // binary array
        //        result.Content.Headers.ContentType = new MediaTypeHeaderValue("image/jpeg");
        //    }
        //    return result;
        //}

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
