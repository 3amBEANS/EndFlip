using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Vincent
{
    public class TESTPLAYERMOVE : MonoBehaviour
    {
        Rigidbody2D rb2d;
        public float speed;
        public float jumpSpeed;
        // Start is called before the first frame update
        void Start()
        {
            rb2d = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey("a"))
            {
                rb2d.velocity = new Vector2(-speed, rb2d.velocity.y);
            }
            if (Input.GetKey("d"))
            {
                rb2d.velocity = new Vector2(speed, rb2d.velocity.y);
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb2d.velocity = new Vector2(rb2d.velocity.x, jumpSpeed);
            }
        }
    }
}