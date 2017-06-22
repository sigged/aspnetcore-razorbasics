namespace CoreCourse.RazorBasics.ViewModels
{
    public class HomeExpressionsVm
    {
        public string UserName { get; set; }
        public string UserPrimaryMail { get; set; }
        public string[] UserAllMail { get; set; }
        public int MaxAddresses { get; set; }
        public string MailDomain { get; set; }
        public string HtmlContent { get; set; }
    }
}
