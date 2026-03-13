using System;
using System.Collections.Generic;

List<string> player1items = null;
List<string> player2Items  = null;
List<string> Player3Items = new List<string> { "검", "방패", "포션" };
int count = 0;

Console.WriteLine("=== 플레이어 1 (인벤토리 없음) ===");

Console.WriteLine($"아이템 수: {player1items?.Count ?? 0}");
Console.WriteLine($"첫 번째 아이템: {player1items?[0]??"없음"}");
Console.WriteLine($"마지막 아이템: {player1items?[^1]??"없음"}");
Console.WriteLine();
Console.WriteLine("=== 플레이어 2 (빈 인벤토리) ===");
Console.WriteLine($"아이템 수: {player2Items?.Count ?? 0}");
Console.WriteLine($"첫 번째 아이템: {player2Items?[0]??"없음"}");
Console.WriteLine($"마지막 아이템: {player2Items?[^1]??"없음"}");
Console.WriteLine();
Console.WriteLine("=== 플레이어 3 (아이템 보유) ===");
Console.WriteLine($"아이템 수: {Player3Items?.Count ?? 0}");
Console.WriteLine($"첫 번째 아이템: {Player3Items?[0]??"없음"}");
Console.WriteLine($"마지막 아이템: {Player3Items?[^1]??"없음"}");

