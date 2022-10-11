#!/bin/python3

import math
import os
import random
import re
import sys



if __name__ == '__main__':

    arr = []
    add = []
    max_sum = []
    
    for _ in range(6):
        arr.append(list(map(int, input().rstrip().split())))
        for i in range(len(arr)-2):
            for j in range(4):
                add.extend(arr[i][j:j+3])
                add.append(arr[i+1][j+1])
                add.extend(arr[i+2][j:j+3])
                max_sum.append(sum(add))
                add = []

    print(max(max_sum))
