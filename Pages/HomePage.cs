using OpenQA.Selenium;

namespace Twitter
{
    public class HomePage : BasePage
    {
        private Button ProfileButton => new Button(By.XPath("//a[@aria-label='Profile']"));

        public void ClickOnProfileButton()
        {
            ProfileButton.Click();
        }
    }
}
