using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartyMemberCount : MonoBehaviour
{
    // Start is called before the first frame update
    [Range(1,10)]
    public int PartySize;
    AudManager audManager;

    void Start()
    {
        audManager = GameObject.Find("AudioManager").GetComponent<AudManager>();
        
        this.gameObject.name = "Player";
    }

    // Update is called once per frame
    void Update()
    {
        switch (PartySize)
        {
            case 1:
                audManager.seguidorVolume = 25f;
                
                break;
            case 2: audManager.puntadorVolume = 25f;
               
                break ;
            case 3: audManager.requintoVolume = 25f;
               
                break;
            case 4: audManager.GuiroVolume = 10f;
               
                break;
            case 5:
                audManager.seguidorVolume = 50f;
               
                break;
            case 6:
                audManager.puntadorVolume = 50f;
               
                break;
            case 7:
                audManager.requintoVolume = 50f;
               
                break;
            case 8:
                audManager.GuiroVolume = 20f;
               
                break;
            default:

                break;
        }
        
    }
}
