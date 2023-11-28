using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigger2 : MonoBehaviour
{
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

        if (collision.transform.tag == "Skill2")
        {
            Destroy(gameObject);
            Debug.Log("��ų2 ����");
            score_Test.score++;
        }
        else
        {
            Debug.Log("���� �´� ��ų�� ������ּ���");
        }
    }
}
