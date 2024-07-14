using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundsDisplay : MonoBehaviour
{
    Text roundsText;
    private void Awake()
    {
        roundsText = GetComponentInChildren<Text>();
    }
    private void Update()
    {
        Display();
    }
    private void Display()
    {
        roundsText.text = GameManager.Instance.rounds.ToString();
    }
}
