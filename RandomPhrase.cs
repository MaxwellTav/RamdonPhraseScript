using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RandomPhrase : MonoBehaviour
{
    [Header("Referencias")]
    public Text referenceText;
    
    [Header("Frases")]
    public string[] phrases;

    //valor que se tomara al azar
    [HideInInspector]
    public int i;
    
    void Start()
    {
        referenceText = GetComponent<Text>();
        MostrarFrase();

        Debug.Log("Se mostro la frase: " + phrases[i]);
    }

    public void MostrarFrase()
    {
        i = Random.Range(0, phrases.Length);

        referenceText.GetComponent<Text>().text = phrases[i];
    }
}
