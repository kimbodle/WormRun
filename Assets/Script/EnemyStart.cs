using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStart : MonoBehaviour
{
    public GameObject[] enemyPrefabs; // enemy1, enemy2, enemy3 ������ �迭
    public Transform[] spawnPoints; // ������Ʈ ���� ��ġ �迭

    private int generationCount = 30; // ���� Ƚ��
    private float generationInterval = 5f; // ���� ���� (��)

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
        int randomIndex = Random.Range(0, enemyPrefabs.Length); // enemyPrefabs �迭���� ���� �ε��� ����
        GameObject enemyPrefab = enemyPrefabs[randomIndex]; // ���õ� �ε����� �ش��ϴ� enemy ������

        int randomSpawnPointIndex = Random.Range(0, spawnPoints.Length); // spawnPoints �迭���� ���� �ε��� ����
        Transform spawnPoint = spawnPoints[randomSpawnPointIndex]; // ���õ� �ε����� �ش��ϴ� ���� ��ġ

        // spawnPoint ��ġ�� enemyPrefab ����
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
