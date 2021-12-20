using OOP1;

Product product1=new Product();
product1.ID = 1;
product1.CategoryId = 2;
product1.ProductName = "Masa";
product1.Unitprice = 500;
product1.UnitsInStock = 3;

Product product2=new Product { ID=2,CategoryId=2,ProductName="Kalem",Unitprice=25,UnitsInStock=14};

//PascalCase   camelCase
ProductManager productManager=new ProductManager();
productManager.Add();
