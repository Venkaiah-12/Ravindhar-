#!/bin/bash
CurrentPlayer="X"
IntializeBoard()
{
array=$1
for (( i=0; i<3; i++ ))
do 
for(( j=0; j<3; j++ ))
do
array[$i,$j]='-'
done 
done
for (( index=0; index<3; index++ ))
do 
for(( index1=0; index1<3; index1++ ))
do
echo -ne  "${array[$index,$index1]}\t"
done 
echo 
done
echo "$CurrentPlayer"
}
PrintBoard()
{
array=$1
echo "--------------------"
PrintRowBoard $array
}
PrintRowBoard()
{
for (( row=0; row<3; row++ ))
do
echo -e "|\c"
PrintColBoard $array $row
done
}
PrintColBoard()
{
array=$1
row=$2
for (( col=0; col<3; col++ ))
do
echo  -ne "  ${array[$row,$col]}   |"
done
echo
echo "--------------------"
}
#IsBoardFull()
#{
#array=$1
#declare -r TRUE='-'
#declare -r FALSE=1
#for (( row1=0;row1<3; row1++ ))
#do
#for (( col1=0;col1<3; col1++ ))
#do
#[ "${array[$row1,$col1]}" -eq '-' ] && return $TRUE || $FALSE
#done 
#done
#echo "$IsFull"





