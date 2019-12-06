using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    private GameObject[] _objects;
    private int _amountToPool = 20;
    private int _currentNum = 0;
    //GetObject
    //GetRandomObject
    // Start is called before the first frame update

    public GameObject GetObject()
    {
        //выключить нужный объект
        //вернуть тот который по очереди
        return new GameObject();
    }
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
