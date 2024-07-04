using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CurrentLocation : MonoBehaviour
{
    public GameManager gameManager;
    public PlayerController playerController;

    public TextMeshProUGUI currentLocationText;

    float truncatedFloat;

    void FixedUpdate()
    {
        gameManager.PlayerCurrentLocation(playerController.transform, 0f, playerController.playerVector.y + 0f, currentLocationText, truncatedFloat);
    }
}
