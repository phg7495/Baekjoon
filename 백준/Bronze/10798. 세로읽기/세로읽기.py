words = []
for i in range(5):
    words.append(input())

for i in range(15):
    for j in range(5):
        if len(words[j]) > i:
            print(words[j][i],end="")