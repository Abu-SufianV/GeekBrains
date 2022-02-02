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
