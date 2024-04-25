using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Test1.Instance.Speak();
        // Test2.Instance.Speak();
        TestMono1.Instance.Speak();

        TestAutoMono1.Instance.Speak();
        TestAutoMono2.Instance.Speak();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
