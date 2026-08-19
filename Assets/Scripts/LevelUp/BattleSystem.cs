using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class BattleSystem : MonoBehaviour
{
    //cross script referencing
    public LevellingSystem levelSystem;
    public PlayerStats playerStats;
    public EnemyStats enemyStats;
    public LevellingSystem level;


    //bools
    public bool isBlocking; //block checker
    public bool isPlayerTurn = true; //turn checker
    public bool isEnemyDead = false;

    //timer
    public float enemyResponseDelay = 1.5f; // wait 1.5 seconds
    public float enemyCurrentTime = 0; // the currentTime we've been waiting






    // Update is called once per frame
    void Update()
    {
       // uiManager.UpdateUI();// constantly updating UI

        //player turn starter
        if (isPlayerTurn == true) 
        {
            Playerturn();
        }
        else//enemy turn starters
        {
            EnemyTurn();
        }
        
    }

    //playerturn function
    public void Playerturn()
    {
        isBlocking = false; //reverting block at start of turn to prevent stacking


        if (Keyboard.current.digit1Key.wasPressedThisFrame)//attack keybind (1)
        {
            DealDamage(playerStats.playerAttack);//damage calculator
            Debug.Log("You have attacked dealing " +  playerStats.playerAttack + " Damage! The enemy now has " + enemyStats.enemyHealth + " / " + enemyStats.maxEnemyHealth + " Health left" );
            //levelSystem.redXP = levelSystem.redXP + 20;//giving redXP for attacking
            isPlayerTurn = false;//ending player turn
            enemyCurrentTime = enemyResponseDelay;//starting enemy timer
        }
        if (Keyboard.current.digit2Key.wasPressedThisFrame)//skill keybind (2)
        {
            if (playerStats.mana > 0)
            {
                Fireball(playerStats.fireballDamage);
               // levelSystem.greenXP = levelSystem.greenXP + 20;//giving greenXP for fireball
                isPlayerTurn = false;
                enemyCurrentTime = enemyResponseDelay;
            }


        }
        if (Keyboard.current.digit3Key.wasPressedThisFrame)//Block keybind (3)
        {
            isBlocking = true;//making blocking happen
            Block(playerStats.playerBlock);//block calculator
            Debug.Log("You are blocking " + playerStats.playerBlock + " Damage!");
           // levelSystem.blueXP = levelSystem.blueXP + 20;//giving blue XP for blocking
            isPlayerTurn = false;//ending player turn
            enemyCurrentTime = enemyResponseDelay;//starting enemy timer
        }
        if (Keyboard.current.digit4Key.wasPressedThisFrame)
        {
            Debug.Log("Your quest Xp is " + level.questXP + "! and your quest xp gain is " + level.questXPGain);
        }
    }

    public void EnemyTurn()
    {
      enemyCurrentTime -= Time.deltaTime;
            if (enemyCurrentTime <= 0)
            {
              Debug.Log("Enemy turn!.");
                
              TakeDamage(enemyStats.enemyAttack);
              Debug.Log("You were attacked for " + (enemyStats.enemyAttack - (3*playerStats.playerDefense)) + " Damage!");
                

              isPlayerTurn = true;
              enemyCurrentTime = enemyResponseDelay;
            }
    }

    //Player attack calculator
    public void DealDamage(float damageAmount)
    {
        enemyStats.enemyHealth -= damageAmount;//damage calc

        if (enemyStats.enemyHealth < 0)//preventing negative numbers
        {
            enemyStats.enemyHealth = 0;
        }

        if (enemyStats.enemyHealth <= 0)//respawning enemy after defeat
        {
            isPlayerTurn=true;
            Debug.Log("You defeated an enemy, but your victory is short lived as another has appeared!");
            enemyStats.enemyHealth = enemyStats.maxEnemyHealth;

        }

    }

    //enemy attack calculator
    public void TakeDamage(float damageAmount)
    {


        if (isBlocking==true)//calculation if you are blocking
        {
            float reducedDamage = damageAmount - (3 * playerStats.playerDefense) - playerStats.playerBlock;
            if (reducedDamage < 0)
            {
                reducedDamage = 0;
            }
            playerStats.playerHealth -= reducedDamage;
            isBlocking = false;
        }
        else //calculation if you are NOT blocking
        {
            float reducedDamage = damageAmount - (3 * playerStats.playerDefense);
            if (reducedDamage < 0)
            {
                reducedDamage = 0;
            }
            playerStats.playerHealth -= reducedDamage;
        }

        if (playerStats.playerHealth < 0)
        {
            playerStats.playerHealth = 0; //preventing negative numbers
        }
    }
        

    //block function
    public void Block (float damageBlock)
    {
        playerStats.playerBlock = damageBlock;
        isBlocking = true;
 

    }

    public void Fireball(float damageAmount)
    {
        DealDamage(damageAmount);
        playerStats.mana = playerStats.mana - 1;
    }


}
