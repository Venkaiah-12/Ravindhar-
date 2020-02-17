#!/bin/bash 
echo "enter the value of a"
read a
echo "enter the value of b"
read b
echo "enter the value of c"
read c
delta=$((b * b - 4 * a * c))
d=$(awk -v x=$delta 'BEGIN{print sqrt(x)}')
#if the roots are greater than and real
if [ $delta -gt 0 ]
then
root1=$((-b + d/2 * a))
root2=$((-b - d/2 * a))
echo "$root1 $root2"
fi
else
#roots are real and equal
if [ $delta -eq 0 ]
then
root1=root2=$((-b + d/2 * a))
echo "$root1 $root2"
fi
else
#roots are not equal and not real
realpart=$((-b/2 * a))
imaginarypart=$((delta/2*a))
echo "$realpart $imaginarypart"



