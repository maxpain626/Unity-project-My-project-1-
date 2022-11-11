using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // �������� �� �������
    private void OnEnable()
    {
        PlayerEvents.onTouched += ConsoleMessage;
    }

    // ������� �� �������
    private void OnDisable()
    {
        PlayerEvents.onTouched -= ConsoleMessage;
    }

    private void ConsoleMessage()
    {
        Debug.Log("����� �����������.");
    }
}
