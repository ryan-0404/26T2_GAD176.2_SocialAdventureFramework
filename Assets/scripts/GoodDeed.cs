using UnityEngine;
using UnityEngine.InputSystem;

public class GoodDeed : Deeds
{
    public int test;
    

    public virtual void ApplySmallDeed()
    {

        moralPoint = 1;
        DeedDone(moralPoint);

        journal.AddDeed("Minor Good Deed:", moralPoint);
    }

    public virtual void ApplyBasicDeed()
    {
        moralPoint = 10;
        DeedDone(moralPoint);
        journal.AddDeed("standard Good Deed:", moralPoint);

    }

    public virtual void ApplyGreatDeed()
    {
        moralPoint = 100;
        DeedDone(moralPoint);
        journal.AddDeed("Great Good Deed:", moralPoint);

    }
}