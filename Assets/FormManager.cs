using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FormManager : MonoBehaviour
{
    public TMP_InputField firstInput;

    private void OnEnable()
    {
        firstInput.Select();
    }
}


