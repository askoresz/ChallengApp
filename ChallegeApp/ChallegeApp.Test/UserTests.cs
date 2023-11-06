using NUnit.Framework;
using System.Reflection.Metadata;
namespace ChallegeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenUserCollectTwoScores_ShouldCorrectResult()
        {
            // arrange-output
            var user = new User("Andrzej", "Password");
            user.AddScore (5);
            user.AddScore(10);



            // act-Share
            var result = user.ResultPoint;

            //assert-text result examination

            Assert.AreEqual(15, result);
        }
        [Test]
        public void WhenUserCollectScores_ShouldCorrectResult()
        {
            //arrange -examining the test result
            var user = new User ("Andrzej", "Password");
            user.AddScore (5);
            user.AddScore(10);
            user.AddScore(-6);

            //act-Share
            var result = user.ResultPoint;

            //assert-text result examination
            Assert.AreEqual(0, result);

        }
        [Test]
        public void WhenUserCollectScores_ShouldCorrectZero()
        {
            //arrange-examining the test result
            var user = new User("Andrzej", "Password");
            user.AddScore (5);
            user.AddScore (10);
            user.AddScore(-8);

            //act-Share
            var result = user.ResultPoint;
            //assert-banie wyniku testu
            Assert.AreEqual(0, result);
        }
}   }   



        