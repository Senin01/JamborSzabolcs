using UnityEngine;

class DamageBox : MonoBehaviour
{
    [SerializeField] float damage = 10;
    [SerializeField] bool instantKill = false;

    void OnCollisionEnter2D(Collision2D collision)
    {
        HealthObject healthObject = collision.gameObject.GetComponent<HealthObject>();
        if (healthObject != null)
        {
            if (instantKill)
            {
                healthObject.Kill();
            }else
            {
                healthObject.Damage(damage);
            }
        }
        
        // Debug.Log("Death!");
        // Destroy(collision.gameObject);
    }
}
