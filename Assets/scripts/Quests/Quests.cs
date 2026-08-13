using UnityEngine;
using UnityEngine.Events;

public class Quests : MonoBehaviour
{

	public UnityEvent questComplete;
	public PlayerInput playerInput;


    //The name of the quest: can be changed
    protected string questName;

	//Acts as the main form of setting the quest as active or not
	protected bool questActive;

	/// <summary>
	/// Replaceable for rewarding the player upon quest completion
	/// </summary>
	public virtual void Reward()
	{
		Debug.Log("Reward collected");
        if (evilQuest == true)
        {
            if (questLevel == 1)
            {
                playerInput.OnSmallEvilDeed?.Invoke();
            }

            else if (questLevel == 2)
            {
                playerInput.OnBasicEvilDeed?.Invoke();
            }

            else if (questLevel == 3)
            {
                playerInput.OnGreatEvilDeed.Invoke();
            }

        }
        if (goodQuest == true)
        {
            if (questLevel == 1)
            {
                playerInput.OnSmallGoodDeed?.Invoke();
            }

            else if (questLevel == 2)
            {
                playerInput.OnBasicGoodDeed?.Invoke();
            }

            else if (questLevel == 3)
            {
                playerInput.OnGreatGoodDeed.Invoke();
            }
        }
    }
	/// <summary>
	/// will end the quest
	/// </summary>
	public void EndQuest()
	{
		questComplete?.Invoke();
		questActive = false;
		
	}
	//Bools that indicate if the quest is good o evil
	public bool evilQuest;
	public bool goodQuest;
	public int questLevel;
}
