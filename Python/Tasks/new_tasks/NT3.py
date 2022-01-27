# 3. Пользователь задаёт две строки. Определить количество вхождений одной строки в другой.


def amount_occur(line: str, sub_line: str):
    return line.count(sub_line)


print(amount_occur('aasdadsa', 's'))
