using UnityEngine;

class AverageCalc : MonoBehaviour
{
    [SerializeField] int i1, i2, i3, i4, i5;
    [SerializeField] float average;
    void OnValidate()
    {
        average = (i1 + i2 + i3 + i4 + i5) / 5f;
    }
}
