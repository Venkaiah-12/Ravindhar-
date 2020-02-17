#!/bin/bash -x
echo "enter the temperature "
read t
echo "enter the speed"
read v
if [ $t -lt 51 -a $v -lt 120 -a $v -gt 3 ]
then
w=$(echo "$t $v" | awk '{ print 35.74+0.6215*$1+(0.4275*$1-35.75)*$2^0.16 }')
echo $w
else
echo "your not in range"
fi
