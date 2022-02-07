using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitter.Pages;

namespace Twitter.Steps
{
    public class LoginPageSteps
    {
        private readonly LoginPage _loginPage;

        public LoginPageSteps()
        {
            _loginPage = new LoginPage();
        }

        public void Login(string login, string password)
        {
            _loginPage.ClickOnSighInButton();
            _loginPage.EnterValueIntoLoginField(login);
            _loginPage.ClickOnNextButton();
            _loginPage.EnterValueIntoPasswordField(password);
            _loginPage.ClickOnLoginButton();
        }

    }
}
