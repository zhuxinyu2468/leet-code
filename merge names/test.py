# -*- coding: utf-8 -*-
# @Time : 2/07/2022 2:33 PM
# @Author : Patrick
# @File : test.py
# @Software : PyCharm
def unique_names(names1, names2):
    a = set()
    joinedlist = names1 + names2
    for name in joinedlist:
        if name not in a:
            a.add(name)
    return a

    # return list(set(names1).union(set(names2)))

if __name__ == "__main__":
    names1 = ["Ava", "Emma", "Olivia"]
    names2 = ["Olivia", "Sophia", "Emma"]
    print(unique_names(names1, names2))  # should print Ava, Emma, Olivia, Sophia