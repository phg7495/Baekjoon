words = input().upper()
alphabet = list("ABCDEFGHIJKLMNOPQRSTUVWXYZ")
count_frequency = 0
alphabet_most_frequent = ""
num = 0

for i in alphabet:
    if count_frequency < words.count(i):
        count_frequency = words.count(i)
        alphabet_most_frequent = i
        num = 0
    if count_frequency == words.count(i) and alphabet_most_frequent != i:
        num = 1

if num == 1:
    print("?")
else:
    print(alphabet_most_frequent)