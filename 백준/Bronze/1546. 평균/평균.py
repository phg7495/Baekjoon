N = int(input())
scoreSum = 0

score = list(map(int, input().split(' ')))

for i in score:
    scoreSum += i

scoreAvr = scoreSum/max(score)*100/N
print(scoreAvr)