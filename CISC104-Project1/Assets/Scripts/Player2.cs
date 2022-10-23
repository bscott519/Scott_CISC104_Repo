using System;

public class Player2
{
    private int naturalMakeRate = 40;
    private int amountOfContest = 0;

    public int MadeShots { get; set; }

    private bool ContestedSomeone = false;

    public Player2()
    {
    }

    public bool MakeShot()
    {
        Random rng = new Random();

        int success = rng.Next(100);

        if(success >= (naturalMakeRate + amountOfContest))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void ContestPlayer1(Player1 player1)
    {
        if (!ContestedSomeone)
        {
           player1.GetContested(40);
           ContestedSomeone = true;
        }
    }

    public void GetContested(int newAmountofContest)
    {
        amountOfContest = newAmountofContest;
    }

    public int GetScoreToWin()
    {
        return naturalMakeRate + amountOfContest;
    }
}
