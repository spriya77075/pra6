@model prac_6.Models.Product

@{
    ViewBag.Title = "Details";
}

@{
    Layout = null;
}

<h2>Product detail</h2>

@if (Model != null)
{
    <p>Product Id:@Model.ProductId</p>
    <p>Product Name:@Model.ProductName</p>
    <p>Destription:@Model.Description</p>
    <p>Price:@Model.Price</p>
    <p>Category:@Model.Category</p>
}
else
{
    <p>Product not found</p>
}

<br />

@Html.ActionLink(
    "Back to product catalogue",
    "Index",
    "Product"
);