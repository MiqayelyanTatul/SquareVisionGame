using System;
using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI _timer;
    public int _timerCount = 20;

    private void Start()
    {
        StartCoroutine(Seconds());
    }

    private void FixedUpdate()
    {
        _timer.text = _timerCount.ToString();
    }

    private IEnumerator Seconds()
    {
        while (true)
        {
            if (_timerCount > 0)
            {
                _timerCount --;
                yield return new WaitForSeconds(1f);
            }
            else
            {
                //Game Over
            }
        }
    }
}
