using UnityEngine;
using UnityEngine.InputSystem;
//Attention coder if you are reading this you are trying to change or add to this script.
//I would like to let you know that when I wrote this code only god and I knew it
//Now only God knows how it works.
//Good luck
public class Explore : Quests
{
    //The quest that focuses on the player exploring

    void Start()
    {
        questActive = true;
        Name = "Explore";

        Debug.Log("Quest: " + Name);

    }
    public override void Reward()
    {
        Debug.Log("You feel rewarded");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (questActive == true)
            {
                Debug.Log("Explore the world!");
                Reward();
                questActive = false;
                EndQuest();
            }
        }

    }
}
