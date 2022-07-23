using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//The main script that is used to generate the settings

public class GenerateSettings : MonoBehaviour
{
    

    //Script references
    AtlanticaSlider myAtlanticaSlider;
    AWSlider myAWSlider;
    DIGoSlider myDIGOSlider;
    DJSlider myDJSlider;
    EA1_Input myEA1_Input;
    EA2_Input myEA2_Input;
    EA3_Input myEA3_Input;
    EA4_Input myEA4_Input;
    FinalRestSlider myFinalRestSlider;
    HadesCupSlider myHadesCupSlider;
    HBGoSlider myHBGoSlider;
    HintInput myHintInput;
    HTSlider myHTSlider;
    MovementSlider myMovementSlider;
    OlympusSlider myOlympusSlider;
    SaveWarpSlider mySaveWarpSlider;
    ShopRandoSlider myShopRandoSlider;
    WeaponStatSlider myWeaponStatSlider;
    WLSlider myWLSlider;

    Ability[] a;
    String[] abiltiyNames;
    String[] abilityCodes;

    // Start is called before the first frame update
    void Start()
    {
        //Get access to each script
        myAtlanticaSlider = GameObject.FindObjectOfType<AtlanticaSlider>();
        myAWSlider = GameObject.FindObjectOfType<AWSlider>();
        myDIGOSlider = GameObject.FindObjectOfType<DIGoSlider>();
        myDJSlider = GameObject.FindObjectOfType<DJSlider>();
        myEA1_Input = GameObject.FindObjectOfType<EA1_Input>();
        myEA2_Input = GameObject.FindObjectOfType<EA2_Input>();
        myEA3_Input = GameObject.FindObjectOfType<EA3_Input>();
        myEA4_Input = GameObject.FindObjectOfType<EA4_Input>();
        myFinalRestSlider = GameObject.FindObjectOfType<FinalRestSlider>();
        myHadesCupSlider = GameObject.FindObjectOfType<HadesCupSlider>();
        myHBGoSlider = GameObject.FindObjectOfType<HBGoSlider>();
        myHintInput = GameObject.FindObjectOfType<HintInput>();
        myHTSlider = GameObject.FindObjectOfType<HTSlider>();
        myMovementSlider = GameObject.FindObjectOfType<MovementSlider>();
        myOlympusSlider = GameObject.FindObjectOfType<OlympusSlider>();
        mySaveWarpSlider = GameObject.FindObjectOfType<SaveWarpSlider>();
        myShopRandoSlider = GameObject.FindObjectOfType<ShopRandoSlider>();
        myWeaponStatSlider = GameObject.FindObjectOfType<WeaponStatSlider>();
        myWLSlider = GameObject.FindObjectOfType<WLSlider>();

        //Create ability list
        abiltiyNames[0] = "Treasure Magnet";
        abiltiyNames[1] = "Combo Plus";
        abiltiyNames[2] = "Air Combo Plus";
        abiltiyNames[3] = "Critical Plus";
        abiltiyNames[4] = "Scan";
        abiltiyNames[5] = "Sonic Blade";
        abiltiyNames[6] = "Ars Arcanum";
        abiltiyNames[7] = "Strike Raid";
        abiltiyNames[8] = "Ragnarok";
        abiltiyNames[9] = "Trinity Limit";
        abiltiyNames[10] = "Cheer";
        abiltiyNames[11] = "Vortex";
        abiltiyNames[12] = "Aerial Sweep";
        abiltiyNames[13] = "Counterattack";
        abiltiyNames[14] = "Blitz";
        abiltiyNames[15] = "Guard";
        abiltiyNames[16] = "Dodge Roll";
        abiltiyNames[17] = "MP Haste";
        abiltiyNames[18] = "MP Rage";
        abiltiyNames[19] = "Second Chance";
        abiltiyNames[20] = "Berserk";
        abiltiyNames[21] = "Jackpot";
        abiltiyNames[22] = "Lucky Strike";
        abiltiyNames[23] = "Slapshot";
        abiltiyNames[24] = "Sliding Dash";
        abiltiyNames[25] = "Hurricane Blast";
        abiltiyNames[26] = "Ripple Drive";
        abiltiyNames[27] = "Stun Impact";
        abiltiyNames[28] = "Gravity Break";
        abiltiyNames[29] = "Zantetsuken";
        abiltiyNames[30] = "Tech Boost";
        abiltiyNames[31] = "Encounter Plus";
        abiltiyNames[32] = "Leaf Bracer";
        abiltiyNames[33] = "EXP Zero";
        abiltiyNames[34] = "Combo Master";

        //create ability code list
        abilityCodes[0] = "85";
        abilityCodes[1] = "86";
        abilityCodes[2] = "87";
        abilityCodes[3] = "88";
        abilityCodes[4] = "8A";
        abilityCodes[5] = "8B";
        abilityCodes[6] = "8C";
        abilityCodes[7] = "8D";
        abilityCodes[8] = "8E";
        abilityCodes[9] = "8F";
        abilityCodes[10] = "90";
        abilityCodes[11] = "91";
        abilityCodes[12] = "92";
        abilityCodes[13] = "93";
        abilityCodes[14] = "94";
        abilityCodes[15] = "95";
        abilityCodes[16] = "96";
        abilityCodes[17] = "97";
        abilityCodes[18] = "98";
        abilityCodes[19] = "99";
        abilityCodes[20] = "9A";
        abilityCodes[21] = "9B";
        abilityCodes[22] = "9C";
        abilityCodes[23] = "B5";
        abilityCodes[24] = "B6";
        abilityCodes[25] = "B7";
        abilityCodes[26] = "B8";
        abilityCodes[27] = "B9";
        abilityCodes[28] = "BA";
        abilityCodes[39] = "BB";
        abilityCodes[30] = "BC";
        abilityCodes[31] = "BD";
        abilityCodes[32] = "BE";
        abilityCodes[33] = "C0";
        abilityCodes[34] = "C1";

        print("Creating ability list");
        /*a = new Ability[35];

        a[0] = new Ability("Treasure Magnet", "85");
        a[1] = new Ability("Combo Plus", "86");
        a[2] = new Ability("Air Combo Plus", "87");
        a[3] = new Ability("Critical Plus", "88");
        a[5] = new Ability("Scan", "8A");
        a[6] = new Ability("Sonic Blade", "8B");
        a[7] = new Ability("Ars Arcanum", "8C");
        a[8] = new Ability("Strike Raid", "8D");
        a[9] = new Ability("Ragnarok", "8E");
        a[10] = new Ability("Trinity Limit", "8F");
        a[11] = new Ability("Cheer", "90");
        a[12] = new Ability("Vortex", "91");
        a[13] = new Ability("Aerial Sweep", "92");
        a[14] = new Ability("Counterattack", "93");
        a[15] = new Ability("Blitz", "94");
        a[16] = new Ability("Guard", "95");
        a[17] = new Ability("Dodge Roll", "96");
        a[18] = new Ability("MP Haste", "97");
        a[19] = new Ability("MP Rage", "98");
        a[20] = new Ability("Second Chance", "99");
        a[21] = new Ability("Berserk", "9A");
        a[22] = new Ability("Jackpot", "9B");
        a[23] = new Ability("Lucky Strike", "9C");
        a[24] = new Ability("Slapshot", "B5");
        a[25] = new Ability("Sliding Dash", "B6");
        a[26] = new Ability("Hurricane Blast", "B7");
        a[27] = new Ability("Ripple Drive", "B8");
        a[28] = new Ability("Stun Impact", "B9");
        a[29] = new Ability("Gravity Break", "BA");
        a[30] = new Ability("Zantetsuken", "BB");
        a[31] = new Ability("Tech Boost", "BC");
        a[32] = new Ability("Encounter Plus", "BD");
        a[33] = new Ability("Leaf Bracer", "BE");
        a[34] = new Ability("EXP Zero", "C0");
        a[35] = new Ability("Combo Master", "C1");*/

        //call the generate method to create the settings file
        generate();

        
    }//end of start()

