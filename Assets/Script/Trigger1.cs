using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigger1 : MonoBehaviour
{
    public AudioSource audioSource;

    public Score_test score_Test;
    public float speed = 5f;

    // UI Text ���
    public Text infoText;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();

        infoText = GameObject.Find("SkillError").GetComponent<Text>();
        // YourUITextObjectName�� �ؽ�Ʈ�� ǥ���� UI Text ������Ʈ�� �̸��Դϴ�.
    }
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


        if (collision.transform.tag == "Skill1")
        {
            Destroy(gameObject);
            Debug.Log("��ų ����");
            score_Test.score++;

            // �ؽ�Ʈ ������Ʈ
            infoText.text = "�¸�! ���ھ�: " + score_Test.score;
        }
        else {
            Debug.Log("���� �´� ��ų�� ������ּ���");
            // �ؽ�Ʈ ������Ʈ
            infoText.text = "���� �´� ��ų�� ������ּ���";
        }
    }
}
