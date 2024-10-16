using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskButton : MonoBehaviour
{
    [SerializeField] private int MyReward;
    private TaskManager TM;
    private Button Button;

    private TopaccaBallsPoints _TBP;
    // Start is called before the first frame update
    void Start()
    {
       Button=GetComponent<Button>();
       TM = GetComponentInParent<TaskManager>();
       _TBP = FindObjectOfType<TopaccaBallsPoints>();
    }

    public void Clicked()
    {
        if (TM)
        {
            TM.Progression();
            Button.enabled = false;
            _TBP.AddPoints(MyReward);
            
        }
    }
 
}
