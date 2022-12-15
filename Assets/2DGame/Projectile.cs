using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float lifetime = 3;

    Vector2 velocity;

    float startTime;

    void Start()
    {
        startTime = Time.time;
    }

    public void SetVelocity(Vector2 velocity)
    {
        this.velocity = velocity;
    }

    void Update()
    {
        transform.position += (Vector3)velocity * Time.deltaTime;

        float age = Time.time - startTime;

        if (age > lifetime)
        {
            Destroy(gameObject);
        }
    }

}
