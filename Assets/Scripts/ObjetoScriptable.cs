using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ObjetoScriptable", menuName = "Menu1/Menu2")]
public class ObjetoScriptable : ScriptableObject
{
    public int dosis = 0;

    public string nombre = "Afivorin";

    public int usos = 0;

    public Sprite img;
}