pen_packages = int(input())
marker_packages = int(input())
board_cleaner_liters = int(input())
discount_percentage = int(input())

price_pen_packages = pen_packages * 5.80
price_marker_packages = marker_packages * 7.20
price_board_cleaner = board_cleaner_liters * 1.20
price_all_materials = price_board_cleaner + price_pen_packages + price_marker_packages
discounted_price = price_all_materials - (price_all_materials * (discount_percentage / 100))

print(discounted_price)

