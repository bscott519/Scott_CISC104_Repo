using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UnoGame : MonoBehaviour
{
    public Cards[] cards;
    public RawImage currentCardImage;
    private int currentCardIndex;
    public GameObject cardTextGameObject;
    private TextMeshProUGUI cardText;

    public GameObject winnerTextObject;

    private TextMeshProUGUI winnerText;


    void Start()
    {
        currentCardIndex = 0;
        cardText = cardTextGameObject.GetComponent<TextMeshProUGUI>();
        SetImage();

        winnerText = winnerTextObject.GetComponent<TextMeshProUGUI>();
    }

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
        SetImage();
    }

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
        SetImage();
    }
    
    private void SetImage()
    {
        cardText.text = cards[currentCardIndex].CardName;

        if (cards[currentCardIndex].cardImage != null)
        {
            currentCardImage.texture = cards[currentCardIndex].cardImage.texture;
        }
        else
        {
            currentCardImage.texture = null;
        }
    }

    void Update()
    {
        winnerText.text = "Player #1 Wins!";
    }

    public void PlayButton()
    {
        
    }

    public void DrawButton()
    {
        currentCardIndex++;
    }

    public void RestartButton()
    {
        currentCardIndex = 0;
    }
}
