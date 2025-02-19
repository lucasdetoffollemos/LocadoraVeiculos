﻿using System;
using System.Net;
using System.Net.Mail;
using LocadoraVeiculos.netCore.Dominio.LocacaoModule;
using JsonFlatFileDataStore;

namespace LocadoraVeiculos.Infra.InternetServices.LocacaoModule
{
    public class NotificadorEmail : INotificadorEmail
    {
        public NotificadorEmail()
        {
        }
    
        public bool EnviarEmail(SolicitacaoEmail email)
        {
            try
            {
                using (SmtpClient smtp = new SmtpClient())
                {
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential("runtimeterror903@gmail.com", "Runtimeterror");

                    using (MailMessage mail = new MailMessage())
                    {
                        //de
                        mail.From = new MailAddress("runtimeterror903@gmail.com");

                        //para
                        mail.To.Add(new MailAddress(email.Locacao.Cliente.Email));

                        mail.Subject = "Locadora Rech: Devolução realizada com sucesso";

                        string corpoEmail = $"<h2><strong>Olá {email.Locacao.Cliente.Nome}!</strong></h2>" +
                            $"<br/><h3>Houve uma locação de veículo recentemente fechada em seu nome." +
                            $"<br/>Segue em anexo o recibo contendo os dados da locação.</h3>" +
                            $"<br/><br/>Agradecemos a preferência, volte sempre!" +
                            $"<br/><i>Locadora Rech</i>";

                        mail.Body = corpoEmail;

                        mail.IsBodyHtml = true;

                        if (email.CaminhoRecibo != null)
                            mail.Attachments.Add(new Attachment(email.CaminhoRecibo));

                        smtp.Send(mail);
                    }

                    email.EnvioPendente = false;

                    return true;
                }
            }
            catch (Exception ex)
            {
                ex.Data.Add("emailCliente", email.Locacao.Cliente.Email);
                return false;
            }
        }
    }
}
