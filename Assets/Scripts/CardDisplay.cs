using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.Collections.LowLevel.Unsafe;

public class CardDisplay : MonoBehaviour
{

    [SerializeField] private Cards cards;
    [SerializeField] private TMP_Text numeroDeCartaText;
    [SerializeField] private TMP_Text tituloDeCartaText;
    [SerializeField] private Image imageCard;
    [SerializeField] private TMP_Text textoText;

    private void Start()
    {
        numeroDeCartaText.text = "N. de carta " + cards.numeroDeCarta.ToString();
        numeroDeCartaText.text = cards.tituloDeCarta;
        imageCard.sprite = cards.cardImg;
        numeroDeCartaText.text = cards.texto;
    }

}
