using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net;
using Entidades.Documentos;
using System.IO;

namespace Utilitarios
{
    public class Email
    {

        #region atributos
        #endregion

        #region Métodos Públicos

        /// <summary>
        /// Envía el correo de la orden de compra
        /// </summary>
        public void EnviarCorreo(String pDireccion, Documento pDocumento, DocumentoDetalle pDetalle)
        {
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("patitoscr@gmail.com", "administrato");
            try
            {
                MailMessage msg = new MailMessage("patitosCR@gmail.com", pDireccion);
                msg.IsBodyHtml = true;
                string body = ReemplazarValores(new StreamReader("correoERP.html").ReadToEnd(), pDocumento, pDetalle);
                msg.Subject = "Orden de Compra: " + DateTime.Now.ToLongDateString();
                msg.Body = body;
                client.Send(msg);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
        #endregion

        #region Métodos Privados
        /// <summary>
        /// Crea el html del reporte
        /// </summary>
        /// <param name="pCuerpo">Borrador del html</param>
        /// <returns>html completo del reporte</returns>
  
        public string ReemplazarValores(string pCuerpo, Documento pDocumento, DocumentoDetalle pDetalle)
        {
            string fecha = System.DateTime.Now.ToString();
            string resumen = "Orden No: " + pDetalle.NumeroDocumento + System.Environment.NewLine + 
                             "Fecha de la orden: " + pDocumento.Fecha1 + System.Environment.NewLine + "Total: "+ pDocumento.TotalAI;
            string detalle = "<tr><td style=\"border:1px solid black\"> Artículo  </td> " + "<td style=\"border:1px solid black\">" + pDetalle.Descripcion + "</td></tr>" +
                "<tr><td style=\"border:1px solid black\"> Cantidad  </td> " + "<td style=\"border:1px solid black\">" + pDetalle.Cantidad + "</td></tr>" +
                "<tr><td style=\"border:1px solid black\"> Costo  </td> " + "<td style=\"border:1px solid black\">" + pDetalle.Precio + "</td></tr>";
            return string.Format(pCuerpo, fecha, resumen, detalle);
        }
        #endregion


    }
}
