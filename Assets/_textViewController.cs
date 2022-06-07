using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _textViewController : MonoBehaviour
{

  //объявлем необходимые переменные
  public GameObject oboroti;
  public GameObject vremya;
  public _AparatController aparatController;

  public _triggerController triggerController; //ссылка на внешний скрипт
  public _plastinkaController plastinkaController;//ссылка на внешний скрипт


  public int sec = 0;
  public int min = 0;
  public int deltas = 0;
  public int oborot = 0;



  public float period;

  public bool reset = false;




  // Use this for initialization
  void Start()
  {
    StartCoroutine(TimeFlow());//запускае корунтину

  }

  // Update is called once per frame
  void Update()
  {
    //условия для запуска и остановки таймера
    if (aparatController.ampNull)
    {
      timerStop();
    }
    if (aparatController.amp > 0 && aparatController.amp <= 29)
    {
      timerStart();
    }

    if (!reset && triggerController.count % 1 == 0)
    {
      period = triggerController.count;
    }

    if (reset)
    {
      triggerController.count = 0;
      period = triggerController.count;
    }

    oboroti.GetComponent<TextMesh>().text = "" + period;//вывод итераций маятника
    //Debug.Log(delta);


  }

  IEnumerator TimeFlow()//секундомер
  {
    while (true)
    {
      if (sec == 59)
      {
        min++;
        sec = -1;
      }
      sec += deltas;
      vremya.GetComponent<TextMesh>().text = "" + min.ToString("D2") + ":" + sec.ToString("D2");//вывод секунд и минут на экран
      yield return new WaitForSeconds(1);
    }
  }

  public void timerStart()//функция запуска секундомера
  {

    deltas = 1;
    reset = false;

  }
  public void timerStop()//функция остановки секундомера
  {
    deltas = 0;

  }
  public void resetTimer()//функция сброса значений секундомера
  {
    sec = 0;
    min = 0;
    reset = true;
  }
}
