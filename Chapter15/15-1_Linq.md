# Linq

## Linq란?
`Linq(LAnguage INtegrated Query)`는 C# 언어에 통합된 `데이터 질의 기능`이다.<br>
* From : 어떤 데이터 집합에서 찾을 것인가
* Where : 어떤 값의 데이터를 찾을 것인가
* Select : 어떤 항목을 추출할 것인가

## Linq의 기본
*  [[Code]](/Code/Chapter15/LINQ.cs)

### from
* 모든 쿼리식은 반드시 `from`절로 시작한다.
* 쿼리식의 대상이 될 데이터 원본과 데이터 원복 안에 있는 각 요소 데이터를 나타내는 범위 변수를 `from` 절에서 지정해준다.
* 데이터 원본은 IEnumerable<T> 인터페이스를 상속하는 형식이여야 한다.
* 범위 변수는 쿼리 변수라고도 한다. foreach문의 반복 변수과 비슷하다.

`from 변위변수 in 데이터 원본`

### where
* 필터 역할을 하는 연산자이다.
* from 절이 데이터 원본으로부터 뽑아낸 범위 변수가 가져야 하는 조건을 where 연산자에 인수로 입력하면 조건에 맞는 데이터만 걸러낸다.

`where 조건`

### orderby
* 데이터의 정렬을 수행하는 연산자이다.
    - ascending 을 붙이면 오름차순으로 정렬해준다.
    - descending을 붙이면 내림차순으로 정렬해준다.

`orderby 조건 ascending`<br>
`orderby 조건 descending`

### select
* 최종 결과를 추출하는 마침표 같은 존재이다.
* from절에서 얘기했던 IEnumerable<T>의 T가 여기서 결정된다.
* 무명 형식을 통해 새로운 형식을 즉석에서 만들어낼 수도 있다.
* [[Code]](/Code/Chapter15/SimpleLinq.cs)

## 여러 개의 데이터 원본에 질의하기
from문을 중첩으로 사용하면 여러 개의 데이터 원본에 접근할 수 있다.
* [[Code]](/Code/Chapter15/FromFrom.cs)

## group by로 데이터 분류하기
`group A by B into C`<br>
A : from절에서 뽑아낸 범위 변수<br>
B : 분류 기준<br>
C : 그룹 변수<br>

* [[Code]](/Code/Chapter15/GroupBy.cs)

## 두 데이터 원본을 연결하는 join
* [[Code]](/Code/Chapter15/Join.cs)

### 내부 조인
* 교집합과 비슷
* 첫번째 데이터 원본과 두 번째 데이터 원본의 특정 필드를 비교해서 일치하는 데이터를 반환한다. 이때, 기준은 첫 번째 원본 데이터이다.
```c#
from a in A
join b in B on a.XXX equals b.YYY
```

### 외부 조인
* 내부 조인과 비슷
* 조인 결과에 기준이 되는 데이터 원본이 모두 포함된다

### 왼쪽 조인, 오른쪽 조인, 완전 외부 조인
* 왼쪽 조인은 왼쪽 데이터 원본을 기준으로 삼아 조인
* 오른쪽 조인은 오른쪽 데이터 원본을 기준으로 삼아 조인
* 완전 외부 조인은 둘 다 기준으로 삼아 조인

`SQL의 외부 조인에는 이렇게 3가지가 있지만 C#에서는 왼쪽 조인만 지원한다.`

## Linq의 비밀과 Linq 표준 연산자
Linq의 표준 연산자는 [MSDN](https://learn.microsoft.com/ko-kr/dotnet/csharp/programming-guide/concepts/linq/standard-query-operators-overview)을 확인해보자!<br>
<br>
select쪽의 [코드](/Code/Chapter15/SimpleLinq.cs)을 컴파일한다면 C#컴파일러는[코드](/Code/Chapter15/SimpleLinq2.cs)로 바꿔준다.
