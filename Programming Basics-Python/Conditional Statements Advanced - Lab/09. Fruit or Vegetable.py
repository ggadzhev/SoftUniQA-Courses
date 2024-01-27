product_type = str(input())

if product_type == "banana" or \
        product_type == "apple" or \
        product_type == "kiwi" or \
        product_type == "cherry" or \
        product_type == "lemon" or \
        product_type == "grapes":
    print("fruit")

elif product_type == "tomato" or \
        product_type == "cucumber" or \
        product_type == "pepper" or \
        product_type == "carrot":
    print("vegetable")

else:
    print("unknown")
