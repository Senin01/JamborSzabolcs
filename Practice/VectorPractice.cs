using UnityEngine;

class VectorPractice : MonoBehaviour
{
    [SerializeField] Vector2 vector2Field;
    [SerializeField] Vector3 vector3Field;
    void OnValidate()
    {
        Vector2 vector2 = new Vector2(24, 2.5f);
        Vector3 vector3 = new Vector3(24, 2.5f, 5);

        Vector3 zeroVector = Vector3.zero; //0, 0, 0

        Vector3 upVector = Vector3.up; //0, 1, 0
        Vector3 leftVector = Vector3.left; //-1, 0, 0
        //...

        float v3y = vector3.y; // egy konkret tengely erteke
        Debug.Log(v3y);

        vector3.z = 0;

        //

        Vector3 vecA = new Vector3(1, 2, 5.5f);
        Vector3 vecB = new Vector3(33, 0, -2);

        Vector3 summaVec = vecA + vecB;
        Vector3 diffVec = vecA - vecB;

        Vector3 productVec = vecA * 2.4f;


    }
}
