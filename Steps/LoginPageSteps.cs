namespace Twitter
{
    public class LoginPageSteps
    {
        private readonly LoginPage _loginPage;

        public LoginPageSteps()
        {
            _loginPage = new LoginPage();
        }

        public void Login(string login, string phone, string password)
        {
            _loginPage.ClickOnSighInButton();
            _loginPage.EnterValueIntoLoginField(login);
            _loginPage.ClickOnNextButton();
            _loginPage.EnterValueIntoPhoneOrUsernameField(phone);
            _loginPage.ClickOnNextButton();
            _loginPage.EnterValueIntoPasswordField(password);
            _loginPage.ClickOnLoginButton();
        }

    }
}
