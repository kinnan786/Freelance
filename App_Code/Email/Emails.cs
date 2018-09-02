using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Net;

/// <summary>
/// Summary description for Emails
/// </summary>
public class Emails
{
    private MailMessage msgMail;
    private MailMessage myMessage;
    private SmtpClient mySmtpClient;
    private NetworkCredential myCredential;

	public Emails()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public void SendLoginAuthenticationEmail(string ToEmailAddress)
    {

        msgMail = new MailMessage();
        myMessage = new MailMessage();

        myMessage.From = new MailAddress("donotreply@work4sale.com", "Work4Sale.com");
        myMessage.To.Add(ToEmailAddress);
        myMessage.Subject = "Subject";
        myMessage.IsBodyHtml = false;
        myMessage.Body = "Message Body";

        mySmtpClient = new SmtpClient();
        NetworkCredential myCredential = new System.Net.NetworkCredential("donotreply@work4sale.com", "nabeel786");
        mySmtpClient.Host = "mail.work4sale.com";
        mySmtpClient.UseDefaultCredentials = false;
        mySmtpClient.Credentials = myCredential;
        mySmtpClient.ServicePoint.MaxIdleTime = 1;

        try
        {
            mySmtpClient.Send(myMessage);
            myMessage.Dispose();
        }
        catch (Exception ex)
        {
           // Label1.Text = ex.ToString();
        }
    }



}