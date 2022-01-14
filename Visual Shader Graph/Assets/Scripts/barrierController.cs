using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;
public class barrierController : MonoBehaviour
{
    VisualEffect barrier;
    // Start is called before the first frame update
    void Start()
    {
        barrier = GetComponent<VisualEffect>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up") == true)
            barrier.Play();
        else if (Input.GetKey("up") == false)
            barrier.Stop();
    }
}
