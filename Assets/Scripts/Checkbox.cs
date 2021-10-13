using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Checkbox : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler
{
    GameController Game;
    public string Marque;
    public Sprite Cross;
    public Sprite Circle;

    public int ID;

    public bool canClick = true;


    // Start is called before the first frame update
    void Start()
    {
        canClick = true;
        Game = FindObjectOfType<GameController>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (!canClick) return;
        canClick = false;

        if (Game.Turn == GameController.Turns.PlayerOne)
        {
            GetComponent<Image>().sprite = Cross;           
        }
        else if (Game.Turn == GameController.Turns.PlayerTwo)
        {
            GetComponent<Image>().sprite = Circle;
        }
        Game.changeTurn(ID);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Hover me");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
