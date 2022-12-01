using System;
using UnityEngine;

public class FadeAnim : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    

    private void OnClickTrueCube()
    {
        _animator.Play("Fade");
    }

}
