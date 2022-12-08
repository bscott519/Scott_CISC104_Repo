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

    private int currentCardIndex;       // Index of the current card
    private int playerCardCount;        // Count of how many cards the user has in hand
    private int c1CardCount;            // Count of how many cards the computers have in hand
    private int c2CardCount;

    public Button previousCardButton;   // Button for the previous card
    public Button nextCardButton;       // Button for the next card
    public Button startButton;          // Button to start/restart the game
    public Button playCardButton;       // Button to play an eligible card
    public Button drawCardButton;       // Button to draw a card until you get a playable card

    public GameObject statusTextObject;         // Status Text to show the last card played
    public GameObject selectedCardTextObject;   // Preview the card eligble to play
    public GameObject computer1TextObject;      // Card count of computer 1 hand
    public GameObject computer2TextObject;      // Card count of computer 2 hand
    public GameObject userCountTextObject;      // User count of hand

    private TextMeshProUGUI statusText { get; set; }
    private TextMeshProUGUI selectedCardText { get; set; }
    private TextMeshProUGUI computer1Text { get; set;}
    private TextMeshProUGUI computer2Text {get; set;}
    private TextMeshProUGUI userCountText {get; set;}


    // The inital setup (not the actual startbutton)
    void Start()
    {
        currentCardIndex = 0;

        statusText = statusTextObject.GetComponent<TextMeshProUGUI>();
        selectedCardText = selectedCardTextObject.GetComponent<TextMeshProUGUI>();
        computer1Text = computer1TextObject.GetComponent<TextMeshProUGUI>();
        computer2Text = computer2TextObject.GetComponent<TextMeshProUGUI>();
        userCountText = userCountTextObject.GetComponent<TextMeshProUGUI>();

        //Disable all buttons but start button
    }

    // Updated once a frame
    // Needs to have the text be updated with the proper counts of user and cpu hands
    // Needs to have logic to check if a count has hit zero
    void Update()
    {
        
    }


    // called to deal out cards to each player (8)
    private void dealingPhase()
    {
        // For loop
        // Subtract 1 from each count out of the loop

    }

    // called to shuffle cards
    private void shuffleCards()
    {
        // For loop
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
            currentCardIndex = userHand.Length - 1;
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
            currentCardIndex = userHand.Length + 1;
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

        //disable after the card has been entered
        // also disable next and previous card
        string PlaceHolder = "";

        if (userHand == computer1Hand)
        {
            playerCardCount--;
        }
        else
        {
        }
    }

    // Draw a card
    public void DrawButton()
    {
        // continue drawing card until either color or number match
        // disabled when you do have a card
        string PlaceHolder = "";

        if (userHand != computer1Hand)
        {
        }
        else
        {
            playerCardCount++;
        }

        currentCardIndex++;

        //disable draw button after right match has been picked
    }

    // Start And Restart Game
    public void StartButton()
    {
        // Begins with text saying 'start', after pressed
        // Text changes to 'restart', allowing the user to restart at anypoint during the game and reset everything
        currentCardIndex = 0;

        // Set to 1 so program doesnt end prematurely
        playerCardCount = 1;
        c1CardCount = 1;
        c2CardCount = 1;

        shuffleCards(); // Shuffles Cards
        dealingPhase(); // Deals Cards

        // disable start button
    }
}