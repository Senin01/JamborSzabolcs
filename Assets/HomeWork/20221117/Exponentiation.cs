using UnityEngine;

class Exponentiation : MonoBehaviour
{
    [SerializeField] float baseNumber, exponent;  // Bemeneti v�ltoz�k
    [SerializeField] float result;                // Kimeneti v�ltoz�

    void OnValidate()
    {
        result = 1;

        for (int i = 0; i < exponent; i++)
            result *= baseNumber;
    }
}