#!/bin/python3

import math
import os
import random
import re
import sys



if __name__ == '__main__':
    n = int(input().strip())

    a = list(map(int, input().rstrip().split()))

# Write your code here
num_swaps = 0
swap_in_pass = True

while swap_in_pass:
    swap_in_pass = False
    for i in range(n-1):
        if a[i] > a[i+1]:
            a[i], a[i+1] = a[i+1], a[i]
            num_swaps += 1
            swap_in_pass= True

print('Array is sorted in {} swaps.'.format(num_swaps))
print('First Element: {}'.format(a[0]))
print('Last Element: {}'.format(a[-1]))
