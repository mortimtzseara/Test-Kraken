using UnityEngine;

public class Spawn : MonoBehaviour
{
	[SerializeField] private float nextSpawnTime;
	[SerializeField] private float timeBetweenSpawns = 1f;
	[SerializeField] private ObjectPool pool;
	void Start()
    {
        
    }

    void Update()
    {
		if (Time.time >= nextSpawnTime)
		{
			GameObject newObject = pool.GetObject(transform.position);
			nextSpawnTime = Time.time + timeBetweenSpawns;
			newObject.GetComponent<TimedObject>().SetPool(pool);
		}
	}
}
