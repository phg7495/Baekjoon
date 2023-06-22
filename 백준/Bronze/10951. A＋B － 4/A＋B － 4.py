A = []
B = []

try:
    while True:
        inputNum = input()
        if inputNum == '':
            break
        a, b = inputNum.split(' ')
        if a == '' or b == '':
            break
        
        A.append(int(a))
        B.append(int(b))
except EOFError:
    pass

for i in range(len(A)):
    print(A[i] + B[i])