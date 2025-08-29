using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public Vector2 direction;
    public float despawnTime;

    float speed;
    float timeSinceSpawn;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float rand = 6.0f * Random.value + 0.1f;
        transform.localScale.Scale(new Vector3(rand, rand, 1.0f));

        speed = Random.value * 6.0f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime * direction);
        timeSinceSpawn += Time.deltaTime;
        if(timeSinceSpawn > despawnTime) 
        {
            Destroy(this.gameObject);
        }
    }
}
