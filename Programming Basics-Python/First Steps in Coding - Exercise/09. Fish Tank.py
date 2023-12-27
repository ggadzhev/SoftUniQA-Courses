lenght_sm = int(input())
width_sm = int(input())
height_sm = int(input())
percentage = float(input())

aquarium_size = lenght_sm * width_sm * height_sm
size_in_litters = aquarium_size / 1000
taken_space = percentage / 100
litters_required = size_in_litters * (1 - taken_space)

print(litters_required)