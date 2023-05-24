using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonManager : MonoBehaviour
{
    public int scoreIncrement;
    public Score scoreText;

    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(IncrementScore);
    }

    private void IncrementScore()
    {
        scoreText.IncrementScore(scoreIncrement);
    }


}
