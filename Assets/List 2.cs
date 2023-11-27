using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List2 : MonoBehaviour
{
    public string chestAwarded;
    public string prizeAwarded;

    [Header("Chest Type")]
    public int WoodChest;
    public int BronzeChest;
    public int SilverChest;
    public int GoldChest;
    public int PlatinumChest;

    [Header("Wood Drop Type")]
    public int woodChestCommon;
    public int woodChestUncommon;
    public int woodChestRare;
    public int woodChestEpic;
    public int woodChestLegendary;

    [Header("Bronze Drop Type")]

    public int bronzeChestCommon;
    public int bronzeChestUncommon;
    public int bronzeChestRare;
    public int bronzeChestEpic;
    public int bronzeChestLegendary;

    [Header("Silver Drop Type")]

    public int silverChestCommon;
    public int silverChestUncommon;
    public int silverChestRare;
    public int silverChestEpic;
    public int silverChestLegendary;

    [Header("Gold Drop Type")]

    public int goldChestCommon;
    public int goldChestUncommon;
    public int goldChestRare;
    public int goldChestEpic;
    public int goldChestLegendary;

    [Header("Platinum Drop Type")]

    public int platinumChestCommon;
    public int platinumChestUncommon;
    public int platinumChestRare;
    public int platinumChestEpic;
    public int platinumChestLegendary;


    public List<string> ChestPool;
    public List<string> woodChestDrop;
    public List<string> bronzeChestDrop;
    public List<string> silverChestDrop;
    public List <string> goldChestDrop;
    public List<string> platinumChestDrop;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < WoodChest; i++){ChestPool.Add(new string("WoodChest"));}

        for (int i = 0; i < BronzeChest; i++){ChestPool.Add(new string("BronzeChest"));}

        for (int i = 0; i < SilverChest; i++){ChestPool.Add(new string("SilverChest"));}

        for (int i = 0; i < GoldChest; i++){ChestPool.Add(new string("GoldChest"));}

        for (int i = 0; i < PlatinumChest; i++){ChestPool.Add(new string("PlatinumChest"));}

        //Wood

        for (int i = 0; i < woodChestCommon; i++) { woodChestDrop.Add(new string("Common")); }

        for (int i = 0; i < woodChestUncommon; i++) { woodChestDrop.Add(new string("Uncommon")); }

        for (int i = 0; i < woodChestRare; i++) { woodChestDrop.Add(new string("Rare")); }

        for (int i = 0; i < woodChestEpic; i++) { woodChestDrop.Add(new string("Epic")); }

        for (int i = 0; i < woodChestLegendary; i++) { woodChestDrop.Add(new string("Legendary")); }

        //Bronze

        for (int i = 0; i < bronzeChestCommon; i++) { bronzeChestDrop.Add(new string("Common")); }

        for (int i = 0; i < bronzeChestUncommon; i++) { bronzeChestDrop.Add(new string("Uncommon")); }

        for (int i = 0; i < bronzeChestRare; i++) { bronzeChestDrop.Add(new string("Rare")); }

        for (int i = 0; i < bronzeChestEpic; i++) { bronzeChestDrop.Add(new string("Epic")); }

        for (int i = 0; i < bronzeChestLegendary; i++) { bronzeChestDrop.Add(new string("Legendary")); }

        //Silver

        for (int i = 0; i < silverChestCommon; i++) { silverChestDrop.Add(new string("Common")); }

        for (int i = 0; i < silverChestUncommon; i++) { silverChestDrop.Add(new string("Uncommon")); }

        for (int i = 0; i < silverChestRare; i++) { silverChestDrop.Add(new string("Rare")); }

        for (int i = 0; i < silverChestEpic; i++) { silverChestDrop.Add(new string("Epic")); }

        for (int i = 0; i < silverChestLegendary; i++) { silverChestDrop.Add(new string("Legendary")); }


        //Gold

        //Platinum

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            chestAwarded = ChestPool[Random.Range(0, ChestPool.Count)];

            if (chestAwarded == "WoodChest")
            {
                prizeAwarded = woodChestDrop[Random.Range(0, woodChestDrop.Count)];
            }

            else if (chestAwarded == "BronzeChest")
            {
                prizeAwarded = bronzeChestDrop[Random.Range(0, bronzeChestDrop.Count)];
            }

            else if (chestAwarded == "SilverChest")
            {
                prizeAwarded = silverChestDrop[Random.Range(0, silverChestDrop.Count)];
            }

            else if (chestAwarded == "GoldChest")
            {
                prizeAwarded = goldChestDrop[Random.Range(0, goldChestDrop.Count)];
            }

            else if (chestAwarded == "PlatinumChest")
            {
                prizeAwarded = platinumChestDrop[Random.Range(0, platinumChestDrop.Count)];
            }
        }
    }
}
