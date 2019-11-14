#!/bin/bash

echo "---------------- Test 00 --------------"
echo "Input => "
dotnet run 

echo "---------------- Test 01 --------------"
echo "Input => 1 1 1 1 E L"
dotnet run 1 1 1 1 E L

echo "---------------- Test 02 --------------"
echo "Input => 10 8 5 5 E ML"
dotnet run 10 8 5 5 E ML

echo "---------------- Test 03 --------------"
echo "Input => 8 10 1 2 E MMLMRMMRRMML"
dotnet run 8 10 1 2 E MMLMRMMRRMML

echo "---------------- Test 04 --------------"
echo "Input => 18 10 1 22 E RRRRRRRRRRRL" 
dotnet run 18 10 1 22 E RRRRRRRRRRRL

echo "---------------- Test 05 --------------"
echo "Input => 18 10 1 2 E MMLMRMMRRMML"
dotnet run 18 10 1 2 E MMLMRMMRRMML

echo "---------------- Test 06 --------------"
echo "Input => 10 8 5 5 E MMMMMM"
dotnet run 10 8 5 5 E MMMMMM

echo "---------------- Test 07 --------------"
echo "Input => 10 8 -5 5 E MMMMMM"
dotnet run 10 8 -5 5 E MMMMMM

echo "---------------- Test 08 --------------"
echo "Input => 10 8 23 34 E MMMMMM 12 L"
dotnet run 10 8 23 34 E MMMMMM 12 L

echo "---------------- Test 09 --------------"
echo "Input => 10 8  E MMMMMM"
dotnet run 10 8  E MMMMMM
