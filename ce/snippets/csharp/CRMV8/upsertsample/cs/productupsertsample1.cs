// <snippetproductupsertsample1>


 public void ProcessUpsert(String Filename)
 {
     Console.WriteLine("Executing upsert operation.....");
     XmlTextReader tr = new XmlTextReader(Filename);
     XmlDocument xdoc = new XmlDocument();
     xdoc.Load(tr);
     XmlNodeList xnlNodes = xdoc.DocumentElement.SelectNodes("/products/product");

     foreach (XmlNode xndNode in xnlNodes)
     {
         String productCode = xndNode.SelectSingleNode("Code").InnerText;
         String productName = xndNode.SelectSingleNode("Name").InnerText;
         String productCategory = xndNode.SelectSingleNode("Category").InnerText;
         String productMake = xndNode.SelectSingleNode("Make").InnerText;

         //use alternate key for product
         Entity productToCreate = new Entity("sample_product", "sample_productcode", productCode);

         productToCreate["sample_name"] = productName;
         productToCreate["sample_category"] = productCategory;
         productToCreate["sample_make"] = productMake;
         UpsertRequest request = new UpsertRequest()
         {
             Target = productToCreate
         };

         try
         {
             // Execute UpsertRequest and obtain UpsertResponse. 
             UpsertResponse response = (UpsertResponse)_serviceProxy.Execute(request);
             if (response.RecordCreated)
                 Console.WriteLine("New record {0} is created!", productName);
             else
                 Console.WriteLine("Existing record {0} is updated!", productName);
         }

         // Catch any service fault exceptions that Microsoft Dynamics CRM throws.
         catch (FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault>)
         {
             throw;
         }

     }
     // Prompts to view the sample_product entity records.
     // If you choose "y", IE will be launched to display the new or updated records.
     if (PromptForView())
     {
         ViewEntityListInBrowser();
     }

 }

// </snippetproductupsertsample1>