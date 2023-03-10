# Boxing, Unboxing [[Code]]()

* object형식은 참조 형식이기 때문에 힙에 데이터를 할당한다.
* int, double과 같은 값 형식의 데이터들을 object 형식에 어떻게 담을 수 있을까?<br>
    - 값 형식의 데이터를 힙에 할당하기 위해 "박싱(Boxing)" 기능을 제공
    - 값 형식의 데이터를 할당하려면 object 형식은 박싱을 수행해서 해당 데이터를 힙에 할당

## 예시

>* 예시 1
>```csharp 
>object a = 20;
>```
>
>20이라는 값 형식의 데이터를 박스로 감싸(Boxing) 힙에 저장한 위치를 a 가 가리키고 있다.

>* 예시 2
>```csharp
>object a = 20;
>int b = (int)a;
>```
>위와 마찬가지로 a는 20이 박싱되어 저장된 힙을 참조하고 있다.<br>
>b는 a가 참조하고 있는 메모리로부터 값을 복사한다.<br>
>이때, 박싱된 값을 꺼내 값 형식 변수에 저장하는 과정을 "언박싱(Unboxing)"이라고 한다.

---