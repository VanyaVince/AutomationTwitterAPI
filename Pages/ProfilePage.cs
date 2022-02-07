//fusing OpenQA.Selenium;
//using Tarkov.Components;
//using Tarkov.ElementWrapper;

//namespace Tarkov.Pages
//{
//    public class HomePage : BasePage
//    {
//        private readonly Header _header = new Header();
//        private Button YouTubePlayButton => new Button(By.XPath("//button[@aria-label='Play']"));
//        private Button YouTubeContainerButton => new Button(By.XPath("//section[@id='banner_39_youtube']"));
//        private Button PreOderButton => new Button(By.XPath("//img[@class='preorder_button']"));
//        private Element YouTubeIframeDocument => new Element(By.XPath("//iframe[@id='VideoPlayer_39']"));
//        private Element YouTubeProgressBar => new Element(By.XPath("//div[@class='ytp-progress-bar']"));
//        private Element YouTubeScrubberIndicator => new Element(By.XPath("//div[@class='ytp-scrubber-container']"));

//        public void ClickOnYoutubeSection()
//        {
//            YouTubeContainerButton.Hover();
//            YouTubeContainerButton.Click();
//        }

//        public void ClickOnYouTubePlayButton()
//        {
//            YouTubePlayButton.Click();
//        }

//        public void ClickOnShowMenuOf(string item)
//        {
//            _header.ClickOnShowMenuOf(item);
//        }

//        public void SwitchToIframe()
//        {
//            DriverExtention.SwitchToIframe(YouTubeIframeDocument.GetElement());
//        }

//        public void ClickOnPreOrderImage()
//        {
//            PreOderButton.Click();
//        }

//        public string GetVideoTimeValue()
//        {
//            YouTubeScrubberIndicator.Hover();
//            return YouTubeProgressBar.GetElementAttribute("aria-valuenow");
//        }
//    }
//}
