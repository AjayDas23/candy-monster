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

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            //Increment Score
            GameManager.instance.ScoreInc();
            Destroy(gameObject);
        }
        
        else if (collider.gameObject.tag == "Boundary")
        {
            //Decrease Lives
            GameManager.instance.DecreaseLives();
            Destroy(gameObject);
        }
    }
}
