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
    void Start()
    {
        
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
