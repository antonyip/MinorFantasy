using System;
using System.Collections.Generic;

public class GambitContainer
{
    List<Gambit> ListOfGambits = new List<Gambit>();

    public int Count
    { 
        get { return ListOfGambits.Count; }
    }

    public Gambit GetGambitAt(int pos)
    {
        return ListOfGambits[pos];
    }

    public void Clear()
    {
        ListOfGambits.Clear();
    }

    public void Add(Gambit gambit)
    {
        bool foundEmptySlot = false;
        Gambit g = null;
        for (int i = 0; i < ListOfGambits.Count; i++)
        {
            if (ListOfGambits[i].IsExists == false)
            {
                foundEmptySlot = true;
                g = ListOfGambits[i];
                break;
            }
        }

        if (g == null)
        {
            gambit.SetPlayerPos(ListOfGambits.Count);
            ListOfGambits.Add(gambit);
        }
        else
        {
            g.ChangeTo(gambit);
        }
    }
}

public class Gambit
{
    int _PositionInGambitDatabase;
    int _PositionInPlayerDatabase;

    public int PositionInGambitDatabase
    {
        get { return _PositionInGambitDatabase; }
    }

    public int PositionInPlayerDatabase
    {
        get { return _PositionInPlayerDatabase; }
    }

    public bool InUse 
    { 
        get { return _InUse;}
    }

    public bool IsExists 
    { 
        get { return _IsExists;}
    }

    public void SetPlayerPos(int pos)
    {
        _PositionInPlayerDatabase = pos;
    }

    public void ChangeTo(Gambit g)
    {
        _PositionInGambitDatabase = g._PositionInGambitDatabase;
        _InUse = g.InUse;
        _IsExists = true;
    }

    /// <summary>
    /// Is the User Using the Gambit on a hero
    /// </summary>
    bool _InUse = false;

    /// <summary>
    /// Does the User Have the Gambit ?
    /// </summary>
    bool _IsExists = true;

    public Gambit(int positionInGambitDatabase)
    {
        Construct(positionInGambitDatabase, -1, false, false);
    }

    public Gambit(int positionInGambitDatabase, int positionInPlayerDatabase)
    {
        Construct(positionInGambitDatabase, positionInPlayerDatabase, false, true);
    }

    public Gambit(int positionInGambitDatabase, int positionInPlayerDatabase, bool inUse, bool isExists)
    {
        Construct(positionInGambitDatabase, positionInPlayerDatabase, inUse, isExists);
    }

    public void Construct(int positionInGambitDatabase, int positionInPlayerDatabase, bool inUse, bool isExists)
    {
        _PositionInGambitDatabase = positionInGambitDatabase;
        _PositionInPlayerDatabase = positionInPlayerDatabase;
        _InUse = inUse;
        _IsExists = isExists;
    }
}



