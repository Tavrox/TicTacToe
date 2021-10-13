using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject Grid;
    public GameObject Welcome;
    public GameObject Victory;

    public enum Turns
    {
        None = 0,
        PlayerOne = 1,
        PlayerTwo = 2
    };
    public Turns Turn;
    public List<int> savePlayerOne = new List<int>();
    public List<int> savePlayerTwo = new List<int>();

    void Start()
    {
        Turn = Turns.PlayerOne;
        Grid.gameObject.SetActive(false);
        Victory.gameObject.SetActive(false);
    }

    public void displayGrid()
    {
        Grid.gameObject.SetActive(true);
        Welcome.gameObject.SetActive(false);
    }

    public void changeTurn(int _id)
    {
        if (Turn == Turns.PlayerOne)
        {
            Turn = Turns.PlayerTwo;
            savePlayerOne.Add(_id);
        }
        else if (Turn == Turns.PlayerTwo)
        {
            Turn = Turns.PlayerOne;
            savePlayerTwo.Add(_id);
        }
        checkVictory();
    }

    void checkVictory()
    {

        // On check les diagonales
        if (savePlayerOne.Contains(1) && savePlayerOne.Contains(5) && savePlayerOne.Contains(9))
        {
            triggerVictory();
        }
        else if (savePlayerOne.Contains(3) && savePlayerOne.Contains(5) && savePlayerOne.Contains(7))
        {
            triggerVictory();
        }

        // On check les lignes
        else if (savePlayerOne.Contains(1) && savePlayerOne.Contains(2) && savePlayerOne.Contains(3))
        {
            triggerVictory();
        }
        else if (savePlayerOne.Contains(4) && savePlayerOne.Contains(5) && savePlayerOne.Contains(6))
        {
            triggerVictory();
        }
        else if (savePlayerOne.Contains(7) && savePlayerOne.Contains(8) && savePlayerOne.Contains(9))
        {
            triggerVictory();
        }
        // On check les colonnes
        else if (savePlayerOne.Contains(1) && savePlayerOne.Contains(4) && savePlayerOne.Contains(7))
        {
            triggerVictory();
        }
        else if (savePlayerOne.Contains(2) && savePlayerOne.Contains(5) && savePlayerOne.Contains(8))
        {
            triggerVictory();
        }
        else if (savePlayerOne.Contains(3) && savePlayerOne.Contains(6) && savePlayerOne.Contains(9))
        {
            triggerVictory();
        }

    }

    void triggerVictory()
    {
        Debug.Log("Victoire Diagonale Player One");
        Grid.gameObject.SetActive(false);
        Victory.gameObject.SetActive(true);

    }
}
