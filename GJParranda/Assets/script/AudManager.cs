using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] AudioSource guiro;
    [SerializeField] AudioSource requinto;
    [SerializeField] AudioSource seguidor;
    [SerializeField] AudioSource puntador;


    [Range(0f,100f)]
    public float GuiroVolume;
    [Range(0f, 100f)]
    public float requintoVolume;
    [Range(0f, 100f)]
    public float seguidorVolume;
    [Range(0f, 100f)]
    public float puntadorVolume;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        guiro.volume = GuiroVolume / 100;
        requinto.volume = requintoVolume / 100;
        seguidor.volume = seguidorVolume / 100;
        puntador.volume = puntadorVolume / 100;
    }
}
