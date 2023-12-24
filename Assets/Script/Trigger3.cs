using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigger3 : MonoBehaviour
{
    public AudioSource audioSource;
    public Score_test score_Test;
    public float speed = 5f;
    void MoveLeft()
    {
        // ���� ��ġ�� �����ͼ� �������� �̵�
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

    void Update()
    {
        // �������� �̵�
        MoveLeft();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("�΋Hħ");
        audioSource.Play();

        if (collision.transform.tag == "Player")
        {
            Destroy(gameObject);
            Debug.Log("��ų3 ����");
            score_Test.score++;
        }
        else
        {
            Debug.Log("���� �´� ��ų�� ������ּ���");
        }
    }
}
