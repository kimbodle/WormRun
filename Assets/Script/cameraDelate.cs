using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraDelate : MonoBehaviour
{
    public float targetXCoordinate = 12f;
    public float targetXCoordinate2 = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        // ���� ������Ʈ�� ��ġ�� ������
        Vector3 currentPosition = transform.position;

        // x ��ǥ�� ��ǥ���� ���ų� ū ���
        if (currentPosition.x >= targetXCoordinate)
        {
            // ������Ʈ�� ����
            Destroy(gameObject);
        }

        if (currentPosition.x <= targetXCoordinate2)
        {
            // ������Ʈ�� ����
            Destroy(gameObject);
        }
    }
}