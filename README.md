# Smart Cart

Smart Cart is a console-based shopping cart application developed in C#. Users can shop from various categories, view random products, add items to their cart, remove items, and calculate the total cost of their cart.

## Features 

- **Shop by Category:** 
  - Women Fashion
  - Men Fashion
  - Kids Fashion
  - Home
- **Random Products**
- **Add Items to Cart**
- **View Cart**
- **Delete Items from Cart**
- **Calculate Total Cost**
- **Quit Application**

## How to Use :sun_with_face:

1. **Start Shopping:**
   - Run the application. You'll be presented with several options to shop from different categories or view random products.

2. **Shop by Category:**
   - Press `[W]` to shop at Women Fashion.
   - Press `[M]` to shop at Men Fashion.
   - Press `[K]` to shop at Kids Fashion.
   - Press `[H]` to shop at Home.
   - Each option will display a list of products. Select a product to add to your cart by entering its number.

3. **View Random Products:**
   - Press `[R]` to view a list of random products. Select a product to add to your cart by entering its number.

4. **View Cart:**
   - Press `[V]` to view all items currently in your cart.

5. **Remove Items from Cart:**
   - Press `[D]` to view items in your cart and select an item to remove by entering its number.

6. **Calculate Total Cost:**
   - Press `[C]` to calculate and view the total cost of all items in your cart.

7. **Quit Application:**
   - Press `[Q]` to quit the application.

## Example

```plaintext
Press [W] To Shop at Women Fashion
Press [M] To Shop at Men Fashion
Press [K] To Shop at Kids Fashion
Press [H] To Shop at Home
Press [R] Random Products
Press [D] To Delete Items from Cart
Press [V] To View Cart
Press [C] To Calculate Total Cost
Press [Q] Quit
Start Shopping: W
Women's Fashion Products:
[1] Product1 - $45.23
[2] Product2 - $32.45
[3] Product3 - $27.89
Select a product to add to your cart: 1
===================================
Product1 added to your cart
===================================
```

## Classes and Methods

### `ProductGenerator`

- **GenerateProduct:** Generates a random product with a name, price, and category.
- **DisplayRandomProducts:** Displays a list of random products and allows the user to add a selected product to the cart.
- **GenerateMultipleProducts:** Generates a specified number of random products.

### `ShoppingCart`

- **AddCart:** Adds a product to the cart.
- **ViewCart:** Displays all items in the cart.
- **RemoveCart:** Removes a selected product from the cart.
- **TotalCost:** Calculates and displays the total cost of all items in the cart.
- **Discount:** Applies a discount to the total cost if it meets the specified criteria.
### `Program`

- Main class that handles user input and manages the shopping process.

## Requirements

- .NET Core 7.0


## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
