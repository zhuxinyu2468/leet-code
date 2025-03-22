# -*- coding: utf-8 -*-
# @Time : 2/07/2022 3:10 PM
# @Author : Patrick
# @File : test.py
# @Software : PyCharm
import itertools
from collections import defaultdict
class IceCreamMachine:

    def __init__(self, ingredients, toppings):
        self.ingredients = ingredients
        self.toppings = toppings

    def scoops(self):
        return list(itertools.product(self.ingredients, self.toppings))

        #return [list(p) for p in itertools.product(self.ingredients, self.toppings)]





if __name__ == "__main__":
    machine = IceCreamMachine(["vanilla", "chocolate"], ["chocolate sauce"])
    print(machine.scoops())  # should print[['vanilla', 'chocolate sauce'], ['chocolate', 'chocolate sauce']]