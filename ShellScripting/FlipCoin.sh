#!/bin/bash
headcount=0
tailcount=0
echo "enter the number of flips to flip"
read t
toss=$t
while [ $toss -gt 0 ]
do
#generating random values
a=$(($RANDOM%2))
echo "....$a"
if [ $a -eq 1 ]
then
headcount=$(($headcount+1))
fi
if [ $a -eq 0 ]
then
tailcount=$(($trailcount+1))
fi
toss='expr $toss-1'
done
echo "................."
echo "headcount=$headcount"
echo "tailcount=$tailcount"
per=100
a='expr $head*100/t'
b='expr $tail*100/t'
echo "head percent $a%,tail percent $b%"





