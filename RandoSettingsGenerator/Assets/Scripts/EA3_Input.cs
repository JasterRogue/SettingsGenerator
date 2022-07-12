using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EA3_Input : MonoBehaviour
{
    [SerializeField] InputField ea3Field;

    public string getEA3Text()
    {
        return ea3Field.text;
    }
}