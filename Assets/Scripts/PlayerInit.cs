using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Здесь создаём инстанс игрока и размешаем его в точке спавна
public class PlayerInit : MonoBehaviour
{
    public GameObject playerPrefab;
    public Transform spawnPoint;
    public Camera mainCamera;

    void Start()
    {
        //Проверяем, чтобы префаб игрока и точка спавна были в сцене
        if (playerPrefab != null && spawnPoint != null)
        {
            GameObject player = Instantiate(playerPrefab, spawnPoint.position, spawnPoint.rotation); //Ставим игрока

            //Если камера в сцене, прикрепляем её к игроку на уровне глаз
            if (mainCamera != null)
            {
                mainCamera.transform.SetParent(player.transform);
                mainCamera.transform.localPosition = new Vector3(0, 1f, 0);
                mainCamera.transform.localRotation = Quaternion.identity;
            }
        }
        else
        {
            Debug.LogError("Не назначен префаб игрока или точка спавна!");
        }
    }
}
