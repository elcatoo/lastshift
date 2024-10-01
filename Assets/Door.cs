using UnityEngine;
using UnityEngine.UI;

public class Door : MonoBehaviour
{
    public Door linkedDoor; // Ссылка на связанную дверь
    public GameObject player; // Ссылка на игрока
    public Canvas hintCanvas; // Подсказка на экране

    private void Start()
    {
        hintCanvas.gameObject.SetActive(false); // Скрыть подсказку по умолчанию
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered trigger");
            hintCanvas.gameObject.SetActive(true); // Показать подсказку
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player exited trigger");
            hintCanvas.gameObject.SetActive(false); // Скрыть подсказку
        }
    }

    private void Update()
    {
        if (hintCanvas.gameObject.activeSelf && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("E key pressed");
            if (linkedDoor != null)
            {
                Debug.Log("Teleporting player to linked door");
                player.transform.position = linkedDoor.transform.position + Vector3.forward; // Телепортировать игрока
                hintCanvas.gameObject.SetActive(false); // Скрыть подсказку после телепортации
            }
        }
    }
}
