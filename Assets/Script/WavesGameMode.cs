using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WavesGameMode : MonoBehaviour
{
    [SerializeField] Life playerLife;
    [SerializeField] Life playerBaseLife;

    
    void Start()
    {
        playerLife.onDeath.AddListener(OnPlayerOrBaseDied);
        playerBaseLife.onDeath.AddListener(OnPlayerOrBaseDied);
        EnemiesManager.instance.onChanged.AddListener(CheckWinCondition);
        WavesManager.instance.onChanged.AddListener(CheckWinCondition);
    }
    void OnPlayerOrBaseDied()
    {
        SceneManager.LoadScene("LoseScreen");
    }

    void CheckWinCondition()
    {
        if (EnemiesManager.instance.enemies.Count <= 0 && WavesManager.instance.waves.Count <= 0)
        {
            SceneManager.LoadScene("WinStage1");
        }
    }

    private void Awake()
    {
        playerLife.onDeath.AddListener(OnPlayerOrBaseDied);
        playerBaseLife.onDeath.AddListener(OnPlayerOrBaseDied);
    }
}
