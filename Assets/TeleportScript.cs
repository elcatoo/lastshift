using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : MonoBehaviour
{
    public Transform teleportDestination; // Точка назначения

    void OnTriggerEnter(Collider other)
    {
        // Проверяем, является ли объект игроком (или любым другим объектом, который нужно телепортировать)
        if (other.CompareTag("Player")) 
        {
            // Перемещаем объект в точку назначения
            other.transform.position = teleportDestination.position;
        }
    }
}
