using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class TopaccaBallsPoints : MonoBehaviour
{
    public int TopaccaBalls = 0;
    [SerializeField] private TextMeshProUGUI textTopaccaBalls;

    public string text;
    // Start is called before the first frame update
    void Start()
    {
        TopaccaBalls = PlayerPrefs.GetInt("TP");
        textTopaccaBalls.text = TopaccaBalls.ToString();

    }
    
    public void AddPoints(int points)
    {
        TopaccaBalls += points;
        textTopaccaBalls.text = TopaccaBalls.ToString();
    }

    public void SavedVariables()
    {
        PlayerPrefs.SetInt("TP",TopaccaBalls);
    }

    public void ProgessCS()
    {
        SavedVariables();
        SceneManager.LoadScene("Task Scene");
    }
    
    public void FrontPageCS()
    {
        SavedVariables();
        SceneManager.LoadScene("Task Scene");
    }
    
}
