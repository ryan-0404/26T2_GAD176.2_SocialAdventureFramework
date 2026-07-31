using UnityEngine;
using UnityEngine.InputSystem;

public class EvilDeed : Deeds
{
    public virtual void ApplySmallDeed()
    {
        moralPoint = -1;
        DeedDone(moralPoint);
        journal.AddDeed("Minor Evil Deed:", moralPoint);

    }

    public virtual void ApplyBasicDeed()
    {
        moralPoint = -10;
        DeedDone(moralPoint);
        journal.AddDeed("standard Evil Deed:", moralPoint);

    }

    public virtual void ApplyGreatDeed()
    {
        moralPoint = -100;
        DeedDone(moralPoint);
        journal.AddDeed("Great Evil Deed:", moralPoint);

    }
}
