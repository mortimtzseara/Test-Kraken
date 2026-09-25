using UnityEngine;

public class TurretAim : MonoBehaviour
{
    public Transform player;
    void Start()
    {
        
    }

    void Update()
    {
        Vector2 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        transform.eulerAngles = new Vector3(0f, 0f, angle);
    }
}
