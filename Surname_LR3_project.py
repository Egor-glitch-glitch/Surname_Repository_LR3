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