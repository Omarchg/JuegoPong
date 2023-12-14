using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    private Vector3 direction;
    
    
    // Start is called before the first frame update
    void Start()
    {
        if(Random.Range(0.0f, 1.0f)< 0.5f)
        {
            direction = Vector3.right * 5;
        }
        else
        {
            direction = Vector3.left * 5;
        }
        
        /*
        if(Random.Range(0.0f, 1.0f)< 0.5f) 
        {
            
            direction += Vector3.up;
        }
        else
        {
            
            direction += Vector3.down;
        }
        */
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * Time.deltaTime;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("una colisión con " + collision.gameObject.name);
        if (collision.gameObject.CompareTag("Player"))
        {
            direction.x = direction.x * (-1);
            direction.y = Random.Range(-1f,1f);
        }


        if (collision.gameObject.CompareTag("Border"))
        {
            
            direction.y = direction.y * Random.Range(-1f,1f);
        }
    }
}
