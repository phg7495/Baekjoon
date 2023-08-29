start, end = map(int,input().split())

num_sequence = []
for i in range(1000):
    for j in range(i):
        num_sequence.append(i)
        
add = 0
for i in range(start-1,end):
    add += num_sequence[i]
print(add)