using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //give access to the box collider
    //means what happen went 2 Tringger is touching between another tringer
    void OnTriggerEnter2D(Collider2D collider)
    {
         if(collider.gameObject.tag == "Player")
         {
              GameManager.instance.IncrementScore();
             Destroy(gameObject);
         }
         else if (collider.gameObject.tag == "Boundary")
         {
             GameManager.instance.DecreaseLife();
             Destroy(gameObject);
             print("Destroy");
         }
    }
    /*void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            //Increement Score
            GameManager.instance.IncrementScore();
            Destroy(gameObject);
        }
        else if(collider.gameObject.tag=="Boundary")
        {
            //decrease Live
            GameManager.instance.DecreaseLife();
            Destroy(gameObject);
        }
    } */
}
