using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResearchButton : MonoBehaviour
{
    [SerializeField] private CanvasGroup _researchScreen;

    public void OpenCloseScreen()
    {
        if(_researchScreen.alpha == 0)
        {
            _researchScreen.alpha = 1;
            _researchScreen.interactable = true;
        }
        else
        {
            _researchScreen.alpha = 0;
        _researchScreen.interactable = false;
        }
    }
}
