using UnityEngine;

public class DirectionToTarget : MonoBehaviour
{
    public Transform target;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = target.position - transform.position;
        Debug.Log($"Magnitude: {direction.magnitude}");
        Debug.DrawLine(transform.position, target.position, Color.red);
    }
}
