using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _exit : MonoBehaviour
{

  // Use this for initialization
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetKey(KeyCode.Escape))
    { //если нажата кнопка esc
      Application.Quit(); //закрыть приложение
    }
  }
}
