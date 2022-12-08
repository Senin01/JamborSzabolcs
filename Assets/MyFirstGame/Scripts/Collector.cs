using UnityEngine;

class Collector : MonoBehaviour
{

    int collectedValue = 0;
    void OnTriggerEnter(Collider other)
    {
        Collectable collectable = other.gameObject.GetComponent<Collectable>();
        // Collectable collectable = other.GetComponent<Collectable>(); ugyanaz mint feljebb

        if (collectable != null)
        {
            collectedValue += collectable.GetValue();
            Debug.Log("Collected: " + collectedValue);
            collectable.Teleport();
        }
    }
}
