using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public int score;
    public Text[] scoreBoards;

    public void AddScore ()
    {
        score++;
        foreach (Text scoreBaord in scoreBoards)
        {
            scoreBaord.text = "Score: " + score;
        }
    }

}