    public void generate()
    {
        //start info; 
        //Variables for settings file
        string startInfo = "c Prevent select key items from being randomized\n" +
            "c Item IDs are listed in items.txt\n" +
            "c Available options: BC, BD, BE, BF, C0, C1, C2, C3, C4, C5, C6, C7, CD, E5\n" +
            "c For example, if you want to unrandomize Entry Pass and Navi-Gummi:\n" +
            "c Unrandomize = CD E5";

        //next options to unlock DJ, OC and WL
        string unlockedWorlds = "";
        string requiredSlides = "";
        string requiredEvidence = "RequiredEvidence = ";
        int djValue = myDJSlider.getDJSliderValue();
        int wlValue = myWLSlider.getWLSliderValue();
        int ocValue = myOlympusSlider.getOCSliderValue();

        

        if (ocValue == 1)
        {
            //Unlock Olympus Coliseum
            unlockedWorlds += "E5";
        }

        string slideEvidenceInfo = "c Define how many slides are required to progress Deep Jungle\n" +
            "c And how many evidence is required to progress Wonderland\n " +
            "c All 4 evidence and 6 slides will be randomized and accessible regardless\n" +
            "c Slides must be picked up in Deep Jungle after meeting the condition, and must be picked up to progress\n" +
            "c This is to avoid rare softlocks that happened previously\n" +
            "c Evidence also becomes available for pick up after meeting condition, but is unnecessary to pick up";
        
        //Slides and Evidence Required
        requiredSlides += "\n\nRequiredSlides" + djValue.ToString();

        requiredEvidence += "\n\nRequiredEvidence" + wlValue.ToString();

        //early abiltiy info
        string earlyAbilityInfo = "c If you want guaranteed abilities on first level ups, put the hex codes for unequipped abilities here.\n" +
            "c Maximum 4 or they will replace other abilities." +
            "c Find ability codes here https://pastebin.com/ZH0L3XXi \n" +
            "c Scroll down for the Not Equipped versions.\n" +
            "c For example, early scan and dodge roll would be:\n" +
            "c EarlyAbilities = 8A 96";

        //select early abilities
        string ea1 = myEA1_Input.getEA1Text();
        string ea2 = myEA2_Input.getEA2Text();
        string ea3 = myEA3_Input.getEA3Text();
        string ea4 = myEA4_Input.getEA4Text();
        string earlyAbilities = "EarlyAbilities = ";

        //check if string is blank first
        if (ea1 != "")
        {
            for (int i = 0; i < abiltiyNames.Length; i++)
            {
                Debug.Log("Current Abiltiy: " + abiltiyNames[0]);
                if (abiltiyNames[i].Equals(ea1))
                {
                    earlyAbilities += abilityCodes[i] + " "; 
                }
                
            }
        }


    }//end of generate()

}//end of class
