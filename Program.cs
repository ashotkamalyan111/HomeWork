задача 1


a = 123
print(a//100 + a//10%10 + a%10)

# или

num = input('Введите 3-х значное число: ')
res = 0
if len(num) == 3:
    for i in num:
        res += int(i)
    print(res)
else:
    print('Вы ввели не 3-х значное число')





    задача 2 


    s = 60
print('Петя и Сережа сделали по', s/6, 'шт')
print('Маша сделала ', s/6*4, 'шт')








задача 3


t = input('Введите номер билета: ')
l = int(t[0]) + int(t[1]) + int(t[2])
r = int(t[3]) + int(t[4]) + int(t[5])
if l == r:
    print('Yes')
else:
    print('NO')
# или
s = input('Введите 6-значный номер билета: ')
if len(s) != 6:
    print(f'Число {s} не 6-ти значное')
else:
    res1 = 0
    res2 = 0
    for i in range(len(s)//2):
        res1 += int(s[i])
        res2 += int(s[len(s)//2 + i])
    if res1 == res2:
        print(f'{s} счастливый номер')
    else:
        print(f'{s} не счастливый номер')



        задача 4 


        n,m,k = int(input('В-те 1-ю сторону: ')),int(input('В-те 2-ю сторону: ')),int(input('В-те кол-во долек: '))
if k%n == 0 or k%m == 0:
    print('Yes')
else: print('No')
# или
if k < n*m and (k % n == 0 or k % m == 0):