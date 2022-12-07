using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum CardSuit
{
    // Base Cards
    RedZero, RedOne, RedTwo, RedThree, RedFour, RedFive, RedSix, RedSeven, RedEight, RedNine,
    BlueZero, BlueOne, BlueTwo, BlueThree, BlueFour, BlueFive, BlueSix, BlueSeven, BlueEight, BlueNine,
    YellowZero, YellowOne,  YellowTwo, YellowThree, YellowFour, YellowFive, YellowSix, YellowSeven, YellowEight, YellowNine,
    GreenZero, GreenOne, GreenTwo, GreenThree, GreenFour, GreenFive, GreenSix, GreenSeven, GreenEight, GreenNine,

    // Special Cards
    RedSkipTurn, BlueSkipTurn, YellowSkipTurn, GreenSkipTurn,
    RedMinus2, BlueMinus2, YellowMinus2, GreenMinus2,
    RedMinus4, BlueMinus4, YellowMinus4, GreenMinus4
}

public class Cards : MonoBehaviour
{
    public string CardName;     // Name
    public CardSuit cardSuit;   // Card
    public int value;           // Number
    public string color;        // Color
    public int specialFlag;     // 0 = nothing 1 = has skip/minus
}
