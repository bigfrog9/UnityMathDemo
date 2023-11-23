using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lists : MonoBehaviour
{
    //randomly choosing the roll
    private int chestChoice;

    //randomly choosing the object based on what chest
    private int objectChoice;

    //deciding which chest was rolled
    private int chestSelection;

    private int chestTotal;

    private int WoodChest;
    private int BronzeChest;
    private int SilverChest;
    private int GoldChest;
    private int PlatinumChest;

    private int WoodChestTotal;
    private int BronzeChestTotal;
    private int SilverChestTotal;
    private int GoldChestTotal;
    private int PlatinumChestTotal;





    [Header("Wood Chests")]
    public int WoodChestCommon;
    public int WoodChestUncommon;
    public int WoodChestRare;
    public int WoodChestEpic;
    public int WoodChestLegendary;

    [Header("Bronze Chests")]
    public int BronzeChestCommon;
    public int BronzeChestUncommon;
    public int BronzeChestRare;
    public int BronzeChestEpic;
    public int BronzeChestLegendary;

    [Header("Silver Chests")]
    public int SilverChestCommon;
    public int SilverChestUncommon;
    public int SilverChestRare;
    public int SilverChestEpic;
    public int SilverChestLegendary;

    [Header("Gold Chests")]
    public int GoldChestCommon;
    public int GoldChestUncommon;
    public int GoldChestRare;
    public int GoldChestEpic;
    public int GoldChestLegendary;

    [Header("Platinum Chests")]
    public int PlatinumChestCommon;
    public int PlatinumChestUncommon;
    public int PlatinumChestRare;
    public int PlatinumChestEpic;
    public int PlatinumChestLegendary;

    // Start is called before the first frame update
    void Start()
    {
        WoodChest = WoodChestCommon + WoodChestUncommon + WoodChestRare + WoodChestEpic + WoodChestLegendary;
        BronzeChest= BronzeChestCommon + BronzeChestUncommon + BronzeChestRare + BronzeChestEpic + BronzeChestLegendary;
        SilverChest = SilverChestCommon + SilverChestUncommon + SilverChestRare + SilverChestEpic + SilverChestLegendary;
        GoldChest = GoldChestCommon + GoldChestUncommon + GoldChestRare + GoldChestEpic + GoldChestLegendary;
        PlatinumChest= PlatinumChestCommon + PlatinumChestUncommon + PlatinumChestRare + PlatinumChestEpic + PlatinumChestLegendary;

        WoodChestTotal = WoodChestCommon + WoodChestUncommon + WoodChestRare + WoodChestEpic + WoodChestLegendary;
        BronzeChestTotal = WoodChestCommon + WoodChestUncommon + WoodChestRare + WoodChestEpic + WoodChestLegendary + BronzeChestCommon + BronzeChestUncommon + BronzeChestRare + BronzeChestEpic + BronzeChestLegendary;
        SilverChestTotal = WoodChestCommon + WoodChestUncommon + WoodChestRare + WoodChestEpic + WoodChestLegendary + BronzeChestCommon + BronzeChestUncommon + BronzeChestRare + BronzeChestEpic + BronzeChestLegendary + SilverChestCommon + SilverChestUncommon + SilverChestRare + SilverChestEpic + SilverChestLegendary;
        GoldChestTotal = WoodChestCommon + WoodChestUncommon + WoodChestRare + WoodChestEpic + WoodChestLegendary + BronzeChestCommon + BronzeChestUncommon + BronzeChestRare + BronzeChestEpic + BronzeChestLegendary + SilverChestCommon + SilverChestUncommon + SilverChestRare + SilverChestEpic + SilverChestLegendary + GoldChestCommon + GoldChestUncommon + GoldChestRare + GoldChestEpic + GoldChestLegendary;
        PlatinumChestTotal = WoodChestCommon + WoodChestUncommon + WoodChestRare + WoodChestEpic + WoodChestLegendary + BronzeChestCommon + BronzeChestUncommon + BronzeChestRare + BronzeChestEpic + BronzeChestLegendary + SilverChestCommon + SilverChestUncommon + SilverChestRare + SilverChestEpic + SilverChestLegendary + GoldChestCommon + GoldChestUncommon + GoldChestRare + GoldChestEpic + GoldChestLegendary + PlatinumChestCommon + PlatinumChestUncommon + PlatinumChestRare + PlatinumChestEpic + PlatinumChestLegendary;

        chestTotal = WoodChestTotal + BronzeChestTotal + SilverChestTotal + GoldChestTotal + PlatinumChestTotal;

        //List<string> list = new List<string>();
        //list.Add("Wooden Chest");
        //list.Add("Bronze Chest");
        //list.Add("Silver Chest");
        //list.Add("Gold Chest");
        //list.Add("Platinum Chest");
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("space"))
        {
            ChestRoll();
            ObjectRoll();

        }
    }

    void ChestRoll()
    {
        chestChoice = Random.Range(0, chestTotal);

        if (chestChoice <= WoodChestTotal)
        {
            chestSelection = WoodChest;
        }

        else if (chestChoice > WoodChestTotal && chestChoice <= BronzeChestTotal)
        {
            chestSelection = BronzeChest;
        }

        else if (chestChoice > BronzeChestTotal && chestChoice <= SilverChestTotal)
        {
            chestSelection = SilverChest;
        }

        else if (chestChoice> SilverChestTotal && chestChoice <= GoldChestTotal)
        {
            chestSelection = GoldChest;
        }

        else if (chestChoice > GoldChestTotal && chestChoice <= PlatinumChestTotal)
        {
            chestSelection = PlatinumChest;
        }
        //Debug.Log(chestChoice);
    }

    void ObjectRoll()
    {
        if (chestSelection == WoodChest)
        {
            objectChoice = Random.Range(0, WoodChest);

            if (objectChoice <= WoodChestCommon)
            {
                Debug.Log("Wood Chest: Common Item!");
            }

            else if (objectChoice > WoodChestCommon && objectChoice <= WoodChestUncommon)
            {
                Debug.Log("Wood Chest: Uncommon Item!");
            }

            else if (objectChoice > WoodChestUncommon && objectChoice <= WoodChestRare)
            {
                Debug.Log("Wood Chest: Rare Item!");
            }

            else if (objectChoice > WoodChestRare && objectChoice <= WoodChestEpic)
            {
                Debug.Log("Wood Chest: Epic Item!");
            }

            else if (objectChoice > WoodChestRare && objectChoice <= WoodChestLegendary)
            {
                Debug.Log("Wood Chest: Legendary Item!");
            }
        }

        else if (chestSelection == BronzeChest)
        {
            objectChoice = Random.Range(0, BronzeChest);

            if (objectChoice <= BronzeChestCommon)
            {
                Debug.Log("Bronze Chest: Common Item!");
            }

            else if (objectChoice > BronzeChestCommon && objectChoice <= BronzeChestUncommon)
            {
                Debug.Log("Bronze Chest: Uncommon Item!");
            }

            else if (objectChoice > BronzeChestUncommon && objectChoice <= BronzeChestRare)
            {
                Debug.Log("Bronze Chest: Rare Item!");
            }

            else if (objectChoice > BronzeChestRare && objectChoice <= BronzeChestEpic)
            {
                Debug.Log("Bronze Chest: Epic Item!");
            }

            else if (objectChoice > BronzeChestRare && objectChoice <= BronzeChestLegendary)
            {
                Debug.Log("Bronze Chest: Legendary Item!");
            }
        }

        else if (chestSelection == SilverChest)
        {
            objectChoice = Random.Range(0, SilverChest);

            if (objectChoice <= SilverChestCommon)
            {
                Debug.Log("Silver Chest: Common Item!");
            }

            else if (objectChoice > SilverChestCommon && objectChoice <= SilverChestUncommon)
            {
                Debug.Log("Wood Chest: Uncommon Item!");
            }

            else if (objectChoice > SilverChestUncommon && objectChoice <= SilverChestRare)
            {
                Debug.Log("Silver Chest: Rare Item!");
            }

            else if (objectChoice > SilverChestRare && objectChoice <= SilverChestEpic)
            {
                Debug.Log("Silver Chest: Epic Item!");
            }

            else if (objectChoice > SilverChestRare && objectChoice <= SilverChestLegendary)
            {
                Debug.Log("Silver Chest: Legendary Item!");
            }
        }

        else if (chestSelection ==  GoldChest)
        {
            objectChoice = Random.Range(0, GoldChest);

            if (objectChoice <= GoldChestCommon)
            {
                Debug.Log("Gold Chest: Common Item!");
            }

            else if (objectChoice > GoldChestCommon && objectChoice <= GoldChestUncommon)
            {
                Debug.Log("Gold Chest: Uncommon Item!");
            }

            else if (objectChoice > GoldChestUncommon && objectChoice <= GoldChestRare)
            {
                Debug.Log("Gold Chest: Rare Item!");
            }

            else if (objectChoice > GoldChestRare && objectChoice <= GoldChestEpic)
            {
                Debug.Log("Gold Chest: Epic Item!");
            }

            else if (objectChoice > GoldChestRare && objectChoice <= GoldChestLegendary)
            {
                Debug.Log("Gold Chest: Legendary Item!");
            }
        }

        else if (chestSelection == PlatinumChest)
        {
            objectChoice = Random.Range(0, PlatinumChest);

            if (objectChoice <= PlatinumChestCommon)
            {
                Debug.Log("Platinum Chest: Common Item!");
            }

            else if (objectChoice > PlatinumChestCommon && objectChoice <= PlatinumChestUncommon)
            {
                Debug.Log("Platinum Chest: Uncommon Item!");
            }

            else if (objectChoice > PlatinumChestUncommon && objectChoice <= PlatinumChestRare)
            {
                Debug.Log("Platinum Chest: Rare Item!");
            }

            else if (objectChoice > PlatinumChestRare && objectChoice <= PlatinumChestEpic)
            {
                Debug.Log("Platinum Chest: Epic Item!");
            }

            else if (objectChoice > PlatinumChestRare && objectChoice <= PlatinumChestLegendary)
            {
                Debug.Log("Platinum Chest: Legendary Item!");
            }
        } 
    }
}
