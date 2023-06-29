croatian_alphabet = ["c=","c-","dz=","d-","lj","nj","s=","z="]
word = input()
count = len(word)

for i in croatian_alphabet:
    for j in range(len(word)-1):
        if word[j]+word[j+1] == i:
                count -= 1
                if word[j-1]+word[j]+word[j+1] == "dz=" and j!=0:
                    count -= 1
print(count)