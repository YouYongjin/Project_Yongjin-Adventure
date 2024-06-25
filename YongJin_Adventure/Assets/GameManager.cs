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

        // Player 캐릭터의 Y축 위치.

        // 기준 높이 값을 더하여 최종 위치 계산.
        resultYPos = playerYPos + baseHeight;

        truncatedFloat = Mathf.Floor(playerYPos * 10f) * 0.1f;

        // 디버그 테스트
        Debug.Log($"Player Y Position: {playerYPos:F1}, Base Height: {baseHeight:F1}, Result Y Position: {resultYPos:F1}");
        
        if (truncatedFloat < 0)
        {
            text.text = "0.0 M";
            return;
        }

        // UI 표시
        text.text = $"{truncatedFloat:F1} M";
    }   
}                           
        