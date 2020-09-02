using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FtpDescargaArchivos
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDownload_Click(object sender, EventArgs e)
        {
            string fileName = archivo.Value;
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://107.180.46.193/httpdocs/FTPFiles/" + fileName);

            request.Method = WebRequestMethods.Ftp.DownloadFile;

            request.Credentials = new NetworkCredential("usuario", "password");

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            using(MemoryStream stream=new MemoryStream())
            {
                response.GetResponseStream().CopyTo(stream);
                Response.AddHeader("content-disposition", "attachment;filename=" + fileName);
                Response.Cache.SetCacheability(HttpCacheability.NoCache);
                Response.BinaryWrite(stream.ToArray());
                Response.End();
            }

        }
    }
}