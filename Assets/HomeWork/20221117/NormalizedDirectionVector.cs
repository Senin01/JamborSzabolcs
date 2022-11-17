using UnityEngine;

public class NormalizedDirectionVector : MonoBehaviour
{
    [SerializeField] Vector3 start, end;      // Bemeneti v�ltoz�k    
    [SerializeField] Vector3 result;    // Kimeneti v�ltoz�

    void OnValidate()
    {
        result = NormalFromAToB(start, end);
    }
    Vector3 NormalFromAToB(Vector3 a, Vector3 b)
    {
        Vector3 result = end - start;    // Ez a-b�l b-be mutat� vektor
        return result.normalized;  // Ennek a normaliz�lt (1 hossz�) alakja kell.
    }
}