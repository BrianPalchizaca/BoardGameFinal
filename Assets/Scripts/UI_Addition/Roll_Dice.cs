using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roll_Dice : MonoBehaviour
{
    public GameObject View_Map;
    public GameObject Show_Cards;
    public GameObject RollDice;
    public GameObject move;

    public void Start()
    {
        move.SetActive(false);
    }
    public void Roll()
    {
        RollDice.SetActive(false);
        View_Map.SetActive(false);
        Show_Cards.SetActive(false);
        move.SetActive(true);
    }
}
