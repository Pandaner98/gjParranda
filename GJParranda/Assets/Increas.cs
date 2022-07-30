using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Increas : MonoBehaviour
{
    // Start is called before the first frame update
    PartyMemberCount PartyMemberCount;
    EnergyBar energyBar;
    void Start()
    {
        energyBar = GameObject.Find("Player").GetComponent<EnergyBar>();
        PartyMemberCount = GameObject.Find("Player").GetComponent<PartyMemberCount>();
        PartyMemberCount.PartySize = PartyMemberCount.PartySize + 1;
        energyBar.Bar = energyBar.Bar = energyBar.MaxHealth;
    }

    private void OnEnable()
    {
        
    }
    
   
}
