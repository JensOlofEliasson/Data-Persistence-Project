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
    public string newScoreName;

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

    public int highScore1;
    int highScore2;
    int highScore3;
    int highScore4;
    int highScore5;
    int highScore6;
    int highScore7;
    int highScore8;
    int highScore9;
    public int highScore10;

    public string ScoreName1;
    string ScoreName2;
    string ScoreName3;
    string ScoreName4;
    string ScoreName5;
    string ScoreName6;
    string ScoreName7;
    string ScoreName8;
    string ScoreName9;
    string ScoreName10;

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

    private void Start()
    {
        highScore();

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

    void NameAndScoreToTMP()
    {
        highScoreName1.text = ScoreName1;
        highScoreNumber1.text = ("" + highScore1);
        highScoreName2.text = ScoreName1;
        highScoreNumber1.text = ("" + highScore2);
        highScoreName3.text = ScoreName1;
        highScoreNumber1.text = ("" + highScore3);
        highScoreName4.text = ScoreName1;
        highScoreNumber1.text = ("" + highScore4);
        highScoreName5.text = ScoreName1;
        highScoreNumber1.text = ("" + highScore5);
        highScoreName6.text = ScoreName1;
        highScoreNumber1.text = ("" + highScore6);
        highScoreName7.text = ScoreName1;
        highScoreNumber1.text = ("" + highScore7);
        highScoreName8.text = ScoreName1;
        highScoreNumber1.text = ("" + highScore8);
        highScoreName9.text = ScoreName1;
        highScoreNumber1.text = ("" + highScore9);
        highScoreName10.text = ScoreName1;
        highScoreNumber1.text = ("" + highScore10);
    }

    public void highScore()
    {
        if(newHighScore > highScore1)
        {
            highScore10 = highScore9;
            highScore9 = highScore8;
            highScore8 = highScore7;
            highScore7 = highScore6;
            highScore6 = highScore5;
            highScore5 = highScore4;
            highScore4 = highScore3;
            highScore3 = highScore2;
            highScore2 = highScore1;
            highScore1 = newHighScore;

            ScoreName10 = ScoreName9;
            ScoreName9 = ScoreName8;
            ScoreName8 = ScoreName7;
            ScoreName7 = ScoreName6;
            ScoreName6 = ScoreName5;
            ScoreName5 = ScoreName4;
            ScoreName4 = ScoreName3;
            ScoreName3 = ScoreName2;
            ScoreName2 = ScoreName1;
            ScoreName1 = newScoreName;
        }
        else if(newHighScore > highScore2)
        {
            highScore10 = highScore9;
            highScore9 = highScore8;
            highScore8 = highScore7;
            highScore7 = highScore6;
            highScore6 = highScore5;
            highScore5 = highScore4;
            highScore4 = highScore3;
            highScore3 = highScore2;
            highScore2 = newHighScore;

            ScoreName10 = ScoreName9;
            ScoreName9 = ScoreName8;
            ScoreName8 = ScoreName7;
            ScoreName7 = ScoreName6;
            ScoreName6 = ScoreName5;
            ScoreName5 = ScoreName4;
            ScoreName4 = ScoreName3;
            ScoreName3 = ScoreName2;
            ScoreName2 = newScoreName;
        }
        else if (newHighScore > highScore3)
        {
            highScore10 = highScore9;
            highScore9 = highScore8;
            highScore8 = highScore7;
            highScore7 = highScore6;
            highScore6 = highScore5;
            highScore5 = highScore4;
            highScore4 = highScore3;
            highScore3 = newHighScore;

            ScoreName10 = ScoreName9;
            ScoreName9 = ScoreName8;
            ScoreName8 = ScoreName7;
            ScoreName7 = ScoreName6;
            ScoreName6 = ScoreName5;
            ScoreName5 = ScoreName4;
            ScoreName4 = ScoreName3;
            ScoreName3 = newScoreName;
        }
        else if (newHighScore > highScore4)
        {
            highScore10 = highScore9;
            highScore9 = highScore8;
            highScore8 = highScore7;
            highScore7 = highScore6;
            highScore6 = highScore5;
            highScore5 = highScore4;
            highScore4 = newHighScore;

            ScoreName10 = ScoreName9;
            ScoreName9 = ScoreName8;
            ScoreName8 = ScoreName7;
            ScoreName7 = ScoreName6;
            ScoreName6 = ScoreName5;
            ScoreName5 = ScoreName4;
            ScoreName4 = newScoreName;
        }
        else if (newHighScore > highScore5)
        {
            highScore10 = highScore9;
            highScore9 = highScore8;
            highScore8 = highScore7;
            highScore7 = highScore6;
            highScore6 = highScore5;
            highScore5 = newHighScore;

            ScoreName10 = ScoreName9;
            ScoreName9 = ScoreName8;
            ScoreName8 = ScoreName7;
            ScoreName7 = ScoreName6;
            ScoreName6 = ScoreName5;
            ScoreName5 = newScoreName;
        }
        else if (newHighScore > highScore6)
        {
            highScore10 = highScore9;
            highScore9 = highScore8;
            highScore8 = highScore7;
            highScore7 = highScore6;
            highScore6 = newHighScore;

            ScoreName10 = ScoreName9;
            ScoreName9 = ScoreName8;
            ScoreName8 = ScoreName7;
            ScoreName7 = ScoreName6;
            ScoreName6 = newScoreName;
        }
        else if (newHighScore > highScore7)
        {
            highScore10 = highScore9;
            highScore9 = highScore8;
            highScore8 = highScore7;
            highScore7 = newHighScore;

            ScoreName10 = ScoreName9;
            ScoreName9 = ScoreName8;
            ScoreName8 = ScoreName7;
            ScoreName7 = newScoreName;
        }
        else if (newHighScore > highScore8)
        {
            highScore10 = highScore9;
            highScore9 = highScore8;
            highScore8 = newHighScore;

            ScoreName10 = ScoreName9;
            ScoreName9 = ScoreName8;
            ScoreName8 = newScoreName;
        }
        else if (newHighScore > highScore9)
        {
            highScore10 = highScore9;
            highScore9 = newHighScore;

            ScoreName10 = ScoreName9;
            ScoreName9 = newScoreName;
        }
        else if (newHighScore > highScore10)
        {
            highScore10 = newHighScore;

            ScoreName10 = newScoreName;
        }
        
    }
}
