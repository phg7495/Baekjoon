dice_score = list(map(int, input().split()))
count = 1

for i in range(2):
    for j in range(i+1,3):
        if dice_score[i] == dice_score[j]:
            count += 1
            dice_same = dice_score[i]
    if count == 3:
            break
            
if count == 3:
    print(10000 + dice_same*1000)
elif count == 2:
    print(1000 + dice_same*100)
else:
    print(max(dice_score)*100)