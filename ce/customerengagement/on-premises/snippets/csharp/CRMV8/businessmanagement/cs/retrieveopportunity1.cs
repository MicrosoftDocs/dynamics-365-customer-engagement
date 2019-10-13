// <snippetretrieveopportunity1>


 // Retrieve Opportunity record.                
 Opportunity checkOpportunity = (Opportunity)_serviceProxy.Retrieve(
     Opportunity.EntityLogicalName,
     _opportunityId,
     new ColumnSet("name"));

 Console.WriteLine("Retrieved {0}", checkOpportunity.Name);

 // Retrieve the related opportunity products
 QueryExpression opportunityProductsQuery = new QueryExpression
 {
     EntityName = OpportunityProduct.EntityLogicalName,
     ColumnSet = new ColumnSet("opportunityproductid", "volumediscountamount"),
     Criteria = new FilterExpression
     {
         Conditions = 
     {
         new ConditionExpression 
         {
             AttributeName = "opportunityid",
             Operator = ConditionOperator.Equal,
             Values = { _opportunityId }
         }
     }
     }
 };

 DataCollection<Entity> opportunityProducts = _serviceProxy.RetrieveMultiple(
     opportunityProductsQuery).Entities;

 foreach (Entity entity in opportunityProducts)
 {
     OpportunityProduct opportunityProduct = (OpportunityProduct)entity;
     Console.WriteLine("Retrieved Opportunity Product {0}",
         opportunityProduct.OpportunityProductId.Value);
 }

// </snippetretrieveopportunity1>