#!/bin/bash
source Utility.sh
echo "enter the principle loan amount"
read Principle
echo " enter the  how many years "
read Year
echo "enter the Rate of Interest"
read RateofInterest
#calling function 
Monthlypayment $Principle $Year $RateofInterest



