namespace Twitter
{
    public class ProfilePageSteps
    {
        private readonly ProfilePage _profilePage;

        public ProfilePageSteps()
        {
            _profilePage = new ProfilePage();
        }

        public bool IsTweetDisplayed(string tweetValue)
        {
            return _profilePage.IsTweetDisplayed(tweetValue);
        }
    }
}
