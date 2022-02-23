using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HighScoreManager : MonoBehaviour
{
    public static HighScoreManager Instance;

    public int newHighScore;
    public string newScoreName;

    public int highScore1;
    public int highScore2;
    public int highScore3;
    public int highScore4;
    public int highScore5;
    public int highScore6;
    public int highScore7;
    public int highScore8;
    public int highScore9;
    public int highScore10;

    public string ScoreName1;
    public string ScoreName2;
    public string ScoreName3;
    public string ScoreName4;
    public string ScoreName5;
    public string ScoreName6;
    public string ScoreName7;
    public string ScoreName8;
    public string ScoreName9;
    public string ScoreName10;

    void Awake()
    {
        if (Instance != null)
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
    }


    

    public void highScore()
    {
        if (newHighScore > highScore1)
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
        else if (newHighScore > highScore2)
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
