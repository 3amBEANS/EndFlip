using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerExtras : MonoBehaviour
{
    private Rigidbody2D player;
    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;
    private bool isGrounded;
    

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        player.velocity = new Vector2(horizontalInput * speed, player.velocity.y);

        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
            player.velocity = new Vector2(player.velocity.x, jumpForce);
            isGrounded = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }
}
