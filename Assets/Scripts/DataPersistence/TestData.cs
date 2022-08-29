using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TestData : MonoBehaviour
{
    [Header("Data Settings")]
    [SerializeField]
    private int deathCount;
    [SerializeField]
    private Vector3 playerPosition;
    [SerializeField]
    private int[] cells;
    [SerializeField]
    private SerializableDictionary<string, bool> coinsCollected;
    [SerializeField]
    private List<string> names;
    [Header("File Settings")]
    [SerializeField]
    private string fileName= "";
    [SerializeField]
    private string encryptionCodeWord="";
    private FileDataHandler dataHandler;
    private void Start()
    {
        dataHandler = new FileDataHandler(Application.persistentDataPath, fileName, encryptionCodeWord);
        StaticGameData.gameData = dataHandler.Load();
        if (StaticGameData.gameData == null)
        {
            Debug.Log("No data found.Initializing data to defaults.");
            StaticGameData.gameData = new GameData();
        }
        deathCount = StaticGameData.gameData.deathCount;
        playerPosition = StaticGameData.gameData.playerPosition;
        coinsCollected = StaticGameData.gameData.coinsCollected;
        if (!coinsCollected.ContainsKey("qwe"))
            coinsCollected.Add("qwe",true);
        cells = StaticGameData.gameData.cells;
        names = StaticGameData.gameData.names;
    }
    private void Update()
    {
        StaticGameData.gameData.deathCount = deathCount;
        StaticGameData.gameData.playerPosition=playerPosition ;
        StaticGameData.gameData.cells = cells;
        StaticGameData.gameData.names = names;
        StaticGameData.gameData.coinsCollected = coinsCollected;
    }
    private void OnApplicationQuit()
    {
        dataHandler.Save(StaticGameData.gameData);
    }
}
