using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainMenu_UIManager : MonoBehaviour
{
    public TextMeshProUGUI companyNameField;
    public TextMeshProUGUI versionNumberField;

    public void Start(){
      companyNameField.text = Application.companyName;
      versionNumberField.text = Application.version;
    }
}
