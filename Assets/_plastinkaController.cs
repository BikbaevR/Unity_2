using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _plastinkaController : MonoBehaviour
{

  //объявляем необходимые переменные и ссылки на объекты
  public GameObject perviy;
  public GameObject vtoroy;
  public GameObject tretiy;


  public GameObject perviyCvet;
  public GameObject vtoroyCvet;
  public GameObject tretiyCvet;


  public Material main;



  public Vector3 needPosition;
  public Vector3 startPosition_1;
  public Vector3 startPosition_2;
  public Vector3 startPosition_3;

  public float speed = 0.01f;
  public float offset = 0;
  public bool movePerviyTo = false;
  public bool moveVtoroyTo = false;
  public bool moveTretiyTo = false;


  public bool movePerviyOut = false;
  public bool moveVtoroyOut = false;
  public bool moveTretiyOut = false;

  public bool perviyStay = false;
  public bool vtoroyStay = false;
  public bool tretiyStay = false;



  // Use this for initialization
  void Start()
  {
    //выставляем начальные значения
    needPosition = new Vector3(0f, 0.87f, -0.6f);
    startPosition_1 = new Vector3(0f, 0.6f, 0.8f);
    startPosition_2 = new Vector3(0.045f, 0.6f, 0.8f);
    startPosition_3 = new Vector3(0.096f, 0.6f, 0.8f);
  }

  // Update is called once per frame
  void Update()
  {

    if (movePerviyTo) //метод перемещения первой пластинки В
    {
      offset += speed;
      perviy.transform.position = Vector3.Slerp(startPosition_1, needPosition, offset);
      if (perviy.transform.position == needPosition)
      {
        perviyStay = true;
        perviy.SetActive(false);
        movePerviyTo = false;
        speed = 0.01f;
        offset = 0;
      }
      else
      {
        perviy.SetActive(true);
      }
    }

    if (moveVtoroyTo)//метод перемещения второй пластинки В
    {
      offset += speed;
      vtoroy.transform.position = Vector3.Slerp(startPosition_2, needPosition, offset);
      if (vtoroy.transform.position == needPosition)
      {
        vtoroyStay = true;
        vtoroy.SetActive(false);
        moveVtoroyTo = false;
        speed = 0.01f;
        offset = 0;
      }
      else
      {
        vtoroy.SetActive(true);
      }
    }

    if (moveTretiyTo)//метод перемещения третьей пластинки В
    {
      offset += speed;
      tretiy.transform.position = Vector3.Slerp(startPosition_3, needPosition, offset);
      if (tretiy.transform.position == needPosition)
      {
        tretiyStay = true;
        tretiy.SetActive(false);
        moveTretiyTo = false;
        speed = 0.01f;
        offset = 0;
      }
      else
      {
        tretiy.SetActive(true);
      }
    }


    if (movePerviyOut)//метод перемещения первой пластинки ИЗ
    {
      perviy.SetActive(true);
      offset += speed;
      perviy.transform.position = Vector3.Slerp(needPosition, startPosition_1, offset);
      if (perviy.transform.position == startPosition_1)
      {
        perviyStay = false;
        movePerviyOut = false;
        speed = 0.01f;
        offset = 0;
      }
    }

    if (moveVtoroyOut)//метод перемещения второй пластинки ИЗ
    {
      vtoroy.SetActive(true);
      offset += speed;
      vtoroy.transform.position = Vector3.Slerp(needPosition, startPosition_2, offset);
      if (vtoroy.transform.position == startPosition_2)
      {
        vtoroyStay = false;
        moveVtoroyOut = false;
        speed = 0.01f;
        offset = 0;
      }
    }

    if (moveTretiyOut)//метод перемещения третьей пластинки ИЗ
    {
      tretiy.SetActive(true);
      offset += speed;
      tretiy.transform.position = Vector3.Slerp(needPosition, startPosition_3, offset);
      if (tretiy.transform.position == startPosition_3)
      {
        tretiyStay = false;
        moveTretiyOut = false;
        speed = 0.01f;
        offset = 0;
      }
    }

  }

  public void perviyHoverEnter()
  {
    perviyCvet.GetComponent<Renderer>().material.color = new Color(1, 0, 0);
    //Фукнция меняющая цвет определенного объекта при наведении мыши на определенную кнопку
  }

  public void perviyHoverExit()
  {
    perviyCvet.GetComponent<Renderer>().material = main;
    //Фукнция возвращающаяся материал определенного объекта при убирании мыши с определенной кнопки
  }

  public void vtoroyHoverEnter()
  {
    vtoroyCvet.GetComponent<Renderer>().material.color = new Color(1, 0, 0);
    //Фукнция меняющая цвет определенного объекта при наведении мыши на определенную кнопку
  }

  public void vtoroyHoverExit()
  {
    vtoroyCvet.GetComponent<Renderer>().material = main;
    //Фукнция возвращающаяся материал определенного объекта при убирании мыши с определенной кнопки
  }

  public void tretiyHoverEnter()
  {
    tretiyCvet.GetComponent<Renderer>().material.color = new Color(1, 0, 0);
    //Фукнция меняющая цвет определенного объекта при наведении мыши на определенную кнопку
  }

  public void tretiyHoverExit()
  {
    tretiyCvet.GetComponent<Renderer>().material = main;
    //Фукнция возвращающаяся материал определенного объекта при убирании мыши с определенной кнопки
  }

  public void perviyMoveTo()//Функция проверки положения пластинки
  {
    movePerviyTo = true;
    if (vtoroyStay)
    {
      moveVtoroyOut = true;
    }
    if (tretiyStay)
    {
      moveTretiyOut = true;
    }
  }
  public void vtoroyMove()//Функция проверки положения пластинки
  {
    moveVtoroyTo = true;
    if (perviyStay)
    {
      movePerviyOut = true;
    }
    if (tretiyStay)
    {
      moveTretiyOut = true;
    }
  }
  public void tretiyMove()//Функция проверки положения пластинки
  {
    moveTretiyTo = true;
    if (perviyStay)
    {
      movePerviyOut = true;
    }
    if (vtoroyStay)
    {
      moveVtoroyOut = true;
    }
  }



  public void perviyMoveOut()//Функция проверки положения пластинки
  {
    movePerviyOut = true;
  }
  public void vtoroyMoveOut()
  {
    moveVtoroyOut = true;
  }
  public void tretiyMoveOut()
  {
    moveTretiyOut = true;
  }


  //perviyStay = false;
  //vtoroyStay = false;
  //tretiyStay = false;

}
