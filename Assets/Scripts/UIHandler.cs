using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIHandler : MonoBehaviour
{

    [SerializeField] TMP_Text scoreText;
    private int score = 0;
    private const int MAIN_SCENE = 1;

    public void OnPlayButtonClick()
    {
        SceneManager.LoadScene(MAIN_SCENE);
    }

    public void ScoreUpdate(int newScore)
    {
        score++;
        scoreText.text = newScore.ToString();
    }
}
