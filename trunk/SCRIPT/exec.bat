@echo off
osql -S %1 -U %2 -P %3 -i %4
exit