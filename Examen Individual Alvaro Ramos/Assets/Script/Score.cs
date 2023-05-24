using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    private int score;

    private void Start()
    {
        
        UpdateScoreText();
    }

    public void UpdateScoreText()
    {
        textComponent.text = "Score: " + score;
    }

    public void IncrementScore(int amount)
    {
        score += amount;
        UpdateScoreText();
    }

}
