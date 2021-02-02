using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.LWRP;

public class LightController : MonoBehaviour
{
    public Light2D lt;

    // Start is called before the first frame update
    void Start()
    {
        lt = GetComponent<Light2D>();
        InvokeRepeating("ChangeLight", 2.0f, 3f);//start in 2sec and changed every 5sec
    }

    // Update is called once per frame
  

    void ChangeLight()
    {
        lt.intensity = Random.Range(1.10f, 1.50f);

        
    }


    void Update()
    {
        lt.intensity -= 0.002f;

        //StartCoroutine(WaitForLight());
    }
    /*
    IEnumerator WaitForLight() {
       
        yield return new WaitForSeconds(5);
        lt.intensity = Random.Range(1.49f, 1.50f);
    }
    */
}
