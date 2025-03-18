using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float bulletSpeed = 20f;

    private Rigidbody2D myRigidBody;
    private PlayerMovement player;

    private float xSpeed;

    private void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        player = FindAnyObjectByType<PlayerMovement>();

        xSpeed = player.transform.localScale.x * bulletSpeed;
    }

    private void Update()
    {
        myRigidBody.linearVelocity = new Vector2(xSpeed, 0f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(gameObject);
    }
}