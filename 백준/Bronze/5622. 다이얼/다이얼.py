word = input()
time = 0

for i in word:
    ascii_word = ord(i)
    if ascii_word == 83:
        time += (ascii_word-56)//3 - 1
    elif ascii_word > 83 and ascii_word < 90:
        time += (ascii_word-57)//3
    elif ascii_word == 90:
        time += (ascii_word-57)//3 - 1
    else:
        time +=(ascii_word-56)//3
print(time)