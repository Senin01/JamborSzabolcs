using UnityEngine;

class PlatformerPlayer2D : MonoBehaviour
{
    [SerializeField] new Rigidbody2D rigidbody;
    [SerializeField] HealthObject healthObject;
    [SerializeField] float jumpVelocity;
    [SerializeField] float horizontalSpeed;
    [SerializeField] int airJump;

    bool isGrounded;
    int currentairJumpBudget;

    JumpMultiplier jumpPlatform;

    void OnValidate()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        healthObject = GetComponent<HealthObject>();
    }
    void Update()
    {
        if (healthObject != null && healthObject.IsDead()) 
        {
            return;
        }

        //Jump
        if ((isGrounded || currentairJumpBudget > 0) && Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.velocity = Vector2.zero;
            Vector2 jump = Vector2.up * jumpVelocity;
            
            if (jumpPlatform != null)
            {
                jump *= jumpPlatform.multiplier;
            }

            rigidbody.AddForce(jump * rigidbody.mass, ForceMode2D.Impulse);

            if (!isGrounded)
            {
                currentairJumpBudget--;
            }
        }
    }

    void FixedUpdate()
    {
        if (healthObject != null && healthObject.IsDead())
        {
            return;
        }
        //Movement
        float inputX = Input.GetAxis("Horizontal");
        //Debug.Log(inputX);
        Vector2 velocity = new Vector2(inputX * horizontalSpeed, rigidbody.velocity.y);
        rigidbody.velocity = velocity;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
        currentairJumpBudget = airJump;
        jumpPlatform = collision.gameObject.GetComponent<JumpMultiplier>();
        //Debug.Log("Collide: " + collision.otherCollider.name);
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;
        jumpPlatform = null;
    }
}
