movie_budget = float(input())
actors_count = int(input())
clothing_price = float(input())

decor_price = movie_budget * 0.10
total_clothing_price = actors_count * clothing_price


if actors_count > 150:
    total_clothing_price = total_clothing_price - (total_clothing_price * 0.10)

total_movie_budget = decor_price + total_clothing_price

if total_movie_budget > movie_budget:
    money_needed = abs(movie_budget - total_movie_budget)
    print('Not enough money!')
    print(f'Wingard needs {money_needed:.2f} leva more.')
else:
    remaining_money = movie_budget - total_movie_budget
    print('Action!')
    print(f'Wingard starts filming with {remaining_money:.2f} leva left.')