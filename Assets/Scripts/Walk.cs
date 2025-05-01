using UnityEngine;

public class Walk : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Rigidbody2D rb2d;
    Vector2 moveinput;
    float move;
    [SerializeField] float speed = 1f;
    [SerializeField] float jumpForce;
    [SerializeField] bool isJumping;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();  
    }

    // Update is called once per frame
    void Update()
    {
        moveinput = new Vector2(Input.GetAxisRaw("Horizontal"), 0);
        rb2d.velocity = new Vector2(moveinput.x * speed, rb2d.velocity.y);
       if (Input.GetButtonDown("Jump") && !isJumping)
        {
            rb2d.AddForce(new Vector2(rb2d.velocity.x, jumpForce));  
            Debug.Log("Jump");
        }
    }
    
    
}