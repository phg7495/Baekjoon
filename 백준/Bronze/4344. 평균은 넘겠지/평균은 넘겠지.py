C = int(input())
topClass = []

for i in range(C):
    add = 0
    average = 0
    scoreInput = input().split(' ')
    countStudent = int(scoreInput[0])
    count = 0
    for j in range(1,countStudent+1):
        add = add + int(scoreInput[j])
    average = (add/countStudent)
    
    for j in range(1,int(scoreInput[0])+1):
        if(int(scoreInput[j])>average):
            count += 1
    topClass.append(count/countStudent*100)

for k in range(len(topClass)):
    print(f"{round(topClass[k],3):.3f}%")