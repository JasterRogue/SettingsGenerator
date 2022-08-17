using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EA3_Input : MonoBehaviour
{
    //[SerializeField] InputField ea1Field;
    [SerializeField] Dropdown ea3DropDown;

    /* public string getEA1Text()
     {
         return ea1Field.text;
     }*/

    public string getEA3DropDownText()
    {
        return ea3DropDown.options[ea3DropDown.value].text;
    }
}