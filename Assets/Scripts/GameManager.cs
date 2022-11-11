using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Подписка на событие
    private void OnEnable()
    {
        PlayerEvents.onTouched += ConsoleMessage;
    }

    // Отписка от события
    private void OnDisable()
    {
        PlayerEvents.onTouched -= ConsoleMessage;
    }

    private void ConsoleMessage()
    {
        Debug.Log("Герой приземлился.");
    }
}
