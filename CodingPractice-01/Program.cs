using System;
using System.Data;

// 1. null의 개념
/*int number = 0;          
string text = "";         
string nothing = null; 
Console.WriteLine(number); 
Console.WriteLine(text);    
Console.WriteLine(nothing);*/

// 2. 값 형식과 참조 형식의 null 처리
/*string name = null;
Console.WriteLine(name==null);*/

// 3-1. Nullable 형식 선언
/*int? intNullable = null;
double? doublenullable = null;
bool? boolnullable = null;
Nullable<int> anotherint = null;
Nullable<double> anotherdouble = null;

Console.WriteLine(intNullable);
Console.WriteLine(doublenullable);
Console.WriteLine(boolnullable);*/

//3-2. HasValue와 Value 속성
/*int? score = null;

Console.WriteLine($"score.HasValue: {score.HasValue}");  
score = 95;
Console.WriteLine($"score.HasValue: {score.HasValue}");  
Console.WriteLine($"score.Value: {score.Value}");*/

// 3-3. HasValue 조건 분기
/*int? empty = null;
if(empty.HasValue)
{
    Console.WriteLine($"{empty.Value}");
}
else
{
    Console.WriteLine("값이 없습니다.");
}*/
// 3-4. GetValueOrDefault 메서드
/*int? level = null;
int dlevel = level.GetValueOrDefault();
Console.WriteLine($"기본값 사용: {dlevel}");
int dlevel1 = level.GetValueOrDefault(1);
Console.WriteLine($"커스텀 기본값: {dlevel1}");
level = 50;
Console.WriteLine($"값이 있을 때: {level}");
*/

// 3-5. Nullable 형식의 변환
/*int number = 42;
int? nullable = number;
int back = (int)nullable;

Console.WriteLine($"nullable: {nullable}");
Console.WriteLine($"back: {back}");
*/

// 4-1 기본 사용법
/*string? mesage = null;
mesage ??= "기본메세지";
string result = (string)mesage;
Console.WriteLine(result);
mesage = "안녕하세요";
Console.WriteLine(mesage);
*/

//4-2. if문과의 비교
/*string? input = null;
string output;
if(input == null)
{
    output = "기본값";
}
else
{
    output = input;
}
Console.WriteLine($"if문 결과: {output}");
Console.WriteLine($"?? 연산자 결과: {input??= output}");
*/

//4-3. Nullable 값 형식과 함께 사용
/*int? score = null;
int? health = null;
Console.WriteLine($"점수: {score??=-1}");
Console.WriteLine($"체력: {health??=default(int)}");
*/

//4-4. 연속 사용 (체이닝)
string first = null;
string second = null;
string third = "세 번째 값";
Console.WriteLine($"{first??second??third}");
