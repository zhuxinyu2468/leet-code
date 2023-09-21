# -*- coding: utf-8 -*-
# @Time : 13/07/2023 10:20 PM
# @Author : Patrick
# @File : area_calculation.py.py
# @Software : PyCharm
import math


def rectangle_area(width, height):
    return width * height


def circle_area(radius):
    return math.pi * radius ** 2


def triangle_area(base, height):
    return 0.5 * base * height


def square_area(length):
    return length ** 2


def trapezium_area(base, top, height):
    return 0.5 * (base + top) * height
