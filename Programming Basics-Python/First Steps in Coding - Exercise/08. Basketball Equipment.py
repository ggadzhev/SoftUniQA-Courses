year_sum_basketball_training = int(input())

price_sneakers = year_sum_basketball_training - (year_sum_basketball_training * 0.40)
price_basketball_uniform = price_sneakers - (price_sneakers * 0.20)
price_basketball_ball = price_basketball_uniform / 4
price_accessories = price_basketball_ball / 5
total_price_equipment = year_sum_basketball_training \
                        + price_sneakers \
                        + price_basketball_ball \
                        + price_accessories \
                        + price_basketball_uniform

print(total_price_equipment)