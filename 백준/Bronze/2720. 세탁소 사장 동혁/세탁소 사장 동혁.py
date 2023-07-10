T = int(input())

for i in range(T):
    C = int(input())

    qu = C//25
    C = C%25
    print(qu, end=" ")
    
    di = C//10
    C = C%10
    print(di, end=" ")

    ni = C//5
    C = C%5
    print(ni, end=" ")
    
    print(C)