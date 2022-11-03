using UnityEngine;

class StringDivision : MonoBehaviour
{
    [SerializeField] int int1, int2;
    [SerializeField] string text;
    void OnValidate()
    {
        if (int2 == 0)
        {
            text = "Nullaval nem tudunk osztani.";
        }
        else
        {
            int wholes = int1 / int2;
            int remainder = int1 % int2;
            text = $"{int1}-ban {int2} megvan {wholes}-szer, maradék: {remainder}";
        }
    }
}
