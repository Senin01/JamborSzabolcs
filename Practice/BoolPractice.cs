using UnityEngine;

 class BoolPractice : MonoBehaviour
{
    void Start()
    {
        bool b = true;
        b = false;

        int i1 = 23;
        int i2 = 30;

        bool areTheInsEqual = i1 + 7 == i2;
        Debug.Log(areTheInsEqual);

        string s1 = "AAA";
        string s2 = "AAA";
        
        bool areTheStringsEqual = s1 == s2;
        Debug.Log(areTheStringsEqual);

        int i3 = 4, i4 = 78;
        bool areTheInsNotEqual = i3 != i4;
        
        
        bool isTheFirstHigher = i3 > i4;
        bool isTheFirstSmaller = i3 < i4;
        
        bool isTheFirstHigherOrEqual = i3 >= i4;
        bool isTheFirstSmallerOrEqual = i3 <= i4;

        //------------------------------------

        bool isGrounded = true; //Földön állunk-e?
        int airJumpCount = 1; //Hányat tudunk a levegõben ugrani?

        bool canJump = isGrounded || (airJumpCount > 0);

        int ammo = 23;
        float timeLeftSinceLastShot = 3.4f;
        float cooldown = 1;
        
        // bool canShoot = ammo > 0 && timeLeftSinceLastShot >= cooldown;
        bool coolDownOver = (timeLeftSinceLastShot >= cooldown);
        bool haveAmmo = (ammo > 0);
        bool canShoot = haveAmmo && coolDownOver;

        bool caNotShot = !canShoot;

        //XOR
        bool xor = true ^ true; //Kizáró vagy

    }
}
