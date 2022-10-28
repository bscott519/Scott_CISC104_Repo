using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class BBallTests
{
    [Test]
    public void BBallDefaultConstructorTest()
    {
        Player1 defaultPlayer1 = new Player1();
        Player2 defaultPlayer2 = new Player2();

        Assert.AreEqual(0, defaultPlayer1.MadeShots);
        Assert.AreEqual(0, defaultPlayer2.MadeShots);
        Assert.AreEqual(45, defaultPlayer1.GetScoreToWin());
        Assert.AreEqual(40, defaultPlayer2.GetScoreToWin());
    }

    [Test]
    public void Player1ScoresPointTest()
    {
        Player1 player1Scored = new Player1();
        int player1Count = 1;

        Assert.That(player1Count == 1);
    }

    [Test]
    public void Player2ContestsPlayer1()
    {
        Player1 newPlayer1 = new Player1();
        Player2 newPlayer2 = new Player2();
        int player1NaturalMakes = new Player1().GetScoreToWin();

        newPlayer2.ContestPlayer1(newPlayer1);

        Assert.AreEqual(player1NaturalMakes + 40, newPlayer1.GetScoreToWin());
    }
}
