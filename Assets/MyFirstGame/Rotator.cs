using UnityEngine;

class Rotator : MonoBehaviour
{
    [SerializeField] float angularSpeed;
    void Update()
    {
        float angle = angularSpeed * Time.deltaTime;
        transform.Rotate(Vector3.up, angle);
    }
}
