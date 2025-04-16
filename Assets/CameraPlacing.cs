using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlacing : MonoBehaviour
{
    [SerializeField]
    GameObject spawn;
    [SerializeField]
    GameObject tripod;
    bool camPlaced = false;
    float spawnX;
    [SerializeField]
    GameObject player;
    float direction;


    // Start is called before the first frame update
    void Start()
    {
        
       
    }

    // Update is called once per frame
    void Update()
    {
        direction = player.transform.localScale.x;
        // Place the camera and tripod if not already down
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            if (!camPlaced) 
            {
                
                spawnX = spawn.transform.position.x;
                
                if (direction == -2) 
                {
                    Instantiate(tripod, new Vector2(spawnX, -11), Quaternion.identity);
                    tripod.transform.localScale = new Vector3(-5, 5, 5);
                }
                if (direction == 2) 
                {
                    Instantiate(tripod, new Vector2(spawnX, -11), Quaternion.identity);
                    tripod.transform.localScale = new Vector3(5, 5, 5);
                }
            }
        }
        
    }
}
