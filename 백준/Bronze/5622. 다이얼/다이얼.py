word = input()
alphabet = ["ABC", "DEF", "GHI", "JKL", "MNO", "PQRS", "TUV", "WXYZ"]
time = 0

for i, alphabet_group in enumerate(alphabet):
    for j in word:
        if j in alphabet_group:
            time += i+3

print(time)