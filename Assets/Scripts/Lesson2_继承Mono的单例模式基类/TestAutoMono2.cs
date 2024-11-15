using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAutoMono2 : SingletonAutoMono<TestAutoMono2>
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Speak(){
        print("TestAutoMono2");
    }
}
