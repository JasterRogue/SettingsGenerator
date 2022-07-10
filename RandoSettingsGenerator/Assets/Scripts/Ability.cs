using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability : MonoBehaviour
{
    private string abilityName, abilityCode;

    public Ability(string name, string code)
    {
        abilityName = name;
        abilityCode = code;
    }
}
