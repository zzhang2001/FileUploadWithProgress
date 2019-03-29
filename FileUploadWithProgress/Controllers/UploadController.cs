using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace WebAppUpload1.Controllers
{
    public class UploadController : ApiController
    {
        // POST api/upload
        public void Post()
        {
            HttpRequest request = HttpContext.Current.Request;
            string filename = request.Form["filename"];
            HttpPostedFile thefile = request.Files[0];
            string path = Path.Combine(HttpContext.Current.Server.MapPath("~/UploadedFiles"), filename);
            thefile.SaveAs(path);
        }
    }
}
