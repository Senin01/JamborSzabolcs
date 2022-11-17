using UnityEngine;

class Exponentiation : MonoBehaviour
{
    [SerializeField] float baseNumber, exponent;  // Bemeneti változók
    [SerializeField] float result;                // Kimeneti változó

    void OnValidate()
    {
        result = 1;

        for (int i = 0; i < exponent; i++)
            result *= baseNumber;
    }
}