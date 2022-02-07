using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Twitter.Tests
{
    public class Timeline : BaseTest
    {

        private string login = "vanyavince@gmail.com";
        private string password = "Tarakan!0508";

        [Test]
        public void VerifyTweetPostedAfterApiRequest()
        {
            //Thread.Sleep(7000);
            LoginPageSteps.Login(login, password);
            Thread.Sleep(7000);


        }
    }
}
