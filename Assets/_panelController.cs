using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _panelController : MonoBehaviour
{
  //объявляем необходимые переменные и ссылки на объекты
  public GameObject panelPodskazok; //ссылка на панель
  public GameObject tablica; //ссылка на панель

  // Use this for initialization
  void Start()
  {
    panelPodskazok.gameObject.SetActive(false);//поумолчанию панель неактивна
    tablica.gameObject.SetActive(false);//поумолчанию панель неактивна
  }

  // Update is called once per frame
  void Update()
  {

  }





  public void panelPodskazokOn()//функция активация панели
  {
    panelPodskazok.gameObject.SetActive(true);
  }
  public void tablicaOpen()//функция активация панели
  {
    tablica.gameObject.SetActive(true);
  }
  public void tablicaClose()//функция деактивации панели
  {
    tablica.gameObject.SetActive(false);
  }
}
