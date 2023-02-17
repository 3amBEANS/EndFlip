using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spring : PlayerInteractable
{
    [SerializeField] private float springPower;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void collisionAction(Collider2D coll)
    {
        Rigidbody2D rb2d = coll.GetComponent<Rigidbody2D>();
        rb2d.velocity = new Vector2(rb2d.velocity.x / 2, springPower);
    }
}
