#  7. Показать числа от -N до N

from matplotlib.pyplot import show


def show_numbres(start: int, stop: int) -> None:
    for i in range(start, stop + 1):
        print(i, end=" ")


begin = int(input("Введите начало: "))
end = int(input("Введите конец: "))
show_numbres(begin, end)
