using UnityEngine;

public class MoveVelocity : MonoBehaviour
{   
    [SerializeField] float speed = 1f;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rb.linearVelocity = new Vector3(speed, 0, 0);
    }
}
