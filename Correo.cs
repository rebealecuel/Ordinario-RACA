using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Ordinario_RACA
{
    internal class Correo
    {
        public void EnviarCorreo(string error) 
        {
            try
            {
                MailMessage mensaje = new MailMessage();
                mensaje.From = new MailAddress("112969@alumnouninter.mx");
                mensaje.To.Add("");
                mensaje.Subject = "Error catastrofico en en sistema";
                mensaje.Body = $"Se produjo en siguente error: \n\n{error}";
                mensaje.IsBodyHtml = false;

                SmtpClient smtp = new SmtpClient("smtp.office365.com", 587);
                smtp.Credentials = new NetworkCredential("112969@alumnouninter.mx", "Rebelalobafeliz654321");
                smtp.EnableSsl = true;

                smtp.Send(mensaje);
            }
            catch (Exception ex) 
            {
                throw new Exception("Error al enviar el correo: " + ex.Message, ex);
            }
        }
    }
}
