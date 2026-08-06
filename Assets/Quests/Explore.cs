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
        questName = "Explore";

        Debug.Log("Quest: " + questName);

    }
    public override void Reward()
    {
        Debug.Log("You feel rewarded");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (questActive == true)
            {
                Debug.Log("Explore the world!");
                Reward();
                questActive = false;
                EndQuest();
            }
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            goodQuest = true;
            Debug.Log("Good quest:" + goodQuest);
        }
        if (Input.GetKeyDown(KeyCode.B))
        { 
            evilQuest = true;
            Debug.Log("Evil quest:" + evilQuest);
        }

    }
}
