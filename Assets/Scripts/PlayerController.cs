using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator animator;
    Rigidbody2D rigidbody2d;
    float horizontal;
    float moveDirection = 1;
    float isMoving = 0;
    public float speed = 3.0f;
    public bool isActive = false;
    // Start is called before the first frame update
    void Start()
    {
        animator.SetFloat("Move X", 1);
        animator.SetFloat("Moving", 0);
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isActive)
        {
            if (horizontal != 0)
            {
                moveDirection = horizontal;
                isMoving = 1;
            }
            else
            {
                isMoving = 0;
            }
            animator.SetFloat("Move X", moveDirection);
            animator.SetFloat("Moving", isMoving);
            Vector2 position = rigidbody2d.position;
            position.x = position.x + speed * horizontal * Time.deltaTime;

            rigidbody2d.MovePosition(position);
        }
    }
}
