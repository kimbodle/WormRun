using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStart : MonoBehaviour
{
    public GameObject[] enemyPrefabs; // enemy1, enemy2, enemy3 프리팹 배열
    public Transform[] spawnPoints; // 오브젝트 생성 위치 배열

    private int generationCount = 30; // 생성 횟수
    private float generationInterval = 5f; // 생성 간격 (초)

    void Start()
    {
        StartCoroutine(GenerateObjects());
    }

    IEnumerator GenerateObjects()
    {
        for (int i = 0; i < generationCount; i++)
        {
            GenerateRandomObject();
            yield return new WaitForSeconds(generationInterval);
        }
    }

    void GenerateRandomObject()
    {
        int randomIndex = Random.Range(0, enemyPrefabs.Length); // enemyPrefabs 배열에서 랜덤 인덱스 선택
        GameObject enemyPrefab = enemyPrefabs[randomIndex]; // 선택된 인덱스에 해당하는 enemy 프리팹

        int randomSpawnPointIndex = Random.Range(0, spawnPoints.Length); // spawnPoints 배열에서 랜덤 인덱스 선택
        Transform spawnPoint = spawnPoints[randomSpawnPointIndex]; // 선택된 인덱스에 해당하는 생성 위치

        // spawnPoint 위치에 enemyPrefab 생성
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
