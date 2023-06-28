A, B = map(int, input().split())
C = int(input())

timelapse_hour = C // 60
timelapse_minute = C % 60

cooking_hour = A + timelapse_hour
cooking_minute = B + timelapse_minute

if cooking_minute >= 60:
    cooking_minute = cooking_minute - 60
    cooking_hour += 1
if cooking_hour >= 24:
    cooking_hour = cooking_hour - 24

print(cooking_hour, cooking_minute)