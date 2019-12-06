using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
   // public GameManager gameManager;
   void OnCollisionEnter(Collision collisionInfo)//OnCollisionEnter вызывается, когда этот collider/rigidbody начал соприкосновение с другим rigidbody/collider.
    {
       // Debug.Log("We hit something.");//с выводом имени объекта, с которым столкнулись
        //Debug.Log(collisionInfo.collider.name);
        //if (collisionInfo.collider.name == "Obstacle")
        if (collisionInfo.collider.tag == "Obstacle") //используем тег, чтобы объеденить в группу объекты
            {
            Debug.Log("We hit obstacle");//сообщает о столкновении с препятствием
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
