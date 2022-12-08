using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Random=UnityEngine.Random;


// What needs to be done?
// Add a UI with 2 buttons, one for playing a round, and one for starting/restarting a game
// A title text object, a status text object to display who won the last round, and 2 text objects to show the won card counts of the cpu and user
// Add a counter throughout the code that will keep track of the user and cpu won stack count


public class WarGameController : MonoBehaviour
{
    public Stack<int> dealingStack = new Stack<int>();      // Stack to hold cards that will be shuffled and dealt
    public Stack<int> userDealt = new Stack<int>();         // Stack to hold the cards dealt to the user
    public Stack<int> userWon = new Stack<int>();           // Stack to hold the cards won by the user
    public Stack<int> computerDealt = new Stack<int>();     // Stack to hold the cards dealt to the computer
    public Stack<int> computerWon = new Stack<int>();       // Stack to hold the cards won by the computer

    public int userWonCount;
    public int computerWonCount;

    public GameObject titleTextObject; // Text Object for Title
    public GameObject statusTextObject; // Text Object for the Status of the game
    public GameObject computerWonTextObject; // Text Object for the Computer Won Count
    public GameObject userWonTextObject; // Text Object for the User Won Count
    public GameObject winnerTextObject; // Text Object for the Winner


    private TextMeshProUGUI titleText; // Text for Title
    private TextMeshProUGUI statusText; // Text for the Status of the game
    private TextMeshProUGUI computerWonText; // Text for the Computer Won Count
    private TextMeshProUGUI userWonText; // Text for the User Won Count
    private TextMeshProUGUI winnerText; // Text for the Winner


    public Button startButton; // Button to start the game
    public Button playButton; // Button to play the game

    // Start is called before the first frame update
    void Start()
    {
        // Lock buttons except start button
        // Set default text
        titleText = titleTextObject.GetComponent<TextMeshProUGUI>();
        statusText = statusTextObject.GetComponent<TextMeshProUGUI>();
        computerWonText = computerWonTextObject.GetComponent<TextMeshProUGUI>();
        userWonText = userWonTextObject.GetComponent<TextMeshProUGUI>();
        winnerText = winnerTextObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        // update counters text objects in here
        computerWonText.text = "Computer Won Count: " + computerWonCount.ToString();
        userWonText.text = "User Won Count: " + userWonCount.ToString();
    }

    // Start Button triggers pressedStartGame
    public void StartButton()
    {
        pressedStartGame();
    }

    // Play Button triggers playRound
    public void PlayButton()
    {
        playRound();
    }

    // Start Game (Start Game Button Pressed)
    public void pressedStartGame()
    {
        // Clear Decks and start/restart the game
        while (userDealt.Count != 0 || userWon.Count != 0 || computerDealt.Count != 0 || computerWon.Count != 0)
        {
            userDealt.Pop();
            userWon.Pop();
            computerDealt.Pop();
            computerWon.Pop();
        }
        // Reset status text to default, reset counters to default 0
        dealCards();    // Restart the deal cards
    }

    // Fill orignal stack with "cards"
    private void dealCards() 
    {
        // Fill the original deck with numbers
        for (int i = 0; i < 54; i++)
        {
            dealingStack.Push(i);
        }

        shuffleCards(); // Function to shuffle a stack

        // Deal cards starting with computer
        for (int d = 0; d < dealingStack.Count; d++)
        {
            computerDealt.Push(dealingStack.Pop());
            userDealt.Push(dealingStack.Pop());
        }
        // Disable the start button and enable the play round button
    }

    // Shuffles the int values of a stack
    private void shuffleCards()
    {
        System.Random rand = new System.Random();   // Generate random number for shuffling

        int[] shuffleCopy = dealingStack.ToArray(); // Array to shuffle cards

        int i = shuffleCopy.Length;                 // Int to hold the length of array

        // Clear the og stack
        while (dealingStack.Count > 1)
        {
            dealingStack.Pop();
        }

        // Shuffle the array until its empty
        while (i > 1)
        {
            // Index wizarding
            int n = rand.Next(i--);
            int temp = shuffleCopy[i];
            shuffleCopy[i] = shuffleCopy[n];
            shuffleCopy[n] = temp;
        }
        
        // Fill the stack with shuffled int
        for (int l = 0; l < 54; l++)
        {
            dealingStack.Push(shuffleCopy[l]);
        }

        Array.Clear(shuffleCopy, 0, shuffleCopy.Length);
    }

    // Play Round (Play button pressed)
    public void playRound()
    {
        checkCards();
    }

    // Checks Cards (Game Logic)
    private void checkCards()
    {
        if (userDealt.Count == 0)   // If all cards have been played by the user
        {
            // Disable play button
            // Enable the start game button
            // Check to see who won
            if (userWon.Count > computerWon.Count)  // User won
            {
                // Set winner text object to say user won with x amount of cards
                winnerText.text = "Winner: User won with " + userWonCount + " cards!".ToString();
            } else 
            {
                // Set winner text object to say computer won with x amount of cards
                winnerText.text = "Winner: Computer won with " + computerWonCount + " cards!".ToString();
            }
        } else 
        {
            if (userDealt.Peek() > computerDealt.Peek())    // User won the hand
            {
                userWon.Push(userDealt.Pop());
                userWon.Push(computerDealt.Pop());
                // update status text to say user won round
                statusText.text = "User won the round!".ToString();
                userWonCount++;
                // update text for user won counter
            } else                                          // Computer won the hand
            {
                computerWon.Push(computerDealt.Pop());
                computerWon.Push(userDealt.Pop());
                // update status text to say cpu won round
                statusText.text = "Computer won the round!".ToString();
                computerWonCount++;
                // update text for cpu won counter
            }
        }
    }
}
