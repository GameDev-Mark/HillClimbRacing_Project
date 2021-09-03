using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnObjects : MonoBehaviour
{
    public GameObject buttonUI;
    public Text textUI;
    public Transform textTrans;

    void Start()
    {
        Button newButt = (Instantiate(buttonUI, transform) as GameObject).GetComponent<Button>();
        Text newText = (Instantiate(textUI, textTrans) as Text).GetComponent<Text>();
    }
}