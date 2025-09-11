namespace Grocery.Core.Models
{
    public class GroceryListItem : Model
    {
        public int GroceryListId { get; set; } //Change it to a property
        public int ProductId {  get; set; }     //Change it to a property
        public int Amount { get; set; }
        public GroceryListItem(int id, int groceryListId, int productId, int amount) : base(id, "")
        {
            //Assigned values to properties
            ProductId = productId;
            GroceryListId = groceryListId;
            Amount = amount;

        }

        public Product Product { get; set; } = new(0, "None", 0);
    }
}
