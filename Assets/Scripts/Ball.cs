using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    GameScoreUI score;
    [SerializeField]
    private Vector3 direction;
    [SerializeField]
    float ballspeed = 5.0f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        if(Random.Range(0.0f, 1.0f)< 0.5f)
        {
            direction = Vector3.right;
        }
        else
        {
            direction = Vector3.left;
        }
      
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * Time.deltaTime * ballspeed;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("una colisión con " + collision.gameObject.name);
        if (collision.gameObject.CompareTag("Player"))
        {
            direction.x = -direction.x;
            direction.y = Random.Range(-1.0f, 1.0f);
            ballspeed += 0.5f;
        }


        if (collision.gameObject.CompareTag("Border"))
        {
            
            direction.y = -direction.y;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("GoalZoneOne"))
        {
            ResetBall();
            score.GoalScoredPlayerTwo();
        }
        
        if (collision.CompareTag("GoalZoneTwo"))
        {
            ResetBall();
            score.GoalScoredPlayerOne();
        }
    }

    void ResetBall()
    {
        transform.position = Vector3.zero;
        ballspeed = 2.0f;
        direction.x = -direction.x;
        direction.y = Random.Range(-1f, 1f);
    }
    
}
