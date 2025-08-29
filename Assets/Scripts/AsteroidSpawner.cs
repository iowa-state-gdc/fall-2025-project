using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public GameObject prefab;
    public Transform target;

    float timeSinceLastSpawn = 0.0f;

    // Update is called once per frame
    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;
        while(timeSinceLastSpawn > 0.5f)
        {
            timeSinceLastSpawn -= 0.5f;
            GameObject spawnedAsteroid = Instantiate(prefab);

            Vector3 position = new Vector3(Random.value - 0.5f, Random.value - 0.5f, 0.0f) ;
            position.Normalize();
            position *= 6.0f;

            float toTarget = Vector3.Angle(Vector3.right, position);
            toTarget += 0.0f;// 22.5f * (Random.value - 0.5f);
            Vector2 direction = new Vector2(Mathf.Cos(toTarget), Mathf.Sin(toTarget));

            position.x += target.position.x;
            position.y += target.position.y;

            spawnedAsteroid.transform.position = position;
            spawnedAsteroid.GetComponent<Asteroid>().direction = direction;
        }
    }
}
