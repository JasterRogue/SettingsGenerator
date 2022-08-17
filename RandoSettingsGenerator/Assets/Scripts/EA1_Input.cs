using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EA1_Input : MonoBehaviour
{
    //[SerializeField] InputField ea1Field;
    [SerializeField]Dropdown ea1DropDown; 

   /* public string getEA1Text()
    {
        return ea1Field.text;
    }*/

    public string getEA1DropDownText()
    {
        return ea1DropDown.options[ea1DropDown.value].text;
    }
}

