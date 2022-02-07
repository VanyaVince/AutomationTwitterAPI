using OpenQA.Selenium;

namespace Twitter
{
    public class ProfilePage : BasePage
    {
        private string tweetLocator = "//span[text()='{0}']";

        public bool IsTweetDisplayed(string tweetValue)
        {
            return new Element(By.XPath(string.Format(tweetLocator, tweetValue))).IsDisplayed();
        }
    }
}
