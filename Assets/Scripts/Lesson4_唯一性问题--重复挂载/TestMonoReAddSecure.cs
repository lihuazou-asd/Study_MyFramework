using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//特性,不允许同一个Gameobject上添加多个相同的该脚本
[DisallowMultipleComponent]
public class TestMonoReAddSecure : SingletonMonoReAddSecure<TestMonoReAddSecure>
{
    public void Speak(){
        print("TestMonoReAddSecure");
    }
}
