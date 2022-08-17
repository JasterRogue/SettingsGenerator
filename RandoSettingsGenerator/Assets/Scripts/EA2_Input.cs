using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EA2_Input : MonoBehaviour
{
    //[SerializeField] InputField ea1Field;
    [SerializeField] Dropdown ea2DropDown;

    /* public string getEA1Text()
     {
         return ea1Field.text;
     }*/

    public string getEA2DropDownText()
    {
        return ea2DropDown.options[ea2DropDown.value].text;
    }
}
