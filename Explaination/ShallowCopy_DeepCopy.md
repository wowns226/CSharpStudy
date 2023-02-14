# 얕은 복사와 깊은 복사
* [[Code]](/Code/Chapter07/ShallowDeepCopy.cs)
## 얕은 복사
* 힙에 있는 실제 객체가 아닌 스택에 있는 참조를 복사하는 것이 `얕은 복사`이다.
```c#
class MyClass
{
    public int MyField1;
    public int MyField2;
}
```
```c#
MyClass source = new MyClass();
source.MyField1 = 10;
source.MyField2 = 20;

MyClass target = source;
target.MyField2 = 30;
```
위의 코드를 출력하게 된다면 두 객체의 MyField1은 10이고 MyField2는 30이다.

## 깊은 복사
* 힙에 보관되어 있는 내용을 복사해 받아 별도의 힙 공간에 객체를 보관하는 것이 `깊은 복사`이다.