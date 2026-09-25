using UnityEngine;

public class Vector : MonoBehaviour
{
    public Vector2 startPosition = new Vector2(2, 1);
    public Vector2 myVector = new Vector2(3, 4);
    void Start()
    {
        startPosition = transform.position;
        Debug.Log($"Magnitude: {myVector.magnitude} Normalized {myVector.normalized}");
    }

    void Update()
    {
        
    }
}
