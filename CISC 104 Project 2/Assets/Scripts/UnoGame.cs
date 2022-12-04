using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UnoGame : MonoBehaviour
{
    public Cards[] cards;
    private int currentCardIndex;
    public GameObject cardTextGameObject;
    private TextMeshProUGUI cardText;

    void Start()
    {
        currentCardIndex = 0;
        cardText = cardTextGameObject.GetComponent<TextMeshProUGUI>();

    }

    void PreviousCard()
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

    void NextCard()
    {
        if (currentCardIndex == 0)
        {
            currentCardIndex = cards.Length - 1;
        }
        else
        {
            currentCardIndex++;
        }

    }
}
