using System;

string? userSetting = null;
string? profileSetting = null;
string? globalSetting = null;
int? defaultValue  = null;

Console.WriteLine("=== 설정 결정 ===");
Console.WriteLine($"플레이어 이름: {userSetting ??="프로필유저"} (프로필 설정에서 가져옴)");
Console.WriteLine($"서버 주소 {profileSetting ??= "localhost"} (기본값에서 가져옴)");
Console.WriteLine($"언어: {globalSetting ??= "English"} (사용자 설정에서 가져옴)");
Console.WriteLine($"볼륨: {defaultValue ??= 70} (전역 설정에서 가져옴)");
Console.WriteLine();
Console.WriteLine("=== 캐시 저장 (??=) ===");
string? cashusersetting = null;
Console.WriteLine($"캐시 저장 전: {cashusersetting}");
Console.WriteLine($"첫 번째 ??= 적용 후: {cashusersetting ??= "프로필유저"}");
Console.WriteLine($"두 번째 ??= 적용 후: {cashusersetting ??= "프로필유저"}");
Console.WriteLine();
Console.WriteLine("=== 최종 설정 ===");
Console.WriteLine($"플레이어 이름: {userSetting}");
Console.WriteLine($"서버 주소: {profileSetting}");
Console.WriteLine($"언어: {globalSetting}");
Console.WriteLine($"볼륨: {defaultValue}");