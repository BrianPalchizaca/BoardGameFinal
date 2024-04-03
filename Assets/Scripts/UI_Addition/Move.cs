using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public GameObject View_Map;
    public GameObject Show_Cards;
    public GameObject RollDice;
    public GameObject move;

    public void Bmove()
    {
        RollDice.SetActive(true);
        View_Map.SetActive(true);
        Show_Cards.SetActive(true);
        move.SetActive(false);
    }
}
