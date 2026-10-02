using UnityEngine;
using UnityEngine.Rendering;

public class Enemy : MonoBehaviour
{
    public EnemyData data;
    public int currentHealth;

    void Start()
    {
        currentHealth = data.maxHealth;
        GetComponent<SpriteRenderer>().color = data.color;
    }
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.X))
		{
			TakeDamage(1);
		}
		transform.Translate(Vector2.left * data.speed * Time.deltaTime);		
	}
    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
