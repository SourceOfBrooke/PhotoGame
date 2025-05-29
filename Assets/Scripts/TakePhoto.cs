using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakePhoto : MonoBehaviour
{
    [SerializeField]
    ParticleSystem flash;
    [SerializeField]
    ParticleSystem flash1;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Press to take photos
        if (Input.GetMouseButtonDown(0)) 
        {
            flash.Play();
            flash1.Play();
        }
    }
}
