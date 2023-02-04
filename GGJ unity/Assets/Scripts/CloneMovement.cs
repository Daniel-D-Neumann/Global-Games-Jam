using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneMovement : MonoBehaviour
{
    private float Horz;
    private float speed = 4f;
    private float JumpingPower = 5.7f;
    private bool IsFacingRight = true;
    private Animator CloneAnims;

    [SerializeField] private Rigidbody2D RB;
    [SerializeField] private Transform FloorCheck;
    [SerializeField] private LayerMask FloorLayer;

    private enum MovementState { idle, running, jumping, falling }

    private void Start()
    {
        CloneAnims = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Horz = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            RB.velocity = new Vector2(RB.velocity.x, JumpingPower);
        }

        if (Input.GetButtonUp("Jump") && RB.velocity.y > 0f)
        {
            RB.velocity = new Vector2(RB.velocity.x, RB.velocity.y * 0.5f);
        }

        if (Input.GetButtonDown("Fire1"))
        {
            Destroy(gameObject);
        }

        UpdateAnimationState();

        Flip();
    }

    private void FixedUpdate()
    {
        RB.velocity = new Vector2(Horz * speed, RB.velocity.y);
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(FloorCheck.position, 0.2f, FloorLayer);

    }

    private void Flip()
    {
        if (IsFacingRight && Horz < 0f || !IsFacingRight && Horz > 0f)
        {
            IsFacingRight = !IsFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

    private void UpdateAnimationState()
    {
        MovementState state;

        if (Horz > 0f)
        {
            state = MovementState.running;
        }
        else if (Horz < 0f)
        {
            state = MovementState.running;
        }
        else
        {
            state = MovementState.idle;
        }

        if (RB.velocity.y > .1f)
        {
            state = MovementState.jumping;
        }
        else if (RB.velocity.y < -.1f)
        {
            state = MovementState.falling;
        }

        CloneAnims.SetInteger("CurrentState", (int)state);
    }

}
