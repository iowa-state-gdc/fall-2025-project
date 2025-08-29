using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public Vector2 direction;

    float speed;
    float timeSinceSpawn;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float rand = 2.0f * Random.value + 0.1f;
        transform.localScale.Scale(new Vector3(rand, rand, rand));

        speed = Random.value * 6.0f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime * direction);
        timeSinceSpawn += Time.deltaTime;
        if(timeSinceSpawn > 3.0) 
        {
            Destroy(this.gameObject);
        }
    }
}
