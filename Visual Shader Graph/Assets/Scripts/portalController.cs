using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;
public class portalController : MonoBehaviour
{
    public float portalIntensity = 0f;
    VisualEffect portal;
    // Start is called before the first frame update
    void Start()
    {
        portal = GetComponent<VisualEffect>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space") == true)
            portal.Play();
        else if (Input.GetKey("space") == false)
            portal.Stop();

    }
}
