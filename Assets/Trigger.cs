using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D ohter)
    {
        Debug.Log("�΋Hħ");
        Score_test.score++;
    }
}
