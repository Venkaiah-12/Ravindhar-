#!/bin/bash
declare -a strarray
strarray="ravi"
str=${!strarray[@]}
echo "$str"
