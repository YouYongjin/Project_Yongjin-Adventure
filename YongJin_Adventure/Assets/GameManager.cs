using System.Collections;                               
using System.Collections.Generic;                       
using UnityEngine;                                      
                                                        
public class GameManager : MonoBehaviour                
{                                                       
    public PlayerController playerController;                  
        
    public void PlayerCurrentLocation(Transform playerTransform, float baseHeight, float playerYPos, float resultYPos)
    {   
        // Player 캐릭터의 Y축 위치.
        playerYPos = playerTransform.position.y;

        // 기준 높이 값을 더하여 최종 위치 계산.
        resultYPos = playerYPos + baseHeight;

        // 디버그 테스트
        Debug.Log($"Player Y Position: {playerYPos:F2}, Base Height: {baseHeight:F2}, Result Y Position: {resultYPos:F2}");
    }   
}                           
        