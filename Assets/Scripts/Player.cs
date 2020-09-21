using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float _speed = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        CalculateMovement();   
    }



    void CalculateMovement()
    {
        
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontalInput, verticalInput, 0);
        transform.Translate(direction * _speed * Time.deltaTime);

        if (transform.position.y >= 5.85f)
        {
            transform.position = new Vector3(transform.position.x, 5.85f, 0);
        }
        else if (transform.position.y <= -5.74f) 
        {
            transform.position = new Vector3(transform.position.x, -5.74f, 0);
        }

        if (transform.position.x >= 11.67f)
        {
            transform.position = new Vector3(11.67f, transform.position.y, 0);
        }
        else if (transform.position.x <= -11.67f) 
        {
            transform.position = new Vector3(-11.67f, transform.position.y, 0);
        }


    }







}
