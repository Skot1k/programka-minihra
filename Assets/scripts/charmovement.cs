using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charmovement : MonoBehaviour
{
    
    public float jumpStrength;
    public score logic;
    public bool alive = true;
    public float speed;
    public float horizontal;
    private bool facingRight;

    [SerializeField] private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<score>();
    }

    // Update is called once per frame
    void Update()
    {

        horizontal = Input.GetAxisRaw("Horizontal") * Time.deltaTime ;
        
        if (Input.GetKeyDown(KeyCode.Space) && alive && rb.velocity.y <= 0)
        {
            rb.velocity += Vector2.up * jumpStrength;
        }

        if (alive)
        {
            Flip();
            rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * speed, rb.velocity.y);
        }
        

    }
    private void OnTriggerEnter2D(Collider2D spikes)
    {
        if (spikes.tag == "spikes")
        {
            logic.gameOver();
            alive = false;
            rb.rotation = 90;

        }
    }
   

    private void Flip()
    {
        if (facingRight && horizontal < 0 || !facingRight && horizontal > 0)
        {
            facingRight = !facingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1;
            transform.localScale = localScale;
        }
    }
}
