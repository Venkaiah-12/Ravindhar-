#!/bin/bash 
#call to function
SumOfZero() {
a=$1
size=$2
echo ${a[@]}
#if sum is zero then only three values output
if [ $size -eq 3 ]
then
 (( sum=${a[0]}+${a[1]}+${a[2]} ))
  if [ $sum -eq 0 ]
 then 
echo ${a[@]}
fi
else
#if values are more than 3 it will come here
for (( i=0; i<$size; i++ ))
do
  (( i=$i % $size ))
  (( j=($i+1) % $size ))
  (( k=($i+2) % $size ))
  (( sum=${a[i]}+${a[j]}+${a[k]} ))
   if [ $sum -eq 0 ]
    then 
echo  "${a[i]} ${a[j]} ${a[k]} are sum of zeroes"
fi
done
fi
}
#call to function
checkwin(){
goals=$1
declare -i trails=0
while [ $trails -le $goals ] 
do
#Generating random values
r=$(($RANDOM%2))
if [ $r -eq 1 ]
then
wins=$(( $wins+1 ))
trails=$(( $trails+1 ))
else
loss=$(( $loss+1 ))
trails=$(( $trails+1 ))
fi
done
winpercent=$(( $wins*$trails/100 ))
echo $winpercent
}
#call to function
TimerFormat()
{
timeelap=$1
minutes=0
hours=0
seconds=0
if (( $timeelap >= 3600 ))
then
(( hours=$timeelap / 3600 ))
(( timeelap=$timeelap % 3600 ))
fi
if (( $timeelap >= 60 ))
then
(( minutes=$timeelap / 60 ))
(( timeelap=$timeelap % 60 ))
fi
seconds=$timeelap
echo -en "/r Timer :${hours}:${minutes}:${seconds}"
}
#call to function
Random(){
mod=$1
for s in `seq 5`
do
a=1 
done
return `expr $RANDOM % $mod`
}
#Call to FDunction
Coupon()
{
m=$1
Numbers=$2
declare -a Array
String="123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ"
CouponReady=""
for (( j=0; j < $Numbers; j++ ))
do
for (( i = 0; i < $m; i++ ))
do
#call to function random will return the value
Random 34
ret=$?
char=${String:$ret:1}
CouponReady=$CouponReady$char
done 
Array[j]=$CouponReady
echo $CouponReady
done
echo ${Array[@]}
}
#Call to function
Dayofweek()
{
year=$1
month=$2
day=$3
y=`expr $year-$(((( 14-$month ))/12))`
x=`expr $y+$y/4-$y/100+$y/400`
m=`expr $month+12*$(( 14-$month/12 ))-2`
d=`expr $(((( $day+$x+31*$m/12 ))%7 ))`
#Generating numeric values to find  day of week from switch case
case  "$d" in
2 )
echo "monday"
;;
3 )
echo "tuesday"
;;
4 )
echo "wednesday"
;;
5 )
echo "thursday"
;;
6 )
echo "friday"
;;
7 )
echo "satureday"
;;
1 )
echo "sunday"
;;
* )
echo "Invalid date try again"
;;
esac
}
#call to function
Conversions()
{
option=$1
case "$option" in
1 )
echo "enter the  farhenheit"
read farhenheit
Farhenheit_Celsius=`expr  $(((( $farhenheit-32 ))*5/9 ))`
echo $Farhenheit_Celsius
;;
2 )
echo "enter the  celsius"
read Celsius
Celsius_Farhenheit=`expr $(((( $Celsius*9/5 ))+32 ))`
echo $Celsius_Farhenheit
;;
* )
echo "invalid option"
;;
esac
}
# call to function 
Monthlypayment()
{
Principle=$1
Year=$2
RateofInterest=$3
n=$(( 12*$Year ))
r=$(( $RateofInterest/12*100 ))
Payment=$(( $Principle*$r/(1-(1+$r)^(-$n)) ))
echo $Payment
}
#call to function
NewtonMethod()
{
c=$1
t=$c
#Here using newtons method 
epsilon=$(( 1.0 * e-15 ))
while [ $(( abs($t-$c/$t) )) -gt $(( $epsilon*$t )) ]
do
t=$((($c/$t)+$t/2.0))
done
echo $t
}



