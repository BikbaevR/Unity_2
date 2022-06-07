using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _AparatController : MonoBehaviour
{


  //x = -0.1561
  //y = -0.0153
  //z = 0
  //объявляем необходимые переменные
  public GameObject mayatnik;
  public GameObject derjalka;
  float speed = 1f; //скорость туда-сюда
  public float amp = 30f; //величина размаха
  public float material = 0;
  public bool ampNull = false;
  public bool mayatnikMove = false;
  public float oborot;
  public _textViewController sec;
  public _plastinkaController plastinkaController;
  public float incriment;

  public bool deltaTrue = false;




  public void mayatnikStart()//функция запуска движения маятника
  {
    if (plastinkaController.perviyStay)
    {
      mayatnikMove = true;
      amp = 30;
      sec.deltas = 1;
    }
    if (plastinkaController.vtoroyStay)
    {
      mayatnikMove = true;
      amp = 30;
      sec.deltas = 1;
    }
    if (plastinkaController.tretiyStay)
    {
      mayatnikMove = true;
      amp = 30;
      sec.deltas = 1;
    }


  }

  public void mayatnikStop()//функция остановки движения маятника
  {
    mayatnikMove = false;
    amp = 30f;
    mayatnik.transform.rotation = Quaternion.Euler(new Vector3(0, 0, derjalka.transform.localEulerAngles.z - 360));
  }


  public void metal1()//функция выбора вариации трения пластинок
  {
    material = 0.01f;
  }
  public void metal2()//функция выбора вариации трения пластинок
  {
    material = 0.019f;
  }
  public void metal3()//функция выбора вариации трения пластинок
  {
    material = 0.028f;
  }


  // Use this for initialization
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

    if (amp <= 0)
    {
      ampNull = true;
    }

    if (amp >= 0 && speed >= 0 && mayatnikMove)
    {
      amp -= material;
    }
    //Debug.Log(material);

    if (mayatnikMove)
    {
      mayatnik.transform.rotation = Quaternion.Euler(new Vector3(Mathf.Sin(Time.time * speed) * amp, 0, derjalka.transform.localEulerAngles.z - 360));
      //движение маятника
    }
  }


  public void materialNull()
  {
    material = 0.000000000000000000000000001f;
  }
}
