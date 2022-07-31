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
    public int MaxHealth = 100;
    BasicFunctions basicFunctions;
    void Start()
    {
        basicFunctions = GameObject.Find("Canvas").GetComponent<BasicFunctions>();
    }

    // Update is called once per frame
    void Update()
    {
        bar.fillAmount = Bar /MaxHealth;

         Bar -= decayPerTic * Time.deltaTime ;
        if(Bar > MaxHealth)
        {
            Bar = MaxHealth;
        }
            if(Bar <= 0) 
            {
                basicFunctions.Lose();
            } 
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Pickup")
        {
            Bar = Bar + 10;
            Destroy(other.gameObject);
        }
    }
}
