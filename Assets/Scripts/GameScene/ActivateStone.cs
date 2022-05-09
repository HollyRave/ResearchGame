using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateStone : MonoBehaviour
{
    [SerializeField] private List<Stone> _stones;
    
    public void Activate()
    {
        foreach (var stone in _stones)
        {
         //тут чёто со стоунами надо
        }
    }
}
