using NUnit.Framework;
using System.Reflection.Metadata;

namespace ChallegeApp.Test


public class Tests
{
    [Test]
    public void WhenUserCollectTwoScores_ShouldCorrectResult()
    {
        // arrange
        var user = new User("Adam", "asddas324");
        user.AddScore(5);
        user.AddScore(6);
        //act
        var result = user.Result;
        // assert
        Assert.AreEqual(0, result);
    }
}