#!/bin/python3

import sys
import numbers


S = input().strip()


try:
    print (int(S))
except ValueError:
    print ("Bad String")
