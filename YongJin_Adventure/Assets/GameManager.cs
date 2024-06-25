using System.Collections;                               
using System.Collections.Generic;                       
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour                
{                                                       
    public PlayerController playerController;

    public void PlayerCurrentLocation(Transform playerTransform, float baseHeight, float resultYPos, TextMeshProUGUI text, float truncatedFloat)
    {
        float playerYPos = playerTransform.position.y;

        // Player ĳ������ Y�� ��ġ.

        // ���� ���� ���� ���Ͽ� ���� ��ġ ���.
        resultYPos = playerYPos + baseHeight;

        truncatedFloat = Mathf.Floor(playerYPos * 10f) * 0.1f;

        // ����� �׽�Ʈ
        Debug.Log($"Player Y Position: {playerYPos:F1}, Base Height: {baseHeight:F1}, Result Y Position: {resultYPos:F1}");
        
        if (truncatedFloat < 0)
        {
            text.text = "0.0 M";
            return;
        }

        // UI ǥ��
        text.text = $"{truncatedFloat:F1} M";
    }   
}                           
        