using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UnoGame : MonoBehaviour
{
    public Cards[] cards;

    public Cards[] userHand;
    public Cards[] computer1Hand;
    public Cards[] computer2Hand;
    public Cards[] usedCards;

    private int currentCardIndex;
    private int playerCardCount;
    private int c1CardCount;
    private int c2CardCount;

    public GameObject cardTextGameObject;
    private TextMeshProUGUI cardText;

    public GameObject winnerTextObject;
    private TextMeshProUGUI winnerText;


    // The inital setup (not the actual startbutton)
    void Start()
    {
        currentCardIndex = 0;
        cardText = cardTextGameObject.GetComponent<TextMeshProUGUI>();
        

        winnerText = winnerTextObject.GetComponent<TextMeshProUGUI>();
    }

    // Updated once a frame
    void Update()
    {
        winnerText.text = "Player #1 Wins!";
    }

    // cycles hand to the left 1
    // add a check for boundaries (!<0)
    public void PreviousCard()
    {
        if(currentCardIndex == 0)
        {
            currentCardIndex = cards.Length - 1;
        }
        else
        {
            currentCardIndex--;
        }
    }

    // cycles hand to the right 1
    // add a check for boundaries (length)
    public void NextCard()
    {
        if(currentCardIndex == 0)
        {
            currentCardIndex = cards.Length - 1;
        }
        else
        {
            currentCardIndex++;
        }
    }

    // Play a card
    public void PlayButton()
    {
        // remove card from user hand if you have a card to play
        // if no available card button is diabled
    }

    // Draw a card
    public void DrawButton()
    {
        // continue drawing card until either color or number match
        // disabled when you do have a card
        currentCardIndex++;
    }

    // Start And Restart Game
    public void RestartButton()
    {
        // Begins with text saying 'start', after pressed
        // Text changes to 'restart', allowing the user to restart at anypoint during the game and reset everything
        currentCardIndex = 0;
    }
}
