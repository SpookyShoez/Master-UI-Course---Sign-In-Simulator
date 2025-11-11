using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerCardManager : MonoBehaviour
{
    public TMP_Text nameText;
    public void UpdateName(string newName)
    {
        nameText.text = newName;
    }
}
