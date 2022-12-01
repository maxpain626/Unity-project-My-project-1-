using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public static float playerHealth;
    public static bool gameOver;
    [SerializeField] private Image imgFiller;
    [SerializeField] private Slider sliderHP;

    void Start()
    {
        playerHealth = 100f;
        gameOver = false;
    }

    void Update()
    {
        

        if (gameOver)
        {
            SceneManager.LoadScene(0);
        }
    }

    public static void Damage(float damageCount)
    {
        playerHealth -= damageCount;

        if (playerHealth <= 0)
        {
            gameOver = true;
        }
    }
}
