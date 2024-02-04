using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public string playerId;
    public int level;
    public int gold;

    public PlayerData(string playerId, int level, int gold)
    {
        this.playerId = playerId;
        this.level = level;
        this.gold = gold;
    }
}
