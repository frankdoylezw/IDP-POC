namespace IDP_POC.PageObjects
{
    public interface ILoginPage
    {
        bool IncorrectPasswordMessagePresent();
        bool SuccessMessagePresent();
        void With(string signInName, string password);
    }
}