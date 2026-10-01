@model List<prac_6.Models.Product>

@{
    ViewBag.Title = "Index";
}

@{
    Layout = null;
}

<h2>Product Catalogue</h2>
<br />

<h3>Saumya Patel (92400103349-batch-A)</h3>

<table border="1">
    <tr>
        <th>Product Id</th>
        <th>Product Name</th>
        <th>Description</th>
        <th>Price</th>
        <th>Category</th>
    </tr>

    @foreach (var product in Model)
    {
        <tr>
            <td>@product.ProductId</td>
            <td>@product.ProductName</td>
            <td>@product.Description</td>
            <td>@product.Price</td>
            <td>@product.Category</td>

            <td>
                @Html.ActionLink(
                    "view details",
                    "Details",
                    "Product",
                    new { id = product.ProductId },
                    null
                )
            </td>
        </tr>
    }
</table>