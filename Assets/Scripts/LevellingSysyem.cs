using Unity.VisualScripting;
using UnityEngine;

public class LevellingSysyem : MonoBehaviour
{
    //Cross script referencing
    public BattleSystem battleSystem;
    public PlayerStats playerStats;



    //types of XP
    public float redXP; //offense XP, increases Attack and Health
    public float blueXP; //Defense XP, increases block and defense
    public float greenXP; //magic XP, increases magic attack and mana

    //Level
    public int playerLevel = 1;
    public float experiencePoints = 0;
    public float maxExperience = 100;


    void Update()
    {
        if (redXP + blueXP + greenXP >= maxExperience)//level up condintions and activation
        {
            levelUp();
        }
    }





    //level up function
    public void levelUp()
    {
        //redXP bonuses
        playerStats.playerAttack += redXP * 0.1f;
        playerStats.playerMaxHealth += redXP * 0.5f;

        //BlueXP bonuses
        playerStats.playerDefense += blueXP * 0.01f;
        playerStats.playerBlock += blueXP * 0.1f;

        //greenXP bonuses
        playerStats.fireballDamage += greenXP * 0.2f;
        playerStats.maxMana += greenXP * 0.05f;

        //Resetting experience points
        greenXP = 0;
        redXP = 0;
        blueXP = 0;

        //Increasing player level
        playerLevel++;

        playerStats.playerHealth = playerStats.playerMaxHealth;//resetting player health
        playerStats.mana = playerStats.maxMana;//resetting mana
    }
}
