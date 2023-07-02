num_list = []
max_num = 0
row = 0
column = 0
for i in range(9):
    num_list.append(list(map(int, input().split())))

for i in range(9):
    if max_num <= max(num_list[i]):
        max_num = max(num_list[i])
        row = i+1
        column = num_list[i].index(max_num)+1

print(max_num)
print(row, column)