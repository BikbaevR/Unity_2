using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _CameraControler : MonoBehaviour
{
  //объявляем необходимые переменные
  [SerializeField]
  Transform targetPos;
  int sensivity = 3;

  [SerializeField]
  float scrollSpeed = 10f;
  [SerializeField]
  int maxdistance = 5;
  [SerializeField]
  int mindistance = 1;

  bool ControlDistance(float distance)
  {
    if (distance > mindistance && distance < maxdistance) return true;
    return false;
    //Если дистанция больше минимальной и меньше максимальной, возвращаем true, иначе false
  }






  // Use this for initialization
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {


    if (Input.GetMouseButton(1))
    {
      transform.RotateAround(targetPos.position, Vector3.up, Input.GetAxis("Mouse X") * sensivity);
      transform.Rotate(Vector3.left, Input.GetAxis("Mouse Y") * sensivity);
      //Если нажата кнопка (1) на мышке - принимаем параметры передвижения мыши и применяем их на камере 
    }

    float x = Input.GetAxis("Horizontal"); // клавиши A, D
    float y = Input.GetAxis("Vertical"); // клавиши W, S
    if (x != 0 || y != 0)
    {
      Vector3 newpos = transform.position + (transform.TransformDirection(new Vector3(x, 0, 0)) + Vector3.up * y) / sensivity;
      if (ControlDistance(Vector3.Distance(newpos, targetPos.position))) transform.position = newpos;
      //обработка нажатий клавишь с клавиатуры, если мы их нажимаем - изменяем позицию камеры
    }

    // ПРИБЛИЖЕНИЕ И УДАЛЕНИЕ ПРОКРУТКОЙ КОЛЕСА МЫШИ

    if (Input.GetAxis("Mouse ScrollWheel") != 0)
    {
      Vector3 newpos = transform.position + transform.TransformDirection(Vector3.forward * Input.GetAxis("Mouse ScrollWheel") * scrollSpeed);
      if (ControlDistance(Vector3.Distance(newpos, targetPos.position))) transform.position = newpos;
      //приближение и удаление прокруткой мыши
    }


  }
}
