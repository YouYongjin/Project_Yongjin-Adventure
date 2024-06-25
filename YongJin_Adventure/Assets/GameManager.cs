using System.Collections;                               
using System.Collections.Generic;                       
using UnityEngine;                                      
                                                        
public class GameManager : MonoBehaviour                
{                                                       
    public PlayerController playerController;                  
        
    public void PlayerCurrentLocation(Transform playerTransform, float baseHeight, float playerYPos, float resultYPos)
    {   
        // Player ĳ������ Y�� ��ġ.
        playerYPos = playerTransform.position.y;

        // ���� ���� ���� ���Ͽ� ���� ��ġ ���.
        resultYPos = playerYPos + baseHeight;

        // ����� �׽�Ʈ
        Debug.Log($"Player Y Position: {playerYPos:F2}, Base Height: {baseHeight:F2}, Result Y Position: {resultYPos:F2}");
    }   
}                           
        