using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyBar : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Image bar;
    [Range(0F,100F)]
    public float Bar;
    public int decayPerTic;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bar.fillAmount = Bar /100;

         Bar -= decayPerTic * Time.deltaTime ;
    }
}
