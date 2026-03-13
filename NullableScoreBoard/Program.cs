using System;

int?[] scores = { 3, null, 7, null, 5 };
int? count = 0;
int total = 0;
int count1 = 0;
Console.WriteLine("=== 경기 상태 ===");
foreach(var score in scores)
{
    if(score.HasValue==false)
    {
        count++;
        Console.WriteLine($"경기 {count}: 미진행");
    }
    else
    {
        count++;
        Console.WriteLine($"경기 {count}: {score.Value}점 (진행 완료)");
    }
}
Console.WriteLine();
Console.WriteLine("=== 전체 점수 (미진행 = -1) ===");
count = 0;
foreach( var score in scores)
{
    if (score.HasValue==false)
    {
        count++;
        Console.WriteLine($"경기 {count}: -1");
    }
    else
    {
        count++;
        count1++;
        total += score.Value;
        Console.WriteLine($"경기 {count}: {score.Value}");
    }
}
Console.WriteLine();
Console.WriteLine("=== 통계 ===");
Console.WriteLine($"진행된 경기 수: {count1}");
Console.WriteLine($"총점: {total}");
Console.WriteLine($"평균: {total/count1}");