using System;
using System.Collections.Generic;
using SimpleJSON;

public class GambitContainer : Compressable
{
    List<Gambit> ListOfGambits = new List<Gambit>();

    public string Compress()
    {
        var returnValue = JSON.Parse("{}");
        for (int i = 0; i < ListOfGambits.Count; i++)
        {
            returnValue["Gambits"][-1] = ListOfGambits[i].Compress();
        }
        return returnValue.ToString();
    }

    public void Decompress(string deString)
    {
        var returnValue = JSON.Parse(deString);
        if (returnValue["Gambits"] != null)
        {
            int counter = 0;
            while (returnValue["Gambits"][counter] != null)
            {
                Gambit g = new Gambit();
                g.Decompress(returnValue["Gambits"][counter]);
                ListOfGambits.Add(g);
                ++counter;
            }
        }
    }

    public List<Gambit> S_ListOfGambits
    {
        get { return ListOfGambits; }
        set { ListOfGambits = value; }
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
        Gambit g = null;
        for (int i = 0; i < ListOfGambits.Count; i++)
        {
            if (ListOfGambits[i].IsExists == false)
            {
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

public class Gambit : Compressable
{
    public string Compress()
    {
        var returnValue = JSON.Parse("{}");
        returnValue["gamPos"] = _PositionInGambitDatabase.ToString();
        returnValue["playPos"] = _PositionInPlayerDatabase.ToString();
        returnValue["inUse"] = _InUse.ToString();
        returnValue["isExist"] = _IsExists.ToString();
        return returnValue.ToString();
    }

    public void Decompress(string deString)
    {
        var json = JSON.Parse(deString);

        if (json["gamPos"] != null) _PositionInGambitDatabase = json["gamPos"].AsInt;
        if (json["playPos"] != null) _PositionInPlayerDatabase = json["playPos"].AsInt;
        if (json["inUse"] != null) _InUse = json["inUse"].AsBool;
        if (json["isExist"] != null) _IsExists = json["isExist"].AsBool;

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



