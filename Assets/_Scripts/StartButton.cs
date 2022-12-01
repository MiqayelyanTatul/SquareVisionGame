using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
   [SerializeField] private GameObject _panel;
   public void OnClickStart()
   {
      _panel.SetActive(true);
   }

   public void OnClickClose()
   {
      _panel.SetActive(false);
   }
}
