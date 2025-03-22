# -*- coding: utf-8 -*-
# @Time : 2/07/2022 4:53 PM
# @Author : Patrick
# @File : test.py
# @Software : PyCharm
def pipeline(*funcs):
    def helper(arg):
        for i in funcs:

            total = i(arg)

            arg = total
        return total
        pass

    return helper


fun = pipeline(lambda x: x * 3, lambda x: x + 1, lambda x: x / 2)
print(fun(3))  # should print 5.0