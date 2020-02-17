#!/bin/bash
source Utility.sh
echo "enter the timer to start"
read 
Begin=$(date '+%s')
echo "enter the  timer to stop"
read 
Now=$(date '+%s')
echo "time elapsion"
timeelap=$(( $Now - $Begin ))
echo $timeelap
#call to function
TimerFormat $timeelap



