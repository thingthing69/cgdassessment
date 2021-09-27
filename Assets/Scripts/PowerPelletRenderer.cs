using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerPelletRenderer : MonoBehaviour
{
    public Renderer rend;
    private bool flag;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(flash());
    }

    IEnumerator flash()
    {
        if(flag == true)
        {
            flag = false;
            rend.enabled = false;
            yield return new WaitForSeconds(0.5f);
            rend.enabled = true;
            yield return new WaitForSeconds(0.5f);
            flag = true;
        }
    }
}
