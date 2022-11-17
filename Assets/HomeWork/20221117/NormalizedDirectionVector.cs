using UnityEngine;

public class NormalizedDirectionVector : MonoBehaviour
{
    [SerializeField] Vector3 start, end;      // Bemeneti változók    
    [SerializeField] Vector3 result;    // Kimeneti változó

    void OnValidate()
    {
        result = NormalFromAToB(start, end);
    }
    Vector3 NormalFromAToB(Vector3 a, Vector3 b)
    {
        Vector3 result = end - start;    // Ez a-ból b-be mutató vektor
        return result.normalized;  // Ennek a normalizált (1 hosszú) alakja kell.
    }
}