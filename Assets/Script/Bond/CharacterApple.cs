using SAE.GAD176.Scripting2.Project2.CharacterBondSystem;
using UnityEngine;

public class CharacterApple : CharacterStats
{
    
    void Start()
    {
        characterName = gameObject.name;
        friendLevel = 0;
        bondExperience = 0;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            ChangeBondExperience();
        }
    }
    public void ChangeBondExperience() // Function to change xp. Maybe this could have a parameter?
    {
        bondExperience += 15; // quest reward exp
        Debug.Log("Quest complete. Bond experience increased to: " + bondExperience);

        if (bondExperience >= 100)
        {
            friendLevel += 1;
            Debug.Log("Bond Level increased to: " + friendLevel + " with " + characterName);
            bondExperience -= 100;
        }
    }
}