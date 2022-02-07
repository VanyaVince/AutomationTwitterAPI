using OpenQA.Selenium;

namespace Twitter
{
    public class LoginPage
    {
        private Button _sighInButton => new Button(By.XPath("//a[@href='/login']//div"));
        private Button _nextButton => new Button(By.XPath("//div[@role='button']//span[text()='Next']"));
        private Button _loginButton => new Button(By.XPath("//span[text()='Log in']"));
        private TextBox _loginField => new TextBox(By.XPath("//input[@name='text']"));
        private TextBox _passwordField => new TextBox(By.XPath("//input[@name='password']"));
        private TextBox _phoneOrUsernameField => new TextBox(By.XPath("//input[@data-testid]"));

        public void ClickOnSighInButton()
        {
            _sighInButton.Click();
        }

        public void EnterValueIntoLoginField(string login)
        {
            _loginField.SetText(login);
        }

        public void EnterValueIntoPhoneOrUsernameField(string phoneValue)
        {
            _phoneOrUsernameField.SetText(phoneValue);
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
