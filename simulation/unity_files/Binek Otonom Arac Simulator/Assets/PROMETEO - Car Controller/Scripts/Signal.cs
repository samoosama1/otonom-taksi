using System.Collections;
using UnityEngine;

public class Signal : MonoBehaviour
{
     
    [Header("Signal Lights")] 
    public GameObject leftSignal;

    public GameObject rightSignal;

    public Light[] brakeLights;
    
    private bool signalIsOn = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        leftSignal.GetComponent<Light>().intensity = 0;
        rightSignal.GetComponent<Light>().intensity = 0;
        SetLights(brakeLights , 0);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SetLights(brakeLights , 2);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            SetLights(brakeLights , 0);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            signalIsOn = !signalIsOn;
            if (signalIsOn)
            {
                IEnumerator flashLight = FlashSignal(leftSignal.GetComponent<Light>(), 1f);
                StartCoroutine(flashLight);
            }
        }
        
    }
    IEnumerator FlashSignal(Light signal , float freq)
    {
        while (signalIsOn)
        {
            signal.intensity = 1;
            yield return new WaitForSeconds(freq);
            signal.intensity = 0;
            yield return new WaitForSeconds(freq);
        }
    }

    void SetLights(Light[] lights, int intensity)
    {
        for (int i = 0; i < lights.Length; i++)
        {
           lights[i].intensity =intensity;
        }
        
    }
}
