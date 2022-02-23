using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using TMPro;

public class MenuManager : MonoBehaviour
{
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

    private void Start()
    {
        NameAndScoreToTMP();
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

    public void NameAndScoreToTMP()
    {
        highScoreName1.text = HighScoreManager.Instance.ScoreName1;
        highScoreNumber1.text = ("" + HighScoreManager.Instance.highScore1);
        highScoreName2.text = HighScoreManager.Instance.ScoreName2;
        highScoreNumber1.text = ("" + HighScoreManager.Instance.highScore2);
        highScoreName3.text = HighScoreManager.Instance.ScoreName3;
        highScoreNumber1.text = ("" + HighScoreManager.Instance.highScore3);
        highScoreName4.text = HighScoreManager.Instance.ScoreName4;
        highScoreNumber1.text = ("" + HighScoreManager.Instance.highScore4);
        highScoreName5.text = HighScoreManager.Instance.ScoreName5;
        highScoreNumber1.text = ("" + HighScoreManager.Instance.highScore5);
        highScoreName6.text = HighScoreManager.Instance.ScoreName6;
        highScoreNumber1.text = ("" + HighScoreManager.Instance.highScore6);
        highScoreName7.text = HighScoreManager.Instance.ScoreName7;
        highScoreNumber1.text = ("" + HighScoreManager.Instance.highScore7);
        highScoreName8.text = HighScoreManager.Instance.ScoreName8;
        highScoreNumber1.text = ("" + HighScoreManager.Instance.highScore8);
        highScoreName9.text = HighScoreManager.Instance.ScoreName9;
        highScoreNumber1.text = ("" + HighScoreManager.Instance.highScore9);
        highScoreName10.text = HighScoreManager.Instance.ScoreName10;
        highScoreNumber1.text = ("" + HighScoreManager.Instance.highScore10);
    }
}
