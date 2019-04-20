namespace TCC.ApplicationCore.Entity
{
    public class EmailConfig
    {
        public string CredentialUserName { get; set; }
        public string CredentialPassword { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string SmtpClient { get; set; }
        public int PortSSL { get; set; }
    }
}
