using UnityEngine;

class OnValidatePractice : MonoBehaviour
{
    [SerializeField] int intSetting;
    [SerializeField] float floatSetting;
    [SerializeField] string stringSetting;
    [SerializeField] bool boolSetting;
    [SerializeField] int startAmmo = 34;

    [Space]
    [SerializeField] float num1, num2;
    [SerializeField] float sum;


    int filedVariable = 55; //Tagváltozó/Field variable

    void OnValidate()
    {
        sum = num1 + num2;
    }

    void Start()
    {
        int localVariable = 66;
        int summa = localVariable + filedVariable + intSetting;
        
        Debug.Log(summa);

    }
}
