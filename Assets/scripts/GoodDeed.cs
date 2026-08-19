using UnityEngine;
using UnityEngine.InputSystem;

public class GoodDeed : Deeds
{
    public LevellingSystem level;

    public int test;
    

    public virtual void ApplySmallDeed()
    {
        moralPoint = 1;
        DeedDone(moralPoint);
        level.goodXP += 10 * level.goodXPGain;
        journal.AddDeed("Minor Good Deed:", moralPoint);
    }

    public virtual void ApplyBasicDeed()
    {
        moralPoint = 10;
        level.goodXP += 25 * level.goodXPGain;
        DeedDone(moralPoint);
        journal.AddDeed("standard Good Deed:", moralPoint);

    }

    public virtual void ApplyGreatDeed()
    {
        moralPoint = 100;
        level.goodXP += 50 * level.goodXPGain;
        DeedDone(moralPoint);
        journal.AddDeed("Great Good Deed:", moralPoint);

    }
}