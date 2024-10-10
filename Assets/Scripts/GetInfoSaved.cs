using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GetInfoSaved : MonoBehaviour
{
    [SerializeField] private TMP_Text nameText;
    [SerializeField] private TMP_Text claseText;
    private new string name;
    private string clase;

    public void Start()
    {
        nameText.text = PlayerPrefs.GetString("name");
        claseText.text = PlayerPrefs.GetString("clase");
    }
}
