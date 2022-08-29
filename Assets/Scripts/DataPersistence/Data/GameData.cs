using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class GameData 
{
    public int deathCount;
    public Vector3 playerPosition;
    public int[] cells;
    public SerializableDictionary<string, bool> coinsCollected;
    public List<string> names;
    public GameData()
    {
        this.deathCount = 0;
        this.playerPosition = Vector3.zero;
        cells = new int[0];
        coinsCollected = new SerializableDictionary<string, bool>();
        names = new List<string>();
    }
}
[System.Serializable]
public static class StaticGameData
{
    public static GameData gameData;
}

