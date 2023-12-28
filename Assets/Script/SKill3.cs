using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skill3 : MonoBehaviour
{
    private float timer = 0f; // Ÿ�̸� ����
    private float destroyDelay = 2f; // �ı������� ���� �ð�
    private float minY = -3.3f; // ������Ʈ�� ������ �� �ִ� �ּ� y ��ǥ

    /*
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            // Ground �±׸� ���� ������Ʈ�� �浹 ���� ��, ����ϵ��� ó��
            Physics2D.IgnoreCollision(collision.collider, GetComponent<Collider2D>());
        }
    }*/

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime; // ��� �ð��� ����

        // ������Ʈ�� y ��ǥ�� minY ���Ϸ� �������� �ʵ��� ����
        if (transform.position.y < minY)
        {
            transform.position = new Vector3(transform.position.x, minY, transform.position.z);
        }

        // ���� �ð�(destroyDelay)�� ������ ���� ������Ʈ�� �ı�
        if (timer >= destroyDelay)
        {
            Destroy(gameObject);
        }


    }
}
