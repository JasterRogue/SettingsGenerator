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
        print("Creating ability list");
        a = new Ability[36];

        a[0] = new Ability("Treasure Magnet", "85");
        a[1] = new Ability("Combo Plus", "86");
        a[2] = new Ability("Air Combo Plus", "87");
        a[3] = new Ability("Critical Plus", "88");
        a[4] = new Ability("Second Wind", "89");
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
        a[35] = new Ability("Combo Master", "C1");

        //call the generate method to create the settings file
        generate();

        
    }//end of start()

    private void generate()
    {
        //start info; 
        //Variables for settings file
        string startInfo = "c Prevent select key items from being randomized\n" +
            "c Item ID reference: https://pastebin.com/dfARF8ui \n" +
            "c D9 corresponds to a random slide, DF corresponds to a random evidence\n" +
            "c For example, if you want to unrandomize slide, evidence and entry pass:" +
            "c Unrandomize = D9 DF E5";

        //next options to unlock DJ, OC and WL
        string unlockedWorlds = "Unrandomize = ";
        int djValue = myDJSlider.getDJSliderValue();
        int wlValue = myWLSlider.getWLSliderValue();
        int ocValue = myOlympusSlider.getOCSliderValue();

        if (djValue == 1)
        {
            //Unlock Deep Jungle
            unlockedWorlds += "D9 ";
        }

        if (wlValue == 1)
        {
            //Unlock Wonderland
            unlockedWorlds += "DF";
        }

        if (ocValue == 1)
        {
            //Unlock Olympus Coliseum
            unlockedWorlds += "E5";
        }

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

        //check if string is blank first
        if (ea1 != "")
        {
            string currentAbiltiyName = ""; 

            for (int i = 0; i < a.Length; i++)
            {
                Debug.Log("a: " + a[0]);
                currentAbiltiyName = a[i].ToString();
                Debug.Log("Current Abiltiy Value:" + currentAbiltiyName);
            }
        }


    }//end of generate()

}//end of class
