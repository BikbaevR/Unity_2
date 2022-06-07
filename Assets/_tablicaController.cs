using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class _tablicaController : MonoBehaviour
{
  public InputField input;//ссылка на объект ввода текста
  public Button btn;//ссылка на кнопку

  //объявление необходимых переменных
  public Text nomer1;
  public Text nomer2;
  public Text nomer3;
  ///////////////////
  public Text iter1;
  public Text iter2;
  public Text iter3;
  ///////////////////
  public Text vremya1;
  public Text vremya2;
  public Text vremya3;

  // Use this for initialization
  void Start()
  {
    btn.onClick.AddListener(ReadStringInput);//обработчик для кнопки, который прослушивает нажатия кнопки

    //Поумолчанию данных в таблице нет, вместо них выставляем прочерки
    nomer1.text = "-";
    nomer2.text = "-";
    nomer3.text = "-";
    //////////////////
    iter1.text = "-";
    iter2.text = "-";
    iter3.text = "-";
    //////////////////
    vremya1.text = "-";
    vremya2.text = "-";
    vremya3.text = "-";
  }

  // Update is called once per frame
  void Update()
  {

  }


  public void ReadStringInput() //функция для заполнения таблицы
  {
    //Debug.Log(input.text);
    if (nomer1.text == "-")//если поле пустое
    {
      nomer1.text = input.text.ToString();//присваиваем ему значение полученное от ввода пользователя
    }
    else if (iter1.text == "-")//если поле пустое
    {
      iter1.text = input.text.ToString();//присваиваем ему значение полученное от ввода пользователя
    }
    else if (vremya1.text == "-")//если поле пустое
    {
      vremya1.text = input.text.ToString();//присваиваем ему значение полученное от ввода пользователя
    }

    else if (nomer2.text == "-")//если поле пустое
    {
      nomer2.text = input.text.ToString();//присваиваем ему значение полученное от ввода пользователя
    }
    else if (iter2.text == "-")//если поле пустое
    {
      iter2.text = input.text.ToString();//присваиваем ему значение полученное от ввода пользователя
    }
    else if (vremya2.text == "-")//если поле пустое
    {
      vremya2.text = input.text.ToString();//присваиваем ему значение полученное от ввода пользователя
    }

    else if (nomer3.text == "-")//если поле пустое
    {
      nomer3.text = input.text.ToString();//присваиваем ему значение полученное от ввода пользователя
    }
    else if (iter3.text == "-")//если поле пустое
    {
      iter3.text = input.text.ToString();//присваиваем ему значение полученное от ввода пользователя
    }
    else if (vremya3.text == "-")//если поле пустое
    {
      vremya3.text = input.text.ToString();//присваиваем ему значение полученное от ввода пользователя
    }
  }

  public void clear()//функция очистки таблицы
  {
    nomer1.text = "-";
    nomer2.text = "-";
    nomer3.text = "-";
    //////////////////
    iter1.text = "-";
    iter2.text = "-";
    iter3.text = "-";
    //////////////////
    vremya1.text = "-";
    vremya2.text = "-";
    vremya3.text = "-";
  }
}
