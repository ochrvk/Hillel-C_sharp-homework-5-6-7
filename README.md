#Hillel C# homework 5, 6, 7

## **ДЗ 5. Сколько раз каждый символ встречается в строке**


### Создать консольное приложение.

**Пользователь вводит строку.**  

**Реализовать метод:**  
```
Dictionary<char, int> CharCount(string s)
{
}
```
**Посчитать сколько раз каждый символ встречается в строке и заполнить словарь**  
**Вернуть словарь из метода**  


**Вывести на экран содержимое словаря.**  



### **Например:**
```
"abc" -> {'a', 1}, {'b', 1}, {'c', 1} каждый символ по одному разу встречается

"aaa" -> {'a', 3} а встречается 3 раза

"aab" -> {'a', 2}, {'b', 1} а встречается 2 раза, b - 1 раз
```



## **ДЗ 6. Отфильтровать массив**

### **Создать консольное приложение.**  

**Пользователь вводит:**  

- Длину массива
- Последовательно значения всех элементов (ввел первое - enter, второе - enter и т.д.)


**Реализовать метод, который:**  

- Принимает массив
- Возвращает List в котором есть только четные элементы массива (число четное если делится на 2 без остачи, то есть a % 2 == 0)


**Вывести результат работы метода на экран**



### **Например:**
```
1, 2, 3 -> 2

5, 6, 4 -> 6, 4
```
## **ДЗ 7. Две строки**

### **Создать консольное приложение.**

**Пользователь вводит последовательно 2 строки.**  

**Вывести на экран true если вторая строка находится в первой, если нет - false.**  


### **Например:**
```
"abc", "a" -> true

"abc", "q" -> false
```
