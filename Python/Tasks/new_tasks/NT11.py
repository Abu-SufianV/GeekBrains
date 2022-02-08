# 11. Определить, позицию второго вхождения строки в списке либо сообщить, что его нет.

def foo(line: str, sub_line: str) -> int | bool:
    result = line
    count = 0
    if sub_line in result:
        try:
            return result.index(sub_line, result.index(sub_line) + 1)
        except ValueError:
            return False
    return False


print(foo('123121', '31'))
