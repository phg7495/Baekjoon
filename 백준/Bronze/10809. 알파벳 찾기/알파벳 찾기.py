S = input()

i=0
while i<26:
    try:
        print(S.index(chr(97+i)), end=" ")
        i+=1
    except:
        print(-1, end=" ")
        i+=1