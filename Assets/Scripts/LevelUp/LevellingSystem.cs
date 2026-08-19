using Unity.VisualScripting;
using UnityEngine;

public class LevellingSystem : MonoBehaviour
{
    //Cross script referencing
    public BattleSystem battleSystem;
    public PlayerStats playerStats;



    //types of XP
    public float evilXP; //evil XP, increases Attack and Health
    public float goodXP; //good XP, increases block and defense
 

    public float questXP;

    public float bondXP;

    //Level
    public int playerLevel = 1;
    public float experiencePoints = 0;
    public float maxExperience = 100;

    //stats
    public float questXPGain = 1;
    public float goodXPGain = 1;
    public float evilXPGain = 1;
    public float bondXPGain = 1;



    


    void Update()
    {
        if (evilXP + goodXP + questXP + bondXP >= maxExperience)//level up condintions and activation
        {
            levelUp();
        }
    }





    //level up function
    public void levelUp()
    {
        //questXP bonuses
        bondXPGain += bondXP * 0.01f;

        //bondXP bonuses
        questXPGain += bondXP * 0.01f;


        //redXP bonuses
        evilXPGain += evilXP * 0.01f;

        //BlueXP bonuses
        goodXPGain += goodXP * 0.01f;



        //Resetting experience points
        evilXP = 0;
        goodXP = 0;
        questXP = 0;
        bondXP = 0;

        //Increasing player level
        playerLevel++;

        playerStats.playerHealth = playerStats.playerMaxHealth;//resetting player health
        playerStats.mana = playerStats.maxMana;//resetting mana
    }
}
