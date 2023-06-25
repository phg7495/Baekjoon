num_list = []
while True:
    num = int(input())
    if num == -1:
        break
    num_list.append(num)
    
for i in range(len(num_list)):
    divisor = []
    
    for j in range(1,int(num_list[i]**(1/2))+1):
        if num_list[i] % j == 0:
            divisor.append(j)
            if j**2 != num_list[i]:
                if j != 1:
                    divisor.append(num_list[i]//j)
    divisor.sort()
    
    if num_list[i] == sum(divisor):
        print(f"{num_list[i]} = {divisor[0]} ", end="")
        for j in range(1,len(divisor)):
            print(f"+ {divisor[j]} ", end = "")
        print()
    else:
        print(f"{num_list[i]} is NOT perfect.")