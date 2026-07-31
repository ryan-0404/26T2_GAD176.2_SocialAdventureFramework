using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Example : MonoBehaviour
{
    PlayerInput playerInput;
    DeedJournal journal;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       playerInput = GameObject.Find("player").GetComponent<PlayerInput>();
        journal = GameObject.Find("journal").GetComponent<DeedJournal>();
    }

    // Update is called once per frame
    void Update()
    {

    }
   
    public void ButtonPress()
    {
        playerInput.OnBasicGoodDeed?.Invoke();
    }
     
}
