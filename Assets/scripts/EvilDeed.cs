using UnityEngine;
using UnityEngine.InputSystem;

public class EvilDeed : Deeds
{
    public LevellingSystem level;

    public virtual void ApplySmallDeed()
    {
        moralPoint = -1;
        level.evilXP += 10 * level.evilXPGain;
        DeedDone(moralPoint);
        journal.AddDeed("Minor Evil Deed:", moralPoint);

    }

    public virtual void ApplyBasicDeed()
    {
        moralPoint = -10;
        level.evilXP += 30 * level.evilXPGain;
        DeedDone(moralPoint);
        journal.AddDeed("standard Evil Deed:", moralPoint);

    }

    public virtual void ApplyGreatDeed()
    {
        moralPoint = -100;
        level.evilXP += 50 * level.evilXPGain;
        DeedDone(moralPoint);
        journal.AddDeed("Great Evil Deed:", moralPoint);

    }
}
