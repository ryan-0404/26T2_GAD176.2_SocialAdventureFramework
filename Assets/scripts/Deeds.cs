using UnityEngine;

public class Deeds : MonoBehaviour
{
    public DeedJournal journal;
    public PlayerInput playerInput;
    public int moralScore = 0; //players score
    public int moralPoint = 0; // score of action

    
    
   public void DeedDone(int moralPoint)
    {
        moralScore += moralPoint;
    }
}
