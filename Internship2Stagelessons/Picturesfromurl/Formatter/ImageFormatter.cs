using Picturesfromurl.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Net.Mail;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;

namespace Picturesfromurl.Formatter
{
    public class ImageFormatter : MediaTypeFormatter
    {
        public ImageFormatter() { SupportedMediaTypes.Add(new MediaTypeHeaderValue("image/Jpeg")); }

        public override bool CanReadType(Type type) { return false; }

        public override bool CanWriteType(Type type) { return type == typeof(ImageInstance); }

        public override Task WriteToStreamAsync(Type type,
            object value, Stream writeStream, HttpContent content,
            TransportContext transportContext)
        { return Task.Factory.StartNew(() => WriteToStream(type, value, writeStream, content)); }

        public void WriteToStream(Type type, object value, Stream stream, HttpContent content)
        {
            ImageInstance imageinst = (ImageInstance)value;
            WebClient client = new WebClient();
            
            
            //image.Save(stream, ImageFormat.Jpeg); image.Dispose();
        }
    }
}