// <snippetcloneproducts1>



  CloneProductRequest cloneReq = new CloneProductRequest
  {
      Source = new EntityReference(Product.EntityLogicalName, _productId)
  };
  
  CloneProductResponse cloned = (CloneProductResponse)_serviceProxy.Execute(cloneReq);                                     
  _productCloneId = cloned.ClonedProduct.Id;
 
  // Retrieve the cloned product record
  Product retrievedProduct = (Product)_serviceProxy.Retrieve(Product.EntityLogicalName, _productCloneId, new ColumnSet(true));
  Console.WriteLine("\nCreated clone product: {0}", retrievedProduct.Name);

// </snippetcloneproducts1>