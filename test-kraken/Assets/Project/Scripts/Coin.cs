using Unity.VisualScripting;
using UnityEngine;

public class Coin : MonoBehaviour
{
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) {
            GameManager.instance.AddScorePoint(1);
            Destroy(gameObject);
        }
    }
    void Update()
    {
       
    }
}
