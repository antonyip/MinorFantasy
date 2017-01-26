using System;
using System.Collections.Generic;

[System.Serializable]
public class GambitContainer
{
    List<Gambit> ListOfGambits = new List<Gambit>();

    public List<Gambit> S_ListOfGambits
    {
        get { return ListOfGambits; }
        set { S_ListOfGambits = value; }
    }

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

[System.Serializable]
public class Gambit
{
    public int S_PositionInGambitDatabase
    {
        get { return _PositionInGambitDatabase; }
        set { _PositionInGambitDatabase = value; }
    }

    public int S_PositionInPlayerDatabase
    {
        get { return _PositionInPlayerDatabase; }
        set { _PositionInPlayerDatabase = value; }
    }

    public bool S_InUse
    {
        get { return _InUse; }
        set { _InUse = value; }
    }

    public bool S_IsExists
    {
        get { return _IsExists; }
        set { _IsExists = value; }
    }

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

    public void SetInUse()
    {
        _InUse = true;
    }

    public void RemoveFromUse()
    {
        _InUse = false;
    }

    /// <summary>
    /// Is the User Using the Gambit on a hero
    /// </summary>
    bool _InUse = false;

    /// <summary>
    /// Does the User Have the Gambit ?
    /// </summary>
    bool _IsExists = true;

    public Gambit()
    {
        Construct(-1, -1, false, false);
    }

    public Gambit(int positionInGambitDatabase)
    {
        Construct(positionInGambitDatabase, -1, false, true);
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



