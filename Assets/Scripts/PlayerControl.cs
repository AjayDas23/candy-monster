using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public bool PlayerMove = true;
    
    [SerializeField]
    float Playerspeed;
    
    [SerializeField]
    float Poslimit;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerMove)
        {
            Move();
        }
    }

    private void Move()
    {
        float InputX = Input.GetAxis("Horizontal");
        transform.position += Vector3.right * InputX * Playerspeed * Time.deltaTime;

        float xPos = Mathf.Clamp(transform.position.x, -Poslimit, Poslimit);
        transform.position = new Vector3(xPos, transform.position.y, transform.position.z);
    }
}
