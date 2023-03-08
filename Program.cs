'''Задача 22: Даны два неупорядоченных набора целых чисел (может быть, с повторениями).
Выдать без повторений в порядке возрастания все те числа, которые встречаются в обоих наборах.
Пользователь вводит 2 числа. n - кол-во элементов первого множества. m - кол-во элементов второго множества.
Затем пользователь вводит сами элементы множеств.



from random import randint
n_set = set(randint(1, 20) for i in range(int(input('Введите кол-во элементов первого множества: '))))
print(n_set)
m_set = set(randint(1, 20) for i in range(int(input('Введите кол-во элементов второго множества: '))))
print(m_set)
s_set = sorted(n_set.intersection(m_set))
print(*s_set)



def recApowB(a, b):
    if b == 0:
        return 1
    return a * recApowB(a, b - 1)

a = int(input('Введите число: '))
b = int(input('Введите степень: '))
print(recApowB(a, b))





def recsum(a, b):
    if b == 0:
        return a
    return 1 + recsum(a, b - 1)

print(recsum(3, 2))