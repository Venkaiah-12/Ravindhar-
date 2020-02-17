#!/bin/bash
source Utility.sh
echo "enter size of array"
read size
echo "enter the array elements"
for (( i=0; i<$size; i++ ))
do
read a[$i]
done
#call the function
SumOfZero $a $size

