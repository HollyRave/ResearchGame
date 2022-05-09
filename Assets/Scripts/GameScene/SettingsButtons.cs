using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsButtons : MonoBehaviour
{
    public void LoadSettingsScene()
    {
        SceneManager.LoadScene("SettingsScene");
    }
}
