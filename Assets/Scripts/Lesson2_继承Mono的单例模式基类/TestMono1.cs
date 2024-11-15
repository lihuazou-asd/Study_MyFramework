using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMono1:SingletonMono<TestMono1>
{
    protected override void Awake()
    {
        base.Awake();
        Debug.Log("Awake");
    }

    public void Speak(){
        print("TestMono1Speak");
    }
}
