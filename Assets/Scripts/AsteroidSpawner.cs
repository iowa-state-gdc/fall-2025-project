using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public GameObject prefab;
    public Transform target;
    public float spawnRadius;
    public float angleVariance;

    float timeSinceLastSpawn = 0.0f;

    // Update is called once per frame
    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;
        while(timeSinceLastSpawn > 0.5f)
        {
            timeSinceLastSpawn -= 0.5f;
            GameObject spawnedAsteroid = Instantiate(prefab);

            Vector2 position = new Vector3(Random.value - 0.5f, Random.value - 0.5f);
            position.Normalize();
            position *= spawnRadius;

            float toTarget = Mathf.Atan2(-position.y, -position.x);
            Debug.Log(toTarget * Mathf.Rad2Deg);
            toTarget += Mathf.Deg2Rad * (Random.value - 0.5f) * angleVariance;
            Debug.Log("     " + toTarget * Mathf.Rad2Deg);
            Vector2 direction = new Vector2(Mathf.Cos(toTarget), Mathf.Sin(toTarget));

            position.x += target.position.x;
            position.y += target.position.y;

            spawnedAsteroid.transform.position = position;
            spawnedAsteroid.GetComponent<Asteroid>().direction = direction;
        }
    }
}
