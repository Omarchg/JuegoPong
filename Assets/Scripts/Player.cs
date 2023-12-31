using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    KeyCode buttonUp, buttonDown;
    [SerializeField]
    float speedPlayer = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(buttonDown))
        {
            Debug.Log("Presionando abajo " + gameObject.name);
            transform.position += Vector3.down * Time.deltaTime * speedPlayer;
        }
        else if (Input.GetKey(buttonUp))
        {
            Debug.Log("Presionando arriba " + gameObject.name);
            transform.position += Vector3.up * Time.deltaTime * speedPlayer;
        }
    }
}
