using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _cameraPosController : MonoBehaviour
{
  //ссылка на камеру
  public GameObject Camera;
  //объявляем необходимые переменные
  bool move = false;
  Vector3 startPosition;
  Vector3 needPosition;
  float speed = 0.01f;
  float offset = 0;
  Quaternion startRotation;
  Quaternion needRotaton;


  // Use this for initialization
  void Start()
  {
  }


  public void MoveStart()
  {
    if (!move)
    {
      move = true;
      needPosition = new Vector3(-1.9f, 1f, 0.1f);
      needRotaton = Quaternion.AngleAxis(90f, new Vector3(0, 1, 0));
      //позиция и угол поворота для камеры
    }
  }

  public void MoveTimer()
  {
    if (!move)
    {
      move = true;
      needPosition = new Vector3(-1.25f, 0.6f, -0.6f);
      needRotaton = Quaternion.AngleAxis(90f, new Vector3(0, 1, 0));
      //позиция и угол поворота для камеры
    }
  }

  public void MoveAparatTwo()
  {
    if (!move)
    {
      move = true;
      needPosition = new Vector3(-1.56f, 1f, -1.29f);
      needRotaton = Quaternion.AngleAxis(73f, new Vector3(0, 1, 0));
      //позиция и угол поворота для камеры
    }
  }

  public void MoveMayatnik()
  {
    if (!move)
    {
      move = true;
      needPosition = new Vector3(-0.87f, 1.16f, -0.56f);
      needRotaton = Quaternion.AngleAxis(90f, new Vector3(0, 1, 0));
      //позиция и угол поворота для камеры
    }
  }

  public void MovePlastinki()
  {
    if (!move)
    {
      move = true;
      needPosition = new Vector3(-0.9f, 0.8f, 0.84f);
      needRotaton = Quaternion.AngleAxis(90f, new Vector3(0, 1, 0));
      //позиция и угол поворота для камеры
    }
  }



  // Update is called once per frame
  void Update()
  {
    //Проверяем позицию камеры в реальном времени
    startRotation = Camera.transform.rotation;
    startPosition = Camera.transform.position;

    if (move)//если нажата кнопка перемещения камеры
    {
      offset += speed;//данная конструкция увеливает скорость передвижения по времени
      Camera.transform.position = Vector3.Lerp(startPosition, needPosition, offset);//плавно изменяем позицию
      Camera.transform.rotation = Quaternion.Slerp(startRotation, needRotaton, offset);//плавно измеяем угол поворота

      if (offset >= 1)
      {
        move = false;
        offset = 0;
      }

    }
  }



}
