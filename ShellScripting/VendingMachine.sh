#!/bin/bash   
declare -a NotesCount
declare -a Deno
NotesCount=( 0 0 0 0 0 0 0 0 )
Deno=( 1000 500 100 50 20 10 5 2 1 )
echo "Enter amount"
read amount
count=0
for (( i=0;i<8;i++ ))
do
	count=`expr $amount / ${Deno[i]}`
	amount=`expr $amount % ${Deno[i]}`
NotesCount[i]=$count
done
for (( index=0;index<8;index++ ))
do 
echo "${Deno[$index]}    is   ${NotesCount[$index]}"
done
