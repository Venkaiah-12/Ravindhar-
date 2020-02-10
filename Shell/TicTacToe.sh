#!/bin/bash
source Utility.sh
echo "Welcome to tictactoe game"
declare -a array
IntializeBoard $array
PrintBoard $array
IsBoardFull $array
