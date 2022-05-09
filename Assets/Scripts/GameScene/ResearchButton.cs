using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResearchButton : MonoBehaviour
{
    public void LoadResearchScene()
    {
        SceneManager.LoadScene("ResearchScene");
    }
}
