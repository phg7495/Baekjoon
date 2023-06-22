priceTotal = int(input())
productCount = int(input())
priceSum = 0


for i in range(productCount):
    price, amount = map(int, input().split(' '))
    priceSum += price*amount

if priceTotal == priceSum:
    print("Yes")
else:
    print("No")