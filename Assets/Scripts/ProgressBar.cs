using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    [SerializeField] private int tasks = 3;
    [SerializeField] private Sprite[] buttonImage;

    private int _Progression;

    private SpriteRenderer _spriteRenderer;
    // Start is called before the first frame updat
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HitButton()
    {
        if (_Progression != tasks)
        {
            StartCoroutine(BarProgress(++_Progression));
        }

    }

    IEnumerator BarProgress(int Progress)
    {
        for (int i = (Progress-1)*buttonImage.Length/tasks; i < Progress*buttonImage.Length/tasks; i++)
        {
           _spriteRenderer.sprite  = buttonImage[i];
            yield return new WaitForSeconds(1f/10f);
        }
    }

}
