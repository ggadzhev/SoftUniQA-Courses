flower_type = input()
flower_count = int(input())
budget = int(input())

flower_price = 0

if flower_type == "Roses":
    flower_price = 5
    if flower_count > 80:
        flower_price *= 0.9
elif flower_type == "Dahlias":
    flower_price = 3.8
    if flower_count > 90:
        flower_price *= 0.85
elif flower_type == "Tulips":
    flower_price = 2.8
    if flower_count > 80:
        flower_price *= 0.85
elif flower_type == "Narcissus":
    flower_price = 3
    if flower_count < 120:
        flower_price *= 1.15
elif flower_type == "Gladiolus":
    flower_price = 2.5
    if flower_count < 80:
        flower_price *= 1.2

total_price = flower_price * flower_count

if budget >= total_price:
    left_money = budget - total_price
    print(f"Hey, you have a great garden with {flower_count} {flower_type} and {left_money:.2f} leva left.")
else:
    needed_money = total_price - budget
    print(f"Not enough money, you need {needed_money:.2f} leva more.")