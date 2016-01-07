using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace KennethCV.Controllers
{
    public class ContactController : Controller
    {

        //ATRIBUTOS DE CORREO
        private MailMessage datosCorreo = new MailMessage();
        private SmtpClient smtp = new SmtpClient();

        //
        // GET: /Contact/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /EnviarCorreo/
        public ActionResult SendMail()
        {
            return View();
        }

        //
        // POST: /Home/EviarCorreo
        [HttpPost]
        public ActionResult SendMail(string correoElectronico = "", string nombre = "", string asunto = "", string mensaje = "")
        {
            // TO ADD ES LA DIRECCION DONDE QUIERO QUE EL CORREO LLEGUE PUEDE SER GMAIL O HOTMAIL
            datosCorreo.To.Add(new MailAddress("progra.utn@gmail.com"));
            datosCorreo.From = new MailAddress(correoElectronico, nombre);
            datosCorreo.Subject = asunto;
            datosCorreo.Body = mensaje + "\n\n" + "Correo Electrónico: " + correoElectronico;

            smtp.Host = "smtp.gmail.com";
            //smtp.Host = "smtp.live.com";
            smtp.Port = 587;
            smtp.Credentials = new NetworkCredential("progra.utn@gmail.com", "pr12345678");
            smtp.EnableSsl = true;


            try
            {
                smtp.Send(datosCorreo);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return View();
            }


        }



    }
}
