import sys

# Переменные для хранения чисел
a = 0
b = 0

def input_a():
    global a
    try:
        a = float(input("Введите число A: "))
        print(f"Значение A сохранено: {a}")
    except ValueError:
        print("Ошибка! Введите числовое значение.")
def input_b():
    global b
    try:
        b = float(input("Введите число B: "))
        print(f"Значение B сохранено: {b}")
    except ValueError:
        print("Ошибка! Введите числовое значение.")