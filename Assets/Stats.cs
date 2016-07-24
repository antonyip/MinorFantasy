using UnityEngine;
using System.Collections;

public class Stats
{
    protected int Attack { get; set; }
    protected int Defence { get; set; }
    protected int Str { get; set; }
    protected int Dex { get; set; }
    protected int Int { get; set; }
    protected int Luk { get; set; }
}

public sealed class EquipmentStats : Stats
{
    
}

public sealed class CharacterStats : Stats
{
    public int Level { get; private set; }
    public int HP { get; private set; }
    public int MaxHP { get; private set; }
    public int Energy { get; private set; }
    public int MaxEnergy { get; private set; }
    EquipmentStats equipmentStats;
}

public class Character
{
    CharacterStats characterStats;
}