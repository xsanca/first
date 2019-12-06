using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGenerator : MonoBehaviour
{
    [SerializeField]
    private GameObject _block;
    [SerializeField]
    private GameObject _block1;

    private int _spawnedBlocksAmount;
   // private Queue<GameObject> _blocks;//создаем очередь для хранения блоков
    [SerializeField]
    private GameObject[] _blocks;
        //массив для хранения готовых блоков
    // Start is called before the first frame update
    void Start()
    {
        //создать функцию рандомного вытягивания из очереди блока
        //GetComponent<ObjectPooler>().GetObject().transform.position = 
        //_blocks = new List<GameObject>(4);// при старте игры создаются 4 блока
        //_blocks.Enqueue(Instantiate(_block));
        //_blocks[0](Instantiate(_block))
        
        for (int i = 0; i < _blocks.Length; i++)
        {
            GameObject instance = Instantiate(_blocks[i]);
            instance.SetActive(false);
        }
        //_blocks.Enqueue(Instantiate(_block, new Vector3(0, 0, 100), new Quaternion()));
        //_blocks.Enqueue(Instantiate(_block, new Vector3(0, 0, 200), new Quaternion()));
        //_blocks.Enqueue(Instantiate(_block, new Vector3(0, 0, 300), new Quaternion()));
        _spawnedBlocksAmount = 4;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InstantiateBlock()
    {
        //_blocks.Enqueue(Instantiate(_block, new Vector3(0, 0, _spawnedBlocksAmount * 100), new Quaternion()));// создание блока на позиции 100 умноженное на количество блоков
        //Destroy(_blocks.Dequeue());//уничтожаем предыдущий блок
        _spawnedBlocksAmount++;
    }
}
