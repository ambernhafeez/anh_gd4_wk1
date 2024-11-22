using UnityEngine;


public class CharacterMovement2D : MonoBehaviour
{
    public float moveSpeed = 5;
    float horizontalMovement;
    public float jumpForce = 5;
    private Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();;
    }

    // Update is called once per frame
    void Update()
    {
        // GETS INPUT FROM THE PLAYER
        // input.getaxis() will return a float number between -1 and 1.
        // can do same for vertical movement.
        // uses both WASD and arrow keys for inputs
        horizontalMovement = Input.GetAxis("Horizontal");

        // respawn at new vector if player goes past certain position
        if(transform.position.x < -2)
        {
            transform.position = new Vector3(0, 2.53f, 0);
        }

        // USES INPUT TO MOVE CHARACTER
        // we just use x and y in 2D.
        // multiplying by horizontal movement allows us to move left and right
        transform.Translate(moveSpeed * Time.deltaTime * horizontalMovement, 0, 0);

        // flip the character if moving to the left (negative movement value)
        if(horizontalMovement < 0)
        {
            // uses the flip option from the sprite renderer window
            GetComponent<SpriteRenderer>().flipX = true;
        }
        if(horizontalMovement > 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            //jump
            rb.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}
