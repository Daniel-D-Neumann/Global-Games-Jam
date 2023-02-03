using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float Horz;
    private float speed = 4f;
    private float JumpingPower = 7f;
    private bool IsFacingRight = true;

    [SerializeField] private Rigidbody2D RB;
    [SerializeField] private Transform FloorCheck;
    [SerializeField] private LayerMask FloorLayer;
    [SerializeField] private LayerMask CloneLayer;


    // Update is called once per frame
    void Update()
    {
        Horz = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            RB.velocity = new Vector2(RB.velocity.x, JumpingPower);
        }

        if (Input.GetButtonDown("Jump") && IsOnClone())
        {
            RB.velocity = new Vector2(RB.velocity.x, JumpingPower);
        }

        if (Input.GetButtonUp("Jump") && RB.velocity.y > 0f)
        {
            RB.velocity = new Vector2(RB.velocity.x, RB.velocity.y * 0.5f);
        }

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

    private bool IsOnClone()
    {
        return Physics2D.OverlapCircle(FloorCheck.position, 0.2f, CloneLayer);
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

}
