using UnityEngine;

public class Enemy : MonoBehaviour
{
    public EnemyData[] enemyArray;
    public int currentHealth;
    private EnemyData currentEnemy;

    void Start()
    {
        currentEnemy = GenerateRandomEnemyData();
        currentHealth = currentEnemy.maxHealth;
        GetComponent<SpriteRenderer>().color = currentEnemy.color;
    }
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.X))
		{
			TakeDamage(1);
		}
		transform.Translate(Vector2.left * currentEnemy.speed * Time.deltaTime);		
	}
    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        //if (currentHealth <= 0)
        //{
        //    enemyPool.ReturnObject(gameObject);
		//}
    }
    public EnemyData GenerateRandomEnemyData()
    {
        int index = Random.Range(0, enemyArray.Length);
        return enemyArray[index];
    }
}
