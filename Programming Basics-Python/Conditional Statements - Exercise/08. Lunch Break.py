import math

series_name = str(input())
episode_length = int(input())
break_length = int(input())

lunch_time = break_length * 1/8
break_time = break_length * 1/4
remaining_time = break_length - lunch_time - break_time

if remaining_time >= episode_length:
    print(f"You have enough time to watch {series_name} and left with "
          f"{math.ceil(remaining_time - episode_length)} minutes free time.")
elif remaining_time < episode_length:
    print(f"You don't have enough time to watch {series_name}, you need "
          f"{math.ceil(episode_length - remaining_time)} more minutes.")


