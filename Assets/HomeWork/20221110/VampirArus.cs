using UnityEngine;

class VampirArus : MonoBehaviour
{
    [SerializeField] int hp, gold;

    [SerializeField] bool canBuyMace;
    [SerializeField] bool canBuyDagger;
    [SerializeField] bool canBuyTeeth;

    bool CheckPrice(int price)
    {
        int goldToHp = 5;
        bool canBuySomething = price <= gold || price * goldToHp < hp;

        return canBuySomething;
    }

    void OnValidate()
    {
        int price = 10;
        canBuyMace = CheckPrice(price);        
        
        price = 4;
        canBuyDagger = CheckPrice(price);

        price = 13;
        canBuyTeeth = CheckPrice(price);
    }
}
