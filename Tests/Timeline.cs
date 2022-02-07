using NUnit.Framework;

namespace Twitter.Tests
{
    public class Timeline : BaseTest
    {
        private string login = "vanyavince@gmail.com";
        private string password = "Tarakan!0508";
        private string phone = "+375293539222";
        
        private string urlSendTweetAPI = "https://api.twitter.com/1.1/statuses/update.json";
        private string message = SystemHelper.GetRandomValue();
        private TwitterAPI _twitterAPI;

        [SetUp]
        public override void Setup()
        {
            _twitterAPI = new TwitterAPI(urlSendTweetAPI);
            _twitterAPI.SendTweet(message);
            OpenUrl();
        }

        [Test]
        public void VerifyTweetPostedAfterApiRequest()
        {
            LoginPageSteps.Login(login, phone, password);
            HomePageSteps.ProceedToProfilePage();

            Assert.IsTrue(ProfilePageSteps.IsTweetDisplayed(message));
        }
    }
}
