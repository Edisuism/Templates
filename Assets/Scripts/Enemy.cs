using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private int minSpeed;
    [SerializeField] private int maxSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        //When initialised, turn a random direction and go a random direction
        rb.rotation = Random.Range(0f, 360f);
        rb.velocity = RandomVector() * Random.Range(minSpeed,maxSpeed);
    }

    private Vector2 RandomVector()
    {
        //CHALLENGE: Adjust the code so that the enemy never stays still
        var x = Random.Range(-1, 1);
        var y = Random.Range(-1, 1);
        return new Vector2(x, y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //If collided with a player, damage them and self destruct
        if (collision.CompareTag("Character"))
        {
            GameManager.Instance.DamagePlayer(1);
            Destroy(gameObject);
        }
    }
}
