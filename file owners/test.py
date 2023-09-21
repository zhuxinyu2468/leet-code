# -*- coding: utf-8 -*-
# @Time : 2/07/2022 2:50 PM
# @Author : Patrick
# @File : test.py
# @Software : PyCharm
from collections import defaultdict


def group_by_owners(files):
    d = defaultdict(list)
    for k, v in files.items():
        d[v] += [k]

    return d

if __name__ == "__main__":
    files = {
        'Input.txt': 'Randy',
        'Code.py': 'Stan',
        'Output.txt': 'Randy'
    }
    print(group_by_owners(files))