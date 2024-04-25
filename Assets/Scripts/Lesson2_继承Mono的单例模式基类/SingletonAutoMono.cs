using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//�Զ�����ʽ�ű�������ҪAwake��ʼ��instance,���ڵ�һ��ʹ�ø�Instanceʵ�������岢�Զ����ؽű�
//���赣���г�������������
public class SingletonAutoMono<T> : MonoBehaviour where T:MonoBehaviour
{
    private static T instance;
    public static T Instance
    {
        get
        {
            if(instance == null){
                //typeof(T).ToString()�������T������
                GameObject obj = new GameObject(typeof(T).ToString());
                instance = obj.AddComponent<T>();
                DontDestroyOnLoad(obj);
            }
            return instance;
        }
    }
}
