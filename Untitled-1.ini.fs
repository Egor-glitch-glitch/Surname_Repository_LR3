def input_b():
    global b
    try:
        b = float(input("Введите число B: "))
        print(f"Значение B сохранено: {b}")
    except ValueError:
        print("Ошибка! Введите числовое значение.")

def multiply():
    result = a * b
    print(f"Результат умножения ({a} * {b}) = {result}")

def divide():
    if b != 0:
        result = a / b
        print(f"Результат деления ({a} / {b}) = {result}")
    else:
        print("Ошибка: Деление на ноль невозможно!")

def main():
    while True:
        print("\n--- Меню (Вариант 3 - Python) ---")
        print("1. Ввести А")
        print("2. Ввести В")
        print("3. Выполнить операцию '*' (A * B)")
        print("4. Выполнить операцию '/' (A / B)")
        print("0. Выход")
        
        choice = input("Выберите пункт меню: ")
        
        if choice == '1':
            input_a()
        elif choice == '2':
            input_b()
        elif choice == '3':
            multiply()
        elif choice == '4':
            divide()
        elif choice == '0':
            print("Выход из программы.")
            break
        else:
            print("Неверный выбор, попробуйте снова.")

if __name__ == "__main__":
    main()