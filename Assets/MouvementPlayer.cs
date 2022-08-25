using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementPlayer : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private Vector2 direction;
    private bool isJumping = false;
    //private int nbJump = 0;
    //private int maxJump = 2;
    public float moveSpeed = 10f;
    public float jumpForce = 250f;
    

    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();   
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal") * moveSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            isJumping = true;
        }
    }

    void FixedUpdate()
    {

        if ( isJumping )
        {
            direction.y = jumpForce * Time.fixedDeltaTime;
            isJumping = false;
            //nbJump++;
        }

        else
        {
            direction.y = 0;
        }

        rb2d.velocity = direction;
    }
}
