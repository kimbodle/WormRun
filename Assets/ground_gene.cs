using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefabToGenerate; // 생성할 프리팹
    public float generationInterval = 15f; // 프리팹 생성 간격 (초)
    public float moveSpeed = 5f; // 이동 속도
    public Vector3 spawnPosition; // 처음 생성 위치

    private float timer; // 타이머 변수

    private void Start()
    {
        timer = generationInterval; // 타이머 초기화

        transform.position = spawnPosition; // 처음 생성 위치로 이동
    }

    private void Update()
    {
        timer -= Time.deltaTime; // 경과된 시간을 감소시킴

        if (timer <= 0f) // 타이머가 0 이하가 되면
        {
            GeneratePrefab(); // 프리팹 생성 함수 호출
            timer = generationInterval; // 타이머를 다시 간격으로 초기화
        }

        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime); // 왼쪽으로 이동
    }

    private void GeneratePrefab()
    {
        GameObject generatedPrefab = Instantiate(prefabToGenerate, spawnPosition, Quaternion.identity);
        Destroy(generatedPrefab, generationInterval); // 생성된 프리팹을 간격 시간 후에 제거
    }
}
