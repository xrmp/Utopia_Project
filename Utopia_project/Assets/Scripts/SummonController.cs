using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonController : MonoBehaviour
{
    public GameObject[] objectsToSpawn; // Массив объектов для спавна
    private bool objectSpawned = false; // Флаг для отслеживания спавна объекта

    void Update()
    {
        // Проверяем нажатие клавиши "1"
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (!objectSpawned)
            {
                SpawnObject(0); 
                objectSpawned = true;
            }
        }
		if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (!objectSpawned)
            {
                SpawnObject(1); 
                objectSpawned = true;
            }
        }
		if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            if (!objectSpawned)
            {
                SpawnObject(2); 
                objectSpawned = true;
            }
        }

    }

    void SpawnObject(int index) 
{
    Vector3 playerPosition = transform.position; 

    Vector3 spawnPosition = playerPosition + transform.right * 40f + transform.up * 1f; 

    GameObject newObject = Instantiate(objectsToSpawn[index], spawnPosition, Quaternion.identity);

    StartCoroutine(DestroyObjectAfterDelay(newObject, 1f));
}

    IEnumerator DestroyObjectAfterDelay(GameObject obj, float delay)
    {
        yield return new WaitForSeconds(delay);
        Destroy(obj);
        objectSpawned = false;
    }
}


