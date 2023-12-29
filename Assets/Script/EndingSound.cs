using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingSound : MonoBehaviour
{
    public AudioSource audioSource; // AudioSource 컴포넌트

    private IEnumerator Start()
    {
        yield return new WaitForSeconds(9); // 13초 동안 기다림
        audioSource.Play(); // 음악 재생
    }
}
