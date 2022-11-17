using UnityEngine;

class MyOwnClamp : MonoBehaviour
{
    // Tesztelésre:
    [SerializeField] float number, minimum = -10, maximum = 10;
    [SerializeField] float clamped, clamped01;

    void OnValidate()
    {
        clamped = Clamp(number, minimum, maximum);
        clamped01 = Clamp01(number);
    }
    float Clamp(float f, float min, float max)
    {
        if (number <= min)
            return min;
        else if (number >= max)
            return max;
        else
            return f;
    }
    float Clamp01(float f)
    {
        return Clamp(f, 0, 1);
    }
}
