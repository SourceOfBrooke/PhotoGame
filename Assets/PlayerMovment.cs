using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    private Rigidbody2D player;
    [SerializeField]
    int jumpForce = 2;
    float movementSpeed = 10f;
    private void Awake()
    {
        player = GetComponent<Rigidbody2D>();   
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") > 0.00) 
        {
            transform.localScale = new Vector3(2,2,2);
        }
        if (Input.GetAxis("Horizontal") < 0.00)
        {
            transform.localScale = new Vector3(-2, 2, 2);
        }


        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            player.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
        player.velocity = new Vector2(Input.GetAxis("Horizontal") * movementSpeed, player.velocity.y);
    }
}
