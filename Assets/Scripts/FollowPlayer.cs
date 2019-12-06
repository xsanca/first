using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public Vector3 offset;//смещение на трехмерный вектор 

    // Update is called once per frame
    void Update()
    {
       // Debug.Log(player.position); //показывает позицию игрока
        transform.position = player.position+offset;//приравниваем позицию камеры(т.к. это скрипт для 
       //этого объекта) и местоположение игрока
    }
}
