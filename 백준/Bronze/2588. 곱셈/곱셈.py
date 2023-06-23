num1 = int(input())
num2 = int(input())

arr_num2 = [int(num2) for num2 in str(num2)]

num3 = num1*arr_num2[-1]
print(num3)

num4 = num1*arr_num2[-2]
print(num4)

num5 = num1*arr_num2[-3]
print(num5)

result = num3+num4*10+num5*100
print(result)