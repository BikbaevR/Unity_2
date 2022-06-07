using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _podskazkiController : MonoBehaviour
{

  //объявляем необходимые переменные и ссылки на объекты
  public Text podskazka;
  public _AparatController aparat;

  bool start = false;
  bool plastinka = false;
  bool zapusk = false;
  bool mayatnikEnd = false;
  bool reset = false;


  // Use this for initialization
  void Start()
  {
    podskazka.text = "";//поумолчанию текст подсказки пустой
  }

  // Update is called once per frame
  void Update()
  {
    if (start)
    {
      podskazka.text = "Для того что бы начать вам необходимо выбрать одну из пластинок, для этого нажмите на одноименную кнопку 'Пластинка #'";
    }
    if (start && plastinka)
    {
      podskazka.text = "Теперь нажмите на кнопку 'Запустить маятник'";
    }
    if (start && plastinka && zapusk)
    {
      podskazka.text = "Ожидайте пока маятник не закончит колебаться";
    }
    if (start && plastinka && zapusk && aparat.amp <= 0)
    {
      podskazka.text = "Запишите получившиеся значения Итерации и Времени, после чего нажмите на кнопку 'Сброс таймера'";
    }
    if (reset)
    {
      start = true;
      plastinka = false;
      zapusk = false;
      mayatnikEnd = false;
      reset = false;
    }

  }



  public void startSelect()//функция старта подсказок
  {
    start = true;
  }
  public void plastinkaSelect()//функция установки пластинки
  {
    plastinka = true;
  }
  public void zapuskSelect()//функция запуска маятника
  {
    zapusk = true;
  }
  public void resetAll()//функция сброса всего
  {
    reset = true;
  }
}
