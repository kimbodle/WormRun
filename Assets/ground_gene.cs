using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefabToGenerate; // ������ ������
    public float generationInterval = 15f; // ������ ���� ���� (��)
    public float moveSpeed = 5f; // �̵� �ӵ�
    public Vector3 spawnPosition; // ó�� ���� ��ġ

    private float timer; // Ÿ�̸� ����

    private void Start()
    {
        timer = generationInterval; // Ÿ�̸� �ʱ�ȭ

        transform.position = spawnPosition; // ó�� ���� ��ġ�� �̵�
    }

    private void Update()
    {
        timer -= Time.deltaTime; // ����� �ð��� ���ҽ�Ŵ

        if (timer <= 0f) // Ÿ�̸Ӱ� 0 ���ϰ� �Ǹ�
        {
            GeneratePrefab(); // ������ ���� �Լ� ȣ��
            timer = generationInterval; // Ÿ�̸Ӹ� �ٽ� �������� �ʱ�ȭ
        }

        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime); // �������� �̵�
    }

    private void GeneratePrefab()
    {
        GameObject generatedPrefab = Instantiate(prefabToGenerate, spawnPosition, Quaternion.identity);
        Destroy(generatedPrefab, generationInterval); // ������ �������� ���� �ð� �Ŀ� ����
    }
}
