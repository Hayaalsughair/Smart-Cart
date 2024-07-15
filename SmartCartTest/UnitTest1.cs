using Smart_Cart;

namespace SmartCartTest
{
    public class UnitTest1
    {
        [Fact]
        public void AddToCart_RmoveFromCartTest()
        {
            // Arrange
            var shoppingCart = new ShoppingCart();
            var product = new Product(); 

            // Act
            var result = shoppingCart.AddCart(product);
            var deleteResult = shoppingCart.RemoveCart(1);


            // Assert
            Assert.True(result);
            Assert.True(deleteResult);

        }

        [Fact]
        public void TotalCost_ShouldCalculateCorrectTotal()
        {
            // Arrange
            var shoppingCart = new ShoppingCart();

            // Act
            var totalCost = shoppingCart.TotalCost();

            // Assert
            Assert.Equal(0, totalCost); 
        }
    }
}
