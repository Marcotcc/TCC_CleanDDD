using System.ComponentModel.DataAnnotations;

namespace TCC.ApplicationCore.Entity
{
    public class EmailConfig
    {
        public EmailConfig()
        {

        }

        public int EmailConfigId { get; set; }

        public string CredentialUserName { get; set; }

        public string CredentialPassword { get; set; }

        [Display(Name = "Assunto")]
        public string Subject { get; set; }

        [Display(Name = "Body")]
        public string Body { get; set; }

        public string SmtpClient { get; set; }

        public int PortSSL { get; set; }
    }
}
