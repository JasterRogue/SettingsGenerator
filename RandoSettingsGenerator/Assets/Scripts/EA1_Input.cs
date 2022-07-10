using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EA1_Input : MonoBehaviour
{
    [SerializeField] InputField ea1Field;

    public string getHintText()
    {
        return ea1Field.text;
    }
}

