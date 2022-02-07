using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarkov.ElementWrapper;

namespace Twitter.Pages
{
    public class LoginPage
    {
        private Button _sighInButton => new Button(By.XPath("//a[@href='/login']//div"));
        private Button _nextButton => new Button(By.XPath("//div[@role='button']//span[text()='Next']"));
        private Button _loginButton => new Button(By.XPath("//span[text()='Log in']"));
        private TextBox _loginField => new TextBox(By.XPath("//input[@name='text']"));
        private TextBox _passwordField => new TextBox(By.XPath("//input[@name='password']"));

        public void ClickOnSighInButton()
        {
            _sighInButton.Click();
        }

        public void EnterValueIntoLoginField(string login)
        {
            _loginField.SetText(login);
        }

        public void EnterValueIntoPasswordField(string password)
        {
            _passwordField.SetText(password);
        }

        public void ClickOnNextButton()
        {
            _nextButton.Click();
        }

        public void ClickOnLoginButton()
        {
            _loginButton.Click();
        }
    }
}
