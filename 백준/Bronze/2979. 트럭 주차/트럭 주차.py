A, B, C = map(int, input().split())
arriving = []
leaving = []
car_count = 0
total = 0

for i in range(3):
    a, b = map(int, input().split())
    arriving.append(a)
    leaving.append(b)

for time in range(min(arriving),max(leaving)+1):
    for i in range(3):
        if time == arriving[i]:
            car_count += 1
        if time == leaving[i]:
            car_count -= 1

    if car_count == 1:
        total += A
    elif car_count == 2:
        total += B * 2
    elif car_count == 3:
        total += C * 3

print(total)