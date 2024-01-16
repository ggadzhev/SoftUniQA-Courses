import math

time_first = int(input("Enter first time"))
time_second = int(input("Enter second time"))
time_third = int(input("Enter third time"))

total_time = time_third + time_second + time_first

minutes = total_time // 60
seconds = total_time % 60

minutes = math.floor(minutes)

if seconds < 10:
    print(f'{minutes}:0{seconds}')
else:
    print(f'{minutes}:{seconds}')