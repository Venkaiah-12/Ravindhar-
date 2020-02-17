#!/bin/bash
echo "enter the year to check"
read y
year=$y
#checking the condition equal to o and not equal to 0
if [ $(($y % 4)) -eq 0 ]|| [ $(($y % 400)) -eq 0 ] && [ $(($y % 100)) != 0 ]
then
echo "$year is leap year"
else
echo "$year is not leap year"
fi 
