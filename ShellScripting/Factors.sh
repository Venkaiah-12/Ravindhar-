#!/bin/bash
echo "enter the number  to factors"
read n
num=$n
factors=1
for (( factor=2; factor<=$n; factor++ ))
do
#checking prime factors
while [ $((num%$factor)) == 0 ] ;
do
echo $factor
num=$((num/$factor))
done
done



