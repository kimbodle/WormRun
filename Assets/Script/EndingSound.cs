using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingSound : MonoBehaviour
{
    public AudioSource audioSource; // AudioSource ������Ʈ

    private IEnumerator Start()
    {
        yield return new WaitForSeconds(9); // 13�� ���� ��ٸ�
        audioSource.Play(); // ���� ���
    }
}
