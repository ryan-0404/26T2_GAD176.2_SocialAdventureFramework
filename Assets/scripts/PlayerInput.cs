using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

public class PlayerInput : MonoBehaviour
{
    public DeedJournal journal;
    public GoodDeed goodDeed;
    public EvilDeed evilDeed;
    public UnityEvent OnSmallGoodDeed;
    public UnityEvent OnBasicGoodDeed;
    public UnityEvent OnGreatGoodDeed;
    public UnityEvent OnSmallEvilDeed;
    public UnityEvent OnBasicEvilDeed;
    public UnityEvent OnGreatEvilDeed;

    public void OnEnable()
    {
        //good deeds
        if (OnSmallGoodDeed != null)
        {
            OnSmallGoodDeed.AddListener(goodDeed.ApplySmallDeed);
            OnSmallGoodDeed.AddListener(UpdateMorality);
        }
        if (OnBasicGoodDeed != null)
        {
            OnBasicGoodDeed.AddListener(goodDeed.ApplyBasicDeed);
            OnBasicGoodDeed.AddListener (UpdateMorality);
        }
        if (OnGreatGoodDeed != null)
        {
            OnGreatGoodDeed.AddListener(goodDeed.ApplyGreatDeed);
            OnGreatGoodDeed .AddListener(UpdateMorality);
        }
        //evil deeds
        if (OnSmallEvilDeed != null)
        {
            OnSmallEvilDeed.AddListener(evilDeed.ApplySmallDeed);
            OnSmallEvilDeed .AddListener(UpdateMorality);
        }
        if (OnBasicGoodDeed != null)
        {
            OnBasicEvilDeed.AddListener(evilDeed.ApplyBasicDeed);
            OnBasicEvilDeed.AddListener(UpdateMorality) ;
        }
        if (OnGreatEvilDeed != null)
        {
            OnGreatEvilDeed.AddListener(evilDeed.ApplyGreatDeed);
            OnGreatEvilDeed.AddListener(UpdateMorality);
        }
    }

    public void OnDisable()
    {
        //good deeds
        if(OnSmallGoodDeed != null)
        {
            OnSmallGoodDeed.RemoveAllListeners();
        }
        if (OnBasicGoodDeed != null)
        {
            OnBasicGoodDeed.RemoveAllListeners();
        }
        if (OnGreatGoodDeed != null)
        {
            OnGreatGoodDeed.RemoveAllListeners();
        }
        //evil deeds
        if (OnSmallEvilDeed != null)
        {
            OnSmallEvilDeed.RemoveAllListeners();
        }
        if (OnBasicEvilDeed != null)
        {
            OnBasicEvilDeed.RemoveAllListeners();
        }
        if (OnGreatEvilDeed != null)
        {
            OnGreatEvilDeed.RemoveAllListeners();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.qKey.wasPressedThisFrame)
        {
            OnSmallGoodDeed?.Invoke();
        }
        if (Keyboard.current.wKey.wasPressedThisFrame) 
        {
            OnBasicGoodDeed?.Invoke();

        }
        if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            OnGreatGoodDeed?.Invoke();
        }
        // evil
        if (Keyboard.current.zKey.wasPressedThisFrame)
        {
            OnSmallEvilDeed?.Invoke();
        }
        if (Keyboard.current.xKey.wasPressedThisFrame)
        {
            OnBasicEvilDeed?.Invoke();

        }
        if (Keyboard.current.cKey.wasPressedThisFrame)
        {
            OnGreatEvilDeed?.Invoke();
        }
    }


    private void UpdateMorality()
    {
        Debug.Log("Your Morality is: " + (goodDeed.moralScore + evilDeed.moralScore));

    }
}
