using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Animator animator;
    Vector2 movement;

void Update()
{
    movement.x = Input.GetAxisRaw("Horizontal");
    movement.y = Input.GetAxisRaw("Vertical");

    animator.SetFloat("Vertical", movement.y);
    animator.SetFloat("Horizontal", movement.x);
    animator.SetFloat("Speed", movement.magnitude);

if(Input.GetAxisRaw("Horizontal") == 1 ||Input.GetAxisRaw("Horizontal") == -1 ||Input.GetAxisRaw("Vertical") == 1 ||Input.GetAxisRaw("Vertical") == -1)
{
    animator.SetFloat("lastMoveX", Input.GetAxisRaw("Horizontal"));
    animator.SetFloat("lastMoveY", Input.GetAxisRaw("Vertical"));
}

}

void FixedUpdate()
{
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
}





}

