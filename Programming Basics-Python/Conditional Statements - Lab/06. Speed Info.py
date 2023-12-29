current_speed = float(input("Current speed:"))

if current_speed <= 10:
    print('slow')
elif 10 < current_speed <= 50:
    print('average')
elif 50 < current_speed <= 150:
    print('fast')
elif 150 < current_speed <= 1000:
    print('ultra fast')
else:
    print('extremely fast')
