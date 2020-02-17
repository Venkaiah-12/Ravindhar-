#!/bin/bash
echo "enter the number to find poweroftwo"
read n
num=$n
i=1
poweroftwo=1
for (( i=0;i<=num; i++ ))
do 
echo "poweroftwo $poweroftwo"
#multiply poweroftwo with  i 
poweroftwo=$(( $poweroftwo *2 ))
done

