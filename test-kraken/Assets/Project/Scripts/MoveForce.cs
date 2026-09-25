using UnityEngine;

public class MoveForce : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float force = 1;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rb.AddForce(new Vector2(force, 0));
    }
}
