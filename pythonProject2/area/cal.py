# -*- coding: utf-8 -*-
# @Time : 15/07/2023 12:41 AM
# @Author : Patrick
# @File : cal.py
# @Software : PyCharm
import json
import math


def cal_fn_re(w, d):
    return w * d


def cal_fn_cir(r):
    return math.pi * r ** 2


def cal_fn_tri(b, h):
    return 0.5 * b * h


def cal_area(data):
    data_type = data['type']
    if data_type == 'triangle':
        return cal_fn_tri(data['base'], data['height'])
    elif data_type == 'circle':
        return cal_fn_cir(data['radius'])
    elif data_type == 'rectangle':
        return cal_fn_re(data['width'], data['height'])
    else:
        print(f'invalid type {data_type} in {data}')
        return 0


def main():
    with open('../data.json') as f:
        data = [json.loads(i) for i in f.readlines()]
    area = 0
    for d in data:
        area += cal_area(d)
    print(area)


if __name__ == "__main__":
    main()
