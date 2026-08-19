using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    //Health
    public float playerMaxHealth = 100;
    public float playerHealth = 100;
    //Attack
    public float playerAttack = 20;
    //Defense
    public float playerDefense = 2;//this is a defense stat every number reduces damage by 3
    public float playerBlock = 50;// this is how much is blocked when using block
    //Magic
    public float fireballDamage = 25;
    public float mana = 2;
    public float maxMana = 2;
    //Skills
    public float crushingStrike = 0;

}
