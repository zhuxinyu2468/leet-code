# -*- coding: utf-8 -*-
# @Time : 12/04/2023 10:57 PM
# @Author : Patrick
# @File : 242.py
# @Software : PyCharm

def isAnagram(s, t):
    """
    :type s: str
    :type t: str
    :rtype: bool
    """
    a = {}
    d = {}
    for i in s:
        d[i] = s.count(i)
    for y in t:
        a[y] = t.count(y)
    print(a,d)
    if a == d:
        return 'true'
    else:
        return 'false'


print(isAnagram('car', 'rat'))