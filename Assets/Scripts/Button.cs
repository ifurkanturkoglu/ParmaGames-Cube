using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Button : MonoBehaviour
{
    bool isClickable = true;
    public void ButtonClick(){
        float cubeX = Mathf.Abs(Cube.Instance.transform.rotation.eulerAngles.x);
        if(cubeX <= 20 || (cubeX >= 90 && cubeX <= 110) ||(cubeX >= 190 && cubeX <= 210)||(cubeX >= 270 && cubeX <= 290) && isClickable){
            Counter.Instance.ScoreIncrease();
            isClickable = false;
            StartCoroutine(ButtonClickReset());  
        }
    }
    IEnumerator ButtonClickReset(){
        yield return new WaitForSeconds(.5f);
        isClickable = true;
    }
}
