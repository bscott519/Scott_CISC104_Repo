using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UnoGame : MonoBehaviour
{
    // Array that cards get shuffled and the cards get dealt and drawn out of
    public Cards[] dealingDeck;

    // Array to hold the hands for the user and computer, as well as a discard pile
    public Cards[] userHand;
    public Cards[] computer1Hand;
    public Cards[] computer2Hand;
    public Cards[] usedCards;

    private int currentCardIndex;   // Index of the current card
    private int playerCardCount;    // Count of how many cards the user has in hand
    private int c1CardCount;        // Count of how many cards the computers have in hand
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

    // called to deal out cards to each player (8)
    private void dealingPhase()
    {

    }

    // called to shuffle cards
    private void shuffleCards()
    {

    }

    // Follows same concept as user play and deal but in one function
    // Uses a flag to determine which computer player is actually being affected
    private void computerLogic()
    {

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
