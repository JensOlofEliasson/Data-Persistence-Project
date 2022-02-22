using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEngine.UI;
using TMPro;

public class MenuManager : MonoBehaviour
{
    public static MenuManager Instance;

    public int newHighScore;
    public string newHighScoreName;
    public TextMeshProUGUI highScoreName1;
    public TextMeshProUGUI highScoreNumber1;
    public TextMeshProUGUI highScoreName2;
    public TextMeshProUGUI highScoreNumber2;
    public TextMeshProUGUI highScoreName3;
    public TextMeshProUGUI highScoreNumber3;
    public TextMeshProUGUI highScoreName4;
    public TextMeshProUGUI highScoreNumber4;
    public TextMeshProUGUI highScoreName5;
    public TextMeshProUGUI highScoreNumber5;
    public TextMeshProUGUI highScoreName6;
    public TextMeshProUGUI highScoreNumber6;
    public TextMeshProUGUI highScoreName7;
    public TextMeshProUGUI highScoreNumber7;
    public TextMeshProUGUI highScoreName8;
    public TextMeshProUGUI highScoreNumber8;
    public TextMeshProUGUI highScoreName9;
    public TextMeshProUGUI highScoreNumber9;
    public TextMeshProUGUI highScoreName10;
    public TextMeshProUGUI highScoreNumber10;

    int highScore1;
    int highScore2;
    int highScore3;
    int highScore4;
    int highScore5;
    int highScore6;
    int highScore7;
    int highScore8;
    int highScore9;
    int highScore10;

    void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);

    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        EditorApplication.ExitPlaymode();
        Application.Quit();
    }

    public void highScore()
    {
        if(newHighScore > highScore1)
        {
            highScoreName1.text = newHighScoreName;
            highScoreNumber1.text = ("" + newHighScore);
        }
    }
}
