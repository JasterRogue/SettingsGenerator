using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EA2_Input : MonoBehaviour
{
    [SerializeField] InputField ea2Field;

    public string getEA2Text()
    {
        return ea2Field.text;
    }
}
