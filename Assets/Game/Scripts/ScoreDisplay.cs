using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreDisplay : MonoBehaviour
{

    [SerializeField] private Text ScoreUI;

    private void Start()
    {
        MainCharacter.OnScoreUpdated += ShowScore;
    }

    private void ShowScore(int value)
    {
        ScoreUI.text = value.ToString();
    }
}
