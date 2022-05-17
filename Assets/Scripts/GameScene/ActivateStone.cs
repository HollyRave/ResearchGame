using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateStone : MonoBehaviour
{
    [SerializeField] private List<GameObject> _stones;
        
    public void Activate()
    {
        foreach (var item in _stones)
        {
            item.SetActive(true);
        }
        
    }
}
