using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RaycastSelector : MonoBehaviour
{
    public TextMeshProUGUI hintText; //Текст на экране

    void Update()
    {
        // Выполняем луч от камеры игрока
        Ray ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        
        // Проверяем столкновение с объектами сцены
        bool isObjectHit = Physics.Raycast(ray, out hitInfo);
        
        // Если объект имеет компонент InteractableHelper, выводим имя объекта
        if (isObjectHit && hitInfo.transform.GetComponent<InteractableHelper>())
        {
            var helper = hitInfo.transform.GetComponent<InteractableHelper>();
            hintText.text = helper.objectName;
        }
        else
        {
            // Очищаем текст, если взгляд направлен мимо интерактивных объектов
            hintText.text = "";
        }
    }
}
