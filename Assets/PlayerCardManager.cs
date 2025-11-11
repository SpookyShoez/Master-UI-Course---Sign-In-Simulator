using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerCardManager : MonoBehaviour
{
    public TMP_Text nameText;
    public TMP_Text descriptionText;
    public TMP_Text ageText;

    public void UpdateName(string newName)
    {
        nameText.text = newName;
    }

    public void UpdateDescription(string newDescription)
    {
        descriptionText.text = newDescription;
    }

    public void UpdateAge(float newValue)
    {
        ageText.text = newValue.ToString() + " years old";
    }
}
