#!/bin/bash
source Utility.sh
echo "i am generating random numbers first"
echo "enter the length of the coupon"
read m
echo "How much coupons needed"
read numbers
#calling  to  function 
Coupon $m $numbers


