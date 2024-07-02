using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllers : MonoBehaviour
{
    bool IsMoving
    {
        set
        {
            isMoving = value;
            animator.SetBool("isMoving", isMoving);
        }
    }

    public float moveSpeed = 150f;
    public float maxSpeed = 9f;
    public float idleFriction = 0.9f;

    public GameObject attack;

    Vector2 moveInput = Vector2.zero;

    Rigidbody2D rb;
    Animator animator;
    SpriteRenderer spriteRenderer;

    bool isMoving = false;
    bool canMove = true;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        if (canMove == true && moveInput != Vector2.zero)
        {
            rb.velocity = Vector2.ClampMagnitude(rb.velocity + (moveInput * moveSpeed * Time.deltaTime), maxSpeed);

            if (moveInput.x > 0)
            {
                spriteRenderer.flipX = true;
                gameObject.BroadcastMessage("IsFacingRight", true);
            }
            else if (moveInput.x < 0)
            {
                spriteRenderer.flipX = false;
                gameObject.BroadcastMessage("IsFacingRight", false);
            }
            IsMoving = true;

        }
        else
        {
            //rb.velocity = Vector2.Lerp(rb.velocity, Vector2.zero, idleFriction);

            IsMoving = false;
        }
    }

    void OnMove(InputValue movementValue)
    {
        moveInput = movementValue.Get<Vector2>();
    }

    void OnFire()
    {
        animator.SetTrigger("Attack");
    }

    void LockMovement()
    {
        canMove = false;
    }
    void UnLockMovement()
    {
        canMove = true;
    }
}
