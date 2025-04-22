using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraPlacing : MonoBehaviour
{
    [SerializeField]
    GameObject spawn;
    [SerializeField]
    GameObject tripod;
    GameObject placedTripod;
    bool camPlaced = false;
    float spawnX;
    [SerializeField]
    GameObject player;
    float direction;
    bool canPickup = false;


    // Start is called before the first frame update
    void Start()
    {
        
       
    }

    // Update is called once per frame
    void Update()
    {
        direction = player.transform.localScale.x;
        
        if (Input.GetKeyDown(KeyCode.E)) 
        {

            // Place the camera and tripod if not already down
            if (!camPlaced) 
            {
                camPlaced = true;
                spawnX = spawn.transform.position.x;
                
                if (direction == -2) 
                {
                    
                    placedTripod = Instantiate(tripod, new Vector2(spawnX, -11), Quaternion.identity);
                    placedTripod.transform.localScale = new Vector3(-5, 5, 5);

                }
                if (direction == 2) 
                {

                    placedTripod = Instantiate(tripod, new Vector2(spawnX, -11), Quaternion.identity);
                    placedTripod.transform.localScale = new Vector3(5, 5, 5);

                }

            } else if (camPlaced) 
            {
                if (canPickup) 
                {
                    Destroy(placedTripod);
                    camPlaced = false;
                }
            }
            
        }
        
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "tripodcam") 
        {
            canPickup = true;
            Debug.Log(collision.name + " Enter" + "Cam Stats: CanPickup = " + canPickup);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "tripodcam")
        {
            canPickup = false;
            Debug.Log(collision.name + " Exit" + "Cam Stats: CanPickup = " + canPickup);
        }
    }
}
