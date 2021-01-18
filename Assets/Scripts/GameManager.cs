using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private PlayerController player;
    [SerializeField] private Text gameOverText;
    [SerializeField] public AudioSource audioSource;
    [SerializeField] public Text scoreText;
    private static GameManager instance;
    private int score;
    private bool isGameOver;

    public static GameManager Instance
    {
        get
        {
            if (instance == null) instance = GameObject.FindObjectOfType<GameManager>();
            return instance;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        gameOverText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DamagePlayer(int Damage)
    {
        if ((player.health -= Damage) <= 0)
        {
            GameOver();
        }
        
    }

    public void AddScore(int Increase)
    {
        score += Increase;
    }

    public void PlaySound()
    {
        audioSource.Play();
    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
    }

}
