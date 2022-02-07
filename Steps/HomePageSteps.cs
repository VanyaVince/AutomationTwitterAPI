namespace Twitter
{
    public class HomePageSteps
    {
        private readonly HomePage _homePage;

        public HomePageSteps()
        {
            _homePage = new HomePage();
        }

        public void ProceedToProfilePage()
        {
            _homePage.ClickOnProfileButton();
        }
    }
}
