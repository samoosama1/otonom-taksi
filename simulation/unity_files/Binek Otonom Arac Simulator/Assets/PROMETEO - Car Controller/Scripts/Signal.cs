using System.Collections;
using UnityEngine;

public class Signal : MonoBehaviour
{
     
    [Header("Signal Lights")] 
    public GameObject leftSignal;

    public GameObject rightSignal;



    private bool signalIsOn = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
}
