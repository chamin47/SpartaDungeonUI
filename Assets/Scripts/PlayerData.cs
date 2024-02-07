using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public string playerId;
    public int level;
    public int gold;
    public int Atk;
    public int Def;
    public int Hp;
    public int Critical;

    public PlayerData(string playerId, int level, int gold, int Atk, int Def, int Hp, int Critical)
    {
        this.playerId = playerId;
        this.level = level;
        this.gold = gold;
        this.Atk = Atk;
        this.Def = Def;
        this.Hp = Hp;
        this.Critical = Critical;
    }
}
