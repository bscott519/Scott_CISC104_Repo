using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BBallManager : MonoBehaviour

{
    private Player1 player1;
    private Player2 player2;

    public GameObject player1MakeCount;
    public GameObject player2MakeCount;
    public GameObject winnerTextObject;

    private TextMeshProUGUI player1ScoreText;
    private TextMeshProUGUI player2ScoreText;
    private TextMeshProUGUI winnerText;

    void Start()
    {
        player1 = new Player1();
        player2 = new Player2();

        player1ScoreText = player1MakeCount.GetComponent<TextMeshProUGUI>();
        player2ScoreText = player2MakeCount.GetComponent<TextMeshProUGUI>();
        winnerText = winnerTextObject.GetComponent<TextMeshProUGUI>();

    }

    void Update()
    {
        player1ScoreText.text = "Player 1 Score: " + player1.MadeShots.ToString();
        player2ScoreText.text = "Player 2 Score: " + player2.MadeShots.ToString();

        if (player1.MadeShots == 10)
        {
            winnerText.text = "Winner: Player 1 Wins!";
        }

        if (player2.MadeShots == 10)
        {
            winnerText.text = "Winner: Player 2 Wins!";
        }
    }

    public void Player1ShootsButton()
    {
        if (player1.MakeShot()) player1.MadeShots++;
    }

    public void Player2ShootsButton()
    {
        if (player2.MakeShot()) player2.MadeShots++;
    }

    public void Player1ContestsPlayer2()
    {
        player1.ContestPlayer2(player2);
    }

    public void Player2ContestsPlayer1()
    {
        player2.ContestPlayer1(player1);
    }

}
