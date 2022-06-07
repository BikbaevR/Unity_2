using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _triggerController : MonoBehaviour
{

  //объявлем необходимые переменные
  public float count = 0;
  public float minus_1 = 0;
  public float minus_2 = 0;

  float time = 0.00000001f;

  bool active = false;






  void OnTriggerEnter(Collider col)//функция тригера для подсчета итераций
  {
    if (col.name == "Cylinder")
    {
      count += 0.5f;
      active = true;

      minus_1 = 0.001f;
      minus_2 = 0.01f;
    }
  }

  void OnTriggerExit(Collider col)//функция тригера для подсчета итераций
  {
    if (col.name == "Cylinder")
    {
      minus_1 = 0;
      minus_2 = 0;
    }
  }

  // Use this for initialization
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {


    if (time >= 0 && active)
    {
      time -= 0.0000001f;
      if (time <= 0)
      {
        time = 0.00000001f;
        active = false;
      }
    }
    if (active)
    {
      //Debug.Log(active);
    }
  }
}
