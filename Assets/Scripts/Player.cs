using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 3f;
    private Rigidbody2D rb;
    private Vector2 moveInput;
    float moveX;
    private bool flippedLeft;
    public bool facingRight;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();      
        facingRight = true; 
    }

    void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        moveInput = new Vector2(moveX, moveY).normalized;
        rb.MovePosition(rb.position + moveInput * speed * Time.deltaTime);
        
        if (moveX > 0)
        {
            facingRight = true;
            Flip(true);
        }


        if (moveX < 0)
        {
            facingRight = false;
            Flip(false);
        }
    }

    private void Flip(bool facingRight) // usando rotación del asset
    {
        if(flippedLeft && facingRight)
        {
            transform.Rotate(new Vector3(0,180,0));
            flippedLeft = false;
        }
        if(!flippedLeft && !facingRight)
        {
            transform.Rotate(new Vector3(0,-180,0));
            flippedLeft = true;
        }
    }

}