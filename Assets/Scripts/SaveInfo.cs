using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SaveInfo : MonoBehaviour
{
    [SerializeField] private TMP_InputField nameInput;
    [SerializeField] private TMP_InputField claseInput;
    private new string name;
    private string clase;

   

    public void SaveInfoBtn()
    {
        PlayerPrefs.SetString("name", nameInput.text);
        PlayerPrefs.SetString("clase", claseInput.text);

        
    }
}
