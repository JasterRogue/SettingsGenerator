using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EA4_Input : MonoBehaviour
{
    [SerializeField] InputField ea4Field;

    public string getEA4Text()
    {
        return ea4Field.text;
    }
}
