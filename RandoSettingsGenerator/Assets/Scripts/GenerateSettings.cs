using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//The main script that is used to generate the settings

public class GenerateSettings : MonoBehaviour
{
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
        Ability[] a = new Ability[61];
        a[0] = new Ability("Treasure Magnet", "85");
        a[1] = new Ability("Combo Plus", "86");


        
    }
}
