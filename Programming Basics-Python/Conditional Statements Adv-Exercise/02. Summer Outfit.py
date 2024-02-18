temperature = int(input())
time_of_day = input()

Outfit = " "
Shoes = " "

if time_of_day == "Morning":
    if 10 <= temperature <= 18:
        Outfit = "Sweatshirt"
        Shoes = "Sneakers"
    elif 18 < temperature <= 24:
        Outfit = "Shirt"
        Shoes = "Moccasins"
    elif temperature >=25:
        Outfit = "T-Shirt"
        Shoes = "Sandals"
if time_of_day == "Afternoon":
    if 10 <= temperature <= 18:
        Outfit = "Shirt"
        Shoes = "Moccasins"
    elif 18 < temperature <= 24:
        Outfit = "T-Shirt"
        Shoes = "Sandals"
    elif temperature >=25:
        Outfit = "Swim Suit"
        Shoes = "Barefoot"
if time_of_day == "Evening":
    if 10 <= temperature <= 18:
        Outfit = "Shirt"
        Shoes = "Moccasins"
    elif 18 < temperature <= 24:
        Outfit = "Shirt"
        Shoes = "Moccasins"
    elif temperature >=25:
        Outfit = "Shirt"
        Shoes = "Moccasins"

print(f"It's {temperature} degrees, get your {Outfit} and {Shoes}.")