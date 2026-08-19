using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class UIManager : MonoBehaviour
{
    //Crossscript referencing
    public BattleSystem battleSystem;
    public PlayerStats playerStats;
    public EnemyStats enemyStats;
    public LevellingSystem levellingSysyem;


    //Text boxes
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI playerBasicDamageText;
    public TextMeshProUGUI fireBallText;
    public TextMeshProUGUI blockText;
    public TextMeshProUGUI enemyHealthText;
    public TextMeshProUGUI levelText;
    public TextMeshProUGUI currentRedExperienceText;
    public TextMeshProUGUI currentBlueExperienceText;
    public TextMeshProUGUI currentGreenExperienceText;
    public TextMeshProUGUI currentExperienceText;
    public TextMeshProUGUI experienceNeededText;
    public TextMeshProUGUI defenceText;
    public TextMeshProUGUI manaText;
    public TextMeshProUGUI turnCheckerText;

    public void UpdateUI()
    {
        healthText.text = (int)playerStats.playerHealth + " / " + (int)playerStats.playerMaxHealth + " Health";
        playerBasicDamageText.text = (int)playerStats.playerAttack + " Damage";
        fireBallText.text = (int)playerStats.fireballDamage + " Fire Damage"; 
        blockText.text = (int)playerStats.playerBlock + " Block";
        enemyHealthText.text = (int)enemyStats.enemyHealth + " Enemy Health";
        levelText.text = "Level " + (int)levellingSysyem.playerLevel;
        //currentRedExperienceText.text = (int)levellingSysyem.redXP + " Red XP";
       // currentBlueExperienceText.text = (int)levellingSysyem.blueXP + " Blue XP";
        //currentGreenExperienceText.text = (int)levellingSysyem.greenXP + " green XP";
        //currentExperienceText.text = (int)levellingSysyem.greenXP + (int)levellingSysyem.blueXP + (int)levellingSysyem.redXP + " total XP";
        experienceNeededText.text = (int)levellingSysyem.maxExperience + " Max XP";
        defenceText.text = (int)playerStats.playerDefense + " Defence";
        manaText.text = (int)playerStats.mana + " / " + (int)playerStats.maxMana + " Mana";
        if(battleSystem.isPlayerTurn == true)
        {
            turnCheckerText.text = "PLAYER TURN";
        }
        else
        {
            turnCheckerText.text = "ENEMY TURN";
        }

    }

}

