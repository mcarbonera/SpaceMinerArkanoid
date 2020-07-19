using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;

public class GameStatus : MonoBehaviour
{
    // config param
    [Range(0.1f,10f)] [SerializeField] float gameSpeed = 1f;
    [SerializeField] int pointsPerBlockDestroyed = 10;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI levelText;
    [SerializeField] bool isAutoPlayEnabled;

    // state variables
    [SerializeField] int currentScore = 0;
    [SerializeField] int levelNumber = 1;
    [SerializeField] int maxLifes = 3;
    [SerializeField] int lifes = 3;

    private void Start()
    {
        scoreText.text = currentScore.ToString();
        levelText.text = "Level "+levelNumber.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = gameSpeed;   
    }

    public void addToScore()
    {
        currentScore += pointsPerBlockDestroyed;
        scoreText.text = currentScore.ToString();
    }

    public void addLevelNumber()
    {
        levelNumber++;
        levelText.text = "Level " + levelNumber.ToString();
    }
        
    public void addLifes()
    {
        lifes++;
    }

    public void subLifes()
    {
        lifes--;
    }

    public int getLifes()
    {
        return lifes;
    }

    public int getMaxLifes()
    {
        return maxLifes;
    }

    public bool IsAutoPlayEnabled()
    {
        return isAutoPlayEnabled;
    }
}
