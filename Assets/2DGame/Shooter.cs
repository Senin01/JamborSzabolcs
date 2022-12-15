using UnityEngine;

enum ShootingPattern { First, Sequence, Random, PingPong }

class Shooter : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Transform starPoint;
    [SerializeField] GameObject[] projectiles;
    [SerializeField] KeyCode key = KeyCode.X;
    [SerializeField] ShootingPattern pattern;

    int index = 0;

    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            int i;
            if (pattern == ShootingPattern.First)
            {
                i = 0;
            }
            else if (pattern == ShootingPattern.Sequence)
            {
                i = index % projectiles.Length;
            }
            else if (pattern == ShootingPattern.Random)
            {
                i = Random.Range(0, projectiles.Length);
            }
            else
            {
                i = 0; //Házi feladat
            }
            
            GameObject newProjectile = Instantiate(projectiles[i]);
            newProjectile.transform.position = starPoint.position;

            Vector2 velocity = speed * transform.right;

            Projectile p = newProjectile.GetComponent<Projectile>();
            p.SetVelocity(velocity);

            index++;

            /*
            if (index >= projectiles.Length)
            {
                index = 0;
            }
            */
        }
        // GameObject go = new GameObject();        
    }
     
}
