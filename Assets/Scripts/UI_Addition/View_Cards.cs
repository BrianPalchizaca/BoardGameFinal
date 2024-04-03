using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cards : MonoBehaviour
{
    //[SerializeField] private bool useCrads = false;
    public GameObject View_Map;
    public GameObject Show_Cards;
    public GameObject Roll_Dice;
    public GameObject Go_Back;
    public GameObject Go_Back2;
    public GameObject Cards1;
    public GameObject Cards2;
    public GameObject move;

    private void Start()
    {
        Roll_Dice.SetActive(true);
        View_Map.SetActive(true);
        Show_Cards.SetActive(true);
        Go_Back.SetActive(false);
        Go_Back2.SetActive(false);
        Cards1.SetActive(false);
        Cards2.SetActive(false);
        move.SetActive(false);
    }


    public void ViewCards()
    {
        Roll_Dice.SetActive(false);
        View_Map.SetActive(false);
        Show_Cards.SetActive(false);
        Go_Back2.SetActive(true);
        Cards1.SetActive(true);
        Cards2.SetActive(true);
    }

    public void GoBack()
    {
        Roll_Dice.SetActive(true);
        View_Map.SetActive(true);
        Show_Cards.SetActive(true);

        Go_Back2.SetActive(false);
        Cards1.SetActive(false);
        Cards2.SetActive(false);
    }
}
