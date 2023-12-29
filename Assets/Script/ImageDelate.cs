using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI ������Ʈ�� ����ϱ� ���� ���ӽ����̽� �߰�

public class ImageDelate : MonoBehaviour
{
    private float timer = 0;
    public float DelateTime = 10f;
    public Image image; // ������ ������ �̹���

    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>(); // �̹��� ������Ʈ ��������
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer <= DelateTime)
        {
            Color c = image.color;
            c.a = 1 - (timer / DelateTime - 0.3f); // ������ ������ ����
            image.color = c;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
