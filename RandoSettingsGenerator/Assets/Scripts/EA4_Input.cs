using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EA4_Input : MonoBehaviour
{
    //[SerializeField] InputField ea1Field;
    [SerializeField] Dropdown ea4DropDown;

    /* public string getEA1Text()
     {
         return ea1Field.text;
     }*/

    public string getEA4DropDownText()
    {
        return ea4DropDown.options[ea4DropDown.value].text;
    }
}
