using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class houseValue : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int ParrandaSizeNeeded;
    [SerializeField] GameObject PartyMeber;
    [SerializeField] TextMesh sizeNeededUI;
    PartyMemberCount partyMemberCount;
    void Start()
    {
        sizeNeededUI.text = ParrandaSizeNeeded.ToString();
        partyMemberCount = GameObject.Find("Player").GetComponent<PartyMemberCount>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if( other.gameObject.tag == "Player")
        {
           int PartySize = other.gameObject.GetComponent<PartyMemberCount>().PartySize;

            if (PartySize >= ParrandaSizeNeeded)
            {
                PartyMeber.SetActive(true);
                partyMemberCount.PartySize = partyMemberCount.PartySize +1;          
            }
        }
    }
}
