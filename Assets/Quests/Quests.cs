using UnityEngine;
using UnityEngine.Events;

public class Quests : MonoBehaviour
{

	public UnityEvent questComplete;

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
	}
	/// <summary>
	/// will end the quest
	/// </summary>
	public void EndQuest()
	{
		questComplete?.Invoke();
		questActive = false;
		if (evilQuest == true)
		{

		}
		if (goodQuest == true) 
		{

		}
	}
	//Bools that indicate if the quest is good o evil
	public bool evilQuest;
	public bool goodQuest;
	public int questLevel;
}
