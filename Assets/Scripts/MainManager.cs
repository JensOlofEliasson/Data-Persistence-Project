using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainManager : MonoBehaviour
{
    public Brick BrickPrefab;
    public int LineCount = 6;
    public Rigidbody Ball;

    public int brickLeft;

    public Text ScoreText;
    public Text highScoreText;
    public Text newHighScoreText;

    public Button playButton;
    public Button exitButton;

    public InputField inputName;
    public GameObject GameOverText;

    HighScoreManager HighScoreManager;

    private bool m_Started = false;
    private int m_Points;
    
    public bool m_GameOver = false;

    
    // Start is called before the first frame update
    void Start()
    {
        playButton.gameObject.SetActive(false);
        exitButton.gameObject.SetActive(false);
        newHighScoreText.gameObject.SetActive(false);
        inputName.gameObject.SetActive(false);
        highScoreText.text = "HIGH SCORE : " + HighScoreManager.Instance.ScoreName1 + " : " + HighScoreManager.Instance.highScore1;

        NewBricks();

    }

    private void Update()
    {
        if (!m_Started)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                m_Started = true;
                float randomDirection = Random.Range(-1.0f, 1.0f);
                Vector3 forceDir = new Vector3(randomDirection, 1, 0);
                forceDir.Normalize();

                Ball.transform.SetParent(null);
                Ball.AddForce(forceDir * 2.0f, ForceMode.VelocityChange);
            }
        }
        else if (m_GameOver)
        {
            //if (Input.GetKeyDown(KeyCode.Space))
            //{
                //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                //SceneManager.LoadScene(0);
            //}
        }
    }

    void AddPoint(int point)
    {
        m_Points += point * 100;
        ScoreText.text = $"Score : {m_Points}";
        brickLeft -= 1;
        //Debug.Log(brickLeft);
        if(brickLeft == 0)
        {
            NewBricks();
        }
    }

    public void GameOver()
    {
        m_GameOver = true;
        GameOverText.SetActive(true);
        if (m_Points > HighScoreManager.Instance.highScore10)
        {
            newHighScoreText.gameObject.SetActive(true);
            inputName.gameObject.SetActive(true);
        }
        else 
        {
            playButton.gameObject.SetActive(true);
            exitButton.gameObject.SetActive(true);
        }
        
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void RestetScene()

    {
        SceneManager.LoadScene(1);
    }

    public void ReturnNewHighScore()
    {
        HighScoreManager.Instance.newHighScore = m_Points;
        HighScoreManager.Instance.newScoreName = inputName.text;
        SceneManager.LoadScene(0);
    }

    void NewBricks()
    {
        const float step = 0.6f;
        int perLine = Mathf.FloorToInt(4.0f / step);
        
        int[] pointCountArray = new[] { 1, 1, 2, 2, 5, 5 };
        for (int i = 0; i < LineCount; ++i)
        {
            for (int x = 0; x < perLine; ++x)
            {
                brickLeft += 1;
                //Debug.Log(brickLeft);
                Vector3 position = new Vector3(-1.5f + step * x, 2.5f + i * 0.3f, 0);
                var brick = Instantiate(BrickPrefab, position, Quaternion.identity);
                brick.PointValue = pointCountArray[i];
                brick.onDestroyed.AddListener(AddPoint);
            }
        }
    }

}
