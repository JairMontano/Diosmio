using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Cards", menuName = "Cartas/CreaCarta")]
public class Cards : ScriptableObject
{
    
    public int numeroDeCarta;
    public string tituloDeCarta;
    public Sprite cardImg;
    public string texto;
}
