using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Counter : MonoBehaviour
{
    [SerializeField]TextMeshProUGUI counterText;
    float counter = 0;
    public static Counter Instance;
    void Awake()
    {
        Instance = this;
        counterText.text = counter.ToString();
    }
    public void ScoreIncrease(){
        counter ++;
        counterText.text = counter.ToString();
    }
}
