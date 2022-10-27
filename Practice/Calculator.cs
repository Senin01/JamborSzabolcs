using UnityEngine;

class Calculator : MonoBehaviour
{
    [SerializeField] float number1, number2;
    [SerializeField] float summa;
    [SerializeField] float difference;
    [SerializeField] float product;
    [SerializeField] float ration;
    [SerializeField] float modulo;

    void OnValidate()
    {
        summa = number1 + number2;
        difference = number1 - number2;
        product = number1 * number2;
        ration = number1 / number2;
        modulo = number1 % number2;
    }
}
