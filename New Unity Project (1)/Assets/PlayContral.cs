using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayContral : MonoBehaviour
{
    private Rigidbody2D Hero;
    public float force = 100;
    // Start is called before the first frame update
    void Start()
    {
        Hero = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        //Hero.AddForce(Vector2.right * h * force);  //Vector2.right => new Vector( 1, 0 );
        Hero.velocity = new Vector2(h * 20, Hero.velocity.y);
        
    }
}
