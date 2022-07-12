using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability : MonoBehaviour
{
    private string abilityName, abilityCode;

    /*private void Start()
    {
        Debug.Log("Hey, Ability script here");
    }*/

    public Ability(string name, string code)
    {
        abilityName = name;
        abilityCode = code;
    }
}
