# 45. Показать числа Фибоначчи

def Fibonacci_numbers(amount: int) -> list[int]:
    numbers = [0, 1]
    for i in range(2, amount):
        numbers.append(numbers[i - 1] + numbers[i - 2])
    return numbers


print(*Fibonacci_numbers(15))
