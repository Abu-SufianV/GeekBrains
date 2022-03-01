from random import randint as rand


def show_array(arr: list[int]) -> None:
    """
    Выводит в консоль отформатированный массив из целых чисел

    :param arr: Массив, который нужно вывести
    """
    for i in range(len(arr)):
        if i % 10 == 0 and i != 0:
            print()
        print("{:6}".format(arr[i]), end="")
    print("\n")
    return None


def show_matrix(arr: list) -> None:
    """
    Выводит в консоль отформатированный двумерный массив из целых чисел

    :param arr: Массив, который нужно вывести
    """
    for i in range(len(arr)):
        for j in range(len(arr[i])):
            print("{:6}".format(arr[i][j]), end="")
        print()
    print("\n")
    return


def fill_array(arr: list[int], value: int):
    for i in range(len(arr)):
        arr[i] = rand(0, value)


def fill_matrix(arr: list, value: int):
    for i in range(len(arr)):
        for j in range(len(arr[i])):
            arr[i][j] = rand(0, value)
