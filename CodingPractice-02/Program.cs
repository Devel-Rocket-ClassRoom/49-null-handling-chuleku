using System;
using System.Collections.Generic;

// 1-1 기본 사용법
/*string? name = null;
string newname;
Console.WriteLine(name??="이름 없음");
newname = name;
Console.WriteLine(newname);
*/

// 1-2. if문과의 비교
/*string? playerName = null;
if(playerName == null)
{
    playerName = "플레이어";
}
Console.WriteLine(playerName);*/

// 2-1. 기본 사용법
/*string? message = null;
int? result = message?.Length;
Console.WriteLine($"길이: {result}");
message = "안녕하세요";
result = message.Length;
Console.WriteLine($"길이: {result}");*/

// 2-2. NullReferenceException 방지
/*string text = null;
if(text?.Length == null)
{
    Console.WriteLine("텍스트가 없습니다.");
}*/

// 2-3. 메서드 호출에 사용
/*string? name = null;
Console.WriteLine($"대문자: {name?.ToUpper()}");
name = "Hello";
Console.WriteLine($"대문자: {name?.ToUpper()}");*/

// 2-4.체이닝
/*string? text = null;
Console.WriteLine($"결과: {text?.ToUpper()?.Trim()}");
text = "   hello   ";
Console.WriteLine($"결과: {text?.ToUpper()?.Trim()}");*/

// 2-5.컬렉션과 함께 사용
/*List<string> items = null;
int? count = items?.Count;
Console.WriteLine($"아이템 수: {count}");
items = new List<string>{"사과", "바나나"};
count = items?.Count;
Console.WriteLine($"아이템 수: {count}");*/

//2-6. 인덱서와 함께 사용 (?[])
/*string text = null;
char? firstChar = text?[0];
Console.WriteLine($"첫 글자: {firstChar}");

text = "Hello";
firstChar = text?[0];
Console.WriteLine($"첫 글자: {firstChar}");*/

// 3-1. ?.와??의 조합
/*string message = null;
int length = message?.Length ?? 0; 
Console.WriteLine($"길이: {length}");

message = "Hello";
length = message?.Length ?? 0;
Console.WriteLine($"길이: {length}");*/
//3-2. 컬렉션에서의 조합 활용
/*List<string> names = null;
int? count = names?.Count ?? 0;
Console.WriteLine($"이름 수: {count}");
names = new List<string> { "kim", "Lee", "Park" };
count = names?.Count ?? 0;
Console.WriteLine($"이름 수: {count}");*/
//3-3. 실용적인 예제
string playerName = null;
int? playerLevel = null;
List<string> inventory = null;

string displayName = playerName ?? "Unknown";
int level = playerLevel ?? 1;
int itemCount = inventory?.Count ?? 0;

Console.WriteLine($"플레이어: {displayName}");
Console.WriteLine($"레벨: {level}");
Console.WriteLine($"인벤토리 아이템: {itemCount}개");
