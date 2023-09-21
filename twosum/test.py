# -*- coding: utf-8 -*-
# @Time : 29/06/2022 6:34 PM
# @Author : Patrick
# @File : test.py
# @Software : PyCharm
def find_two_sum(numbers, target_sum):
    """
    :param numbers: (list of ints) The list of numbers.
    :param target_sum: (int) The required target sum.
    :returns: (a tuple of 2 ints) The indices of the two elements whose sum is equal to target_sum
    """
    seen = {}

    for i, value in enumerate(numbers):
        remaining = target_sum - numbers[i]

        if remaining in seen:
            return i, seen[remaining]

        seen[value] = i

if __name__ == "__main__":
    print(find_two_sum([3, 1, 5, 7, 5, 9], 10))