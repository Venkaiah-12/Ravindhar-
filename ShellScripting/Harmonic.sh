#!/bin/bash  
echo "enter the number to find series upto "
read n
sum=0
declare -i num=$n
for (( i = 1; i <= $num; $((i++)) ))
do
#generating the series
a=""+"1/$i"
sum=($sum$a) 
done
echo $sum 
