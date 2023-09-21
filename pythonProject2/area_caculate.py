# -*- coding: utf-8 -*-
# @Time : 13/07/2023 8:16 PM
# @Author : Patrick
# @File : area_calculate.py
# @Software : PyCharm


import json
import time

from area_calculation import *

s_t = time.time()


def calculate_area(shape, index):
    try:
        shape_type = shape['type']
        if shape_type == 'rectangle':
            width = float(shape['width'])
            height = float(shape['height'])
            area = rectangle_area(width, height)
            return area
        elif shape_type == 'triangle':
            base = float(shape['base'])
            height = float(shape['height'])
            area = triangle_area(base, height)
            return area
        elif shape_type == 'circle':
            radius = float(shape['radius'])
            area = float(circle_area(radius))
            return area
        elif shape_type == 'square':
            length = shape['length']
            area = square_area(length)
            return area
        elif shape_type == 'trapezium':
            base = shape['base']
            top = shape['top']
            height = shape['height']
            area = trapezium_area(base, top, height)
            return area
        else:
            return 0
    except ValueError:
        print(f'Error: This {shape} with index {index} has invalid data type')
        return 0
    except KeyError:
        print(f'Error: This {shape} with index {index} has missing attributes')
        return 0


def main():
    with open("data.json") as f:
        shape_data = [json.loads(s) for s in f.readlines()]

    total_area = 0

    for index, shape in enumerate(shape_data):
        total_area += calculate_area(shape, index)

    print(f'Total area of all shapes is {total_area}')
    e_t = time.time()
    print(e_t - s_t)


if __name__ == "__main__":
    main()
