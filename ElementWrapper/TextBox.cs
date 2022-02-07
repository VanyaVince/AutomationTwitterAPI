using OpenQA.Selenium;

namespace Twitter
{
    public class TextBox : BaseElement
    {
        public TextBox(By locator) : base(locator)
        {
        }

        public void SetText(string value) 
        {
            WaitForElementToBeExisted();
            WaitForElementToBeVisible();

            Element.SendKeys(value);
        }
    }
}
