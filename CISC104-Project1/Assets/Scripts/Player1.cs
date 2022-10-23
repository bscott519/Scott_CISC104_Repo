using System;

public class Player1
{
    private int naturalMakeRate = 45;
    private int amountOfContest = 0;

    public int MadeShots { get; set; }

    private bool ContestedSomeone = false;

    public Player1()
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

    public void ContestPlayer2(Player2 player2)
    {
        if (!ContestedSomeone)
        {
           player2.GetContested(40);
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
