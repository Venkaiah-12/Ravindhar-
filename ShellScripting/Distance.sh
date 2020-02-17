#!/bin/bash -x 
echo "enter the input point "
read x
echo "enter the output point"
read y
mul=$((x * x))
mul1=$((y * y))
dist=$(($mul + $mul1))
a=$(awk -v x=$dist 'BEGIN{print sqrt(x)}')
echo $a


