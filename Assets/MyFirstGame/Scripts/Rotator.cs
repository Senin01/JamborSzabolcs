using UnityEngine;

class Rotator : MonoBehaviour
{
    [SerializeField] float angularSpeed;
    [SerializeField] Space rotationspace;
    [SerializeField] Vector3 axis = Vector3.up;
    void Update()
    {
        float angle = angularSpeed * Time.deltaTime;
        transform.Rotate(axis, angle, rotationspace);
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Vector3 center = transform.position;

        Vector3 dir = axis.normalized;

        if (rotationspace == Space.Self)
        {
            dir = transform.TransformDirection(dir);

            // Vector3 localUp = transform.up;
            // Vector3 localUp2 = transform.TransformDirection(Vector3.up);
            // transform.InverseTransformPoint(transform.up);
        }

        Vector3 a = center + dir;
        Vector3 b = center - dir;
        Gizmos.DrawLine(a, b);
    }
}
