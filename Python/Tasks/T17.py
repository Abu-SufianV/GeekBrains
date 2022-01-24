# 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным


def day_is_weekend(number: int) -> bool:
    return True if number == 6 or number == 7 else False


print(day_is_weekend(7))
