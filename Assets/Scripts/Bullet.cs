using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Vector2 bulletDirection;
    public float despawnTime;

    float speed;
    float timeSinceSpawn;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.localScale.Scale(new Vector3(1.0f, 1.0f, 1.0f));

        speed = 10.0f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime * bulletDirection);
        timeSinceSpawn += Time.deltaTime;
        if (timeSinceSpawn > despawnTime)
        {
            Destroy(this.gameObject);
        }
    }
    
     private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Asteroid"))
        {
            Destroy(other.gameObject); // destroy asteroid
            Destroy(this.gameObject);       // destroy bullet
        }
    }
}
