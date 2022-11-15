using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesMan : MonoBehaviour
{
    public void NextLevel(int _sceneCount)
    {
        SceneManager.LoadScene(_sceneCount);
    }
}
