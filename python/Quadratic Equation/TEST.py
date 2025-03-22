# -*- coding: utf-8 -*-
# @Time : 2/07/2022 4:03 PM
# @Author : Patrick
# @File : TEST.py
# @Software : PyCharm
import math
def find_roots(a, b, c):
    d = (b ** 2) - (4 * a * c)
    sqrtval = math.sqrt(abs(d))

    return (-b + sqrtval) / (2 * a), (-b - sqrtval) / (2 * a)


print(find_roots(1, 2, 1))
print(find_roots(2, 10, 8))