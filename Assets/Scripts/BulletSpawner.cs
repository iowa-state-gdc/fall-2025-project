using UnityEngine;
using UnityEngine.InputSystem;

public class BulletSpawner : MonoBehaviour
{
    public GameObject prefab;
    public Transform spawn;

    private void OnFire(InputValue value)
    {
        Vector2 direction = new Vector2(value.Get<Vector2>().x, value.Get<Vector2>().y);

        if (direction != Vector2.zero)
        {
            GameObject spawnedBullet = Instantiate(prefab);

            Vector2 position = new Vector3(0, 0);
            position.x += spawn.position.x;
            position.y += spawn.position.y;

            spawnedBullet.transform.position = position;

            spawnedBullet.GetComponent<Bullet>().bulletDirection = direction.normalized;
        }
    }

    // Update is called once per frame
    void Update()
    {        

        
        
    }
}
