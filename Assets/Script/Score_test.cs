using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score_test : MonoBehaviour
{
    public int score = 0;  

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TMP_Text>().text = score.ToString();
       // Debug.Log("텍스트 출력");
    }
}
