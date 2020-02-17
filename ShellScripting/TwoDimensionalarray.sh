#!/bin/bash
declare -A a
echo "enter the no of for rows"
read m
rows=$m
echo "enter the no of  colums"
read n
colums=$n
for (( i=0; i<rows; i++ ))
do
for (( j=0; j< colums; j++ ))
do
#taking user input inserting in to array
read a[${i},${j}]
done
done
for (( l=0; l<rows; l++ ))
do
for (( k=0; k<colums; k++ ))
do
#printing array elements
echo -ne "${a[${l},${k}]}\t"
done
echo
done 

