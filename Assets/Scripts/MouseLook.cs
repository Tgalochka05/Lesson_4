using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f; //Чувствительность мыши

    private float xRotation = 0f; //Вращение по x

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // Курсор по центру
    }

    void Update()
    {
        //Рассчитываем движение мыши
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // Вращение камеры по вертикали
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        // Вращаем камеру (вверх/вниз)
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        // Вращаем тело игрока (влево/вправо)
        transform.parent.Rotate(Vector3.up * mouseX);
    }
}
