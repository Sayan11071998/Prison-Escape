using System;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1f;

    private Rigidbody2D myRigidBody;

    private void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        myRigidBody.linearVelocity = new Vector2(moveSpeed, 0f);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        moveSpeed = -moveSpeed;
        FlipEnemyFacing();
    }

    private void FlipEnemyFacing()
    {
        transform.localScale = new Vector2(-(Mathf.Sign(myRigidBody.linearVelocity.x)), 1f);
    }
}