using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
//����ʽMono�������࣬��Ҫ�ṩAwake��ʼ��instance����Ҫ��Ϸ��ʼǰ���ڳ����Ϲ������岢��ӽű�
//���Ƽ�ʹ��
public class SingletonMono<T> : MonoBehaviour where T:MonoBehaviour
{
    private static T instance;
    public static T Instance
    {
        get
        {
            return instance;
        }
    }
    //Ŀ����Ϊ�����ṩAwake��д�Ĺ�����ʵ�ֳ�ʼ������Ҫ���base.Awake();
    protected virtual void Awake()
    {
        instance = this as T;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
