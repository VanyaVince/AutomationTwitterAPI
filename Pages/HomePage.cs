using OpenQA.Selenium;
using Tarkov.ElementWrapper;

namespace Tarkov.Pages
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
