using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float moveSpeed = 5f; // Скорость передвижения

    void Update()
    {
        // Получаем ввод от игрока
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Перемещаем объект по оси X и Z
        Vector3 moveDirection = new Vector3(horizontal, 0, vertical).normalized;

        // Двигаем объект
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime, Space.Self);
    }
}
