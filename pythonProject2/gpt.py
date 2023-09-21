# # -*- coding: utf-8 -*-
# # @Time : 13/07/2023 11:31 PM
# # @Author : Patrick
# # @File : gpt.py
# # @Software : PyCharm
# from concurrent.futures import ProcessPoolExecutor
# from area_calculation import *
# import pandas as pd
# import time
# import json
#
# # Update the function to handle missing or wrong type of data gracefully
# def calculate_area(shape):
#     try:
#         calculation_functions = {
#             'rectangle': rectangle_area,
#             'triangle': triangle_area,
#             'circle': circle_area,
#             'square': square_area,
#             'trapezium': trapezium_area,
#         }
#         if shape['type'] in calculation_functions:
#             func = calculation_functions[shape['type']]
#             parameters = {k: float(v) for k, v in shape.items() if k != 'type'}
#             return func(**parameters)
#         else:
#             return 0
#     except (KeyError, ValueError) as e:
#         print(f"Error in record {shape}: {e}")
#         return 0
#
# # Use a process pool executor to parallelize the calculations
# def calculate_total_area(shape_data):
#     with ProcessPoolExecutor() as executor:
#         areas = executor.map(calculate_area, shape_data)
#     return sum(areas)
#
# def main():
#     s_t = time.time()
#
#     with open("data.json") as f:
#         shape_data = [json.loads(s) for s in f.readlines()]
#
#     total_area = calculate_area(shape_data)
#
#     print(total_area)
#
#     e_t = time.time()
#     print(e_t - s_t)
#
# if __name__ == "__main__":
#     main()


import json
import time
from area_calculation import *

start_time = time.time()

area_calculations = {
    'rectangle': rectangle_area,
    'triangle': triangle_area,
    'circle': circle_area,
    'square': square_area,
    'trapezium': trapezium_area,
}

def calculate_area(shape):
    try:
        calculation = area_calculations.get(shape['type'])
        if calculation:
            if shape['type'] == 'rectangle' or shape['type'] == 'square':
                area = calculation(float(shape['width']), float(shape['height']))
            elif shape['type'] == 'circle':
                area = calculation(float(shape['radius']))
            elif shape['type'] == 'trapezium':
                area = calculation(float(shape['base']), float(shape['top']), float(shape['height']))
            else:
                area = calculation(float(shape['base']), float(shape['height']))
            return area
        else:
            return 0
    except KeyError as e:
        print(f"Error: missing field {e} in record {shape}")
        return 0
    except ValueError as e:
        print(f"Error: non-numeric value in record {shape}")
        return 0

with open("data.json") as f:
    shape_data = [json.loads(s) for s in f.readlines()]

total_area = sum(calculate_area(shape) for shape in shape_data)

print(total_area)

end_time = time.time()
print(end_time - start_time)


