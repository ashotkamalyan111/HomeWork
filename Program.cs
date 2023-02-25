задача 1 


N = int(input('Введите количество монет '))
orel = reshka = 0
for i in range(N):
    x = int(input('Орел(1) или решка(0)? '))
    if x == 1:
        orel += 1
    else:
        reshka += 1
if orel < reshka:
    print(f'Переверните {orel} монет с орла на решку, их меньше всего')
elif orel == reshka:
    print(f'Количество орлов и решек одинаково, по {orel} штук')
else:
    print((f'Переверните {reshka} монет с решки на орла, их меньше всего'))


    задача 2


    x = abs(int(input('Введите первое натуральное число X ')))
y = abs(int(input('Введите второе натуральное число Y ')))
S = x + y
P = x * y
y1 = int((S + ((-S) ** 2 - 4 * P) ** 0.5) / 2)
x1 = int((S - ((-S) ** 2 - 4 * P) ** 0.5) / 2)
print(x1, y1)



задача 3 



def main():
    input_file = open("input.txt", "r")
    output_file = open("output.txt", "w")
    line = input_file.readline().split()
    n = int(line[0])
    k = 0
    m = 0
    for i in range(n):
        line = input_file.readline().split()
        if int(line[0]) == 0:
            k = k + 1
        if int(line[0]) == 1:
            m = m + 1
    print(m, k)
 
    if m > k:
        ans = k
    else:
        ans = m
 
 
    print(ans)
    output_file.write(str(ans) + "\n")
 
 
if __name__ == "__main__":
    main()