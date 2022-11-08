using UnityEngine;

class VampirArusRugalmas : MonoBehaviour
{
    [SerializeField] int hp, gold;

    [SerializeField] bool canBuyMace;
    [SerializeField] bool canBuyDagger;
    [SerializeField] bool canBuyTeeth;
    [SerializeField] bool canBuyAll;

    bool CheckPrice(int price)
    {
        int goldToHp = 5;
        bool canBuySomething = (price - gold) * goldToHp < hp;

        return canBuySomething;
    }

    void OnValidate()
    {
        int priceMace = 10;
        canBuyMace = CheckPrice(priceMace);

        int priceDagger = 4;
        canBuyDagger = CheckPrice(priceDagger);

        int priceTeeth = 13;
        canBuyTeeth = CheckPrice(priceTeeth);

        int priceAll = priceMace + priceDagger + priceTeeth;
        canBuyAll = CheckPrice(priceAll);
    }
}
