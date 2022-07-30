using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Increas : MonoBehaviour
{
    // Start is called before the first frame update
    PartyMemberCount PartyMemberCount;
    void Start()
    {
        PartyMemberCount = GameObject.Find("Player").GetComponent<PartyMemberCount>();
        PartyMemberCount.PartySize = PartyMemberCount.PartySize + 1;
    }

    private void OnEnable()
    {
        
    }
    
   
}
