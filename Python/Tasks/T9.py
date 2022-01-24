#  8. Показать четные числа от 1 до N


def show_even_numbers(stop: int) -> None:
    for i in range(1, stop + 1):
        if i % 2 == 0:
            print(i, end=' ')


end = int(input("Введите конец: "))
show_even_numbers(end)
