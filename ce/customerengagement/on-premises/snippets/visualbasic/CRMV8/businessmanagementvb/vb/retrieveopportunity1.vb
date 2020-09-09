' <snippetretrieveopportunity1>


 ' Retrieve Opportunity record.                
 Dim checkOpportunity As Opportunity = CType(_serviceProxy.Retrieve(Opportunity.EntityLogicalName, _
                                             _opportunityId, New ColumnSet("name")), Opportunity)

 Console.WriteLine("Retrieved {0}", checkOpportunity.Name)

 ' Retrieve the related opportunity products
 Dim opportunityProductsQuery As QueryExpression = New QueryExpression With _
                                     {.EntityName = OpportunityProduct.EntityLogicalName, _
                                      .ColumnSet = New ColumnSet("opportunityproductid", "volumediscountamount")}
 opportunityProductsQuery.Criteria = New FilterExpression()
 opportunityProductsQuery.Criteria.AddCondition("opportunityid", ConditionOperator.Equal, _opportunityId)

 Dim opportunityProducts As DataCollection(Of Entity) = _serviceProxy.RetrieveMultiple(opportunityProductsQuery).Entities

 For Each entity As Entity In opportunityProducts
     Dim opportunityProduct As OpportunityProduct = CType(entity, OpportunityProduct)
     Console.WriteLine("Retrieved Opportunity Product {0}", opportunityProduct.OpportunityProductId.Value)
 Next entity

' </snippetretrieveopportunity1>