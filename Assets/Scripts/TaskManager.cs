using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskManager : MonoBehaviour
{
    [SerializeField] private int TotalButtons;
    [SerializeField] private int MyReward;
    private int _Progress=0;
    private TopaccaBallsPoints _TBP;
    private bool Complete=false; 
    
    // Start is called before the first frame update
    void Start()
    {
        //Complete= PlayerPrefs.GetInt("done", 0)==1;
        _TBP=FindObjectOfType<TopaccaBallsPoints>();
    }

    public void Progression()
    {
        Debug.Log(Complete);
        if (!Complete)
        {


            _Progress++;
            if (_Progress == TotalButtons)
            {
                _TBP.AddPoints(MyReward);
                PlayerPrefs.SetInt("done", 1);
                Complete = true;
                //completion effect
                Debug.Log("I am done");
            }
        }
    }

   
}
