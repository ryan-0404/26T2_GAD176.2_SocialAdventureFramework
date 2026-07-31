using UnityEngine;

public class Quests : MonoBehaviour
{

	//The name of the quest: can be changed
	protected string Name;

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
		questActive = false;
	}
}
