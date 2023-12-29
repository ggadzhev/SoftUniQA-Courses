import math

figure = str(input("Please enter a type of figure:"))

if figure == "square":
    side_a = float(input())
    area = side_a * side_a
    print(f"{area:.3f}")
elif figure == "rectangle":
    side_a = float(input())
    side_b = float(input())
    area = side_a * side_b
    print(f"{area:.3f}")
elif figure == "circle":
    radius = float(input())
    area = math.pi * math.pow(radius, 2)
    print(f"{area:.3f}")
elif figure == "triangle":
    side_a = float(input())
    height = float(input())
    area = side_a * height / 2
    print(f"{area:.3f}")

