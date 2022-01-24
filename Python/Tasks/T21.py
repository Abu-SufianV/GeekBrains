# 21. Программа проверяет пятизначное число на палиндромом.

def is_palindrome(number: int) -> bool:
    number = str(number)
    return True if number[0] == number[-1] and number[1] == number[-2] else False


print(is_palindrome(12321))
print(is_palindrome(12345))
