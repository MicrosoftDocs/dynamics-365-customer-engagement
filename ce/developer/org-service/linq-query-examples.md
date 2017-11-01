---
title: "LINQ query examples (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "This topic contains many samples of LINQ queries. These samples demonstrate use of Simple Where clause, Join and simple where clause, Distinct operator, simple inner join, Self join and Double and multiple joins"
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
helpviewer_keywords: 
  - "LINQ query examples and samples, 34 examples of using LINQ in queries"
  - "LINQ queries, 34 examples of using LINQ in queries"
ms.assetid: 082042aa-88b5-46e1-a38d-f0a8e59db0a7
caps.latest.revision: 25
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# LINQ query examples

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

This topic contains many samples of LINQ queries. For the full sample, see [Sample: Complex LINQ Queries](sample-complex-linq-queries.md).  
  
<a name="SimpleWhereClause"></a>   
## Simple Where clause  
 The following sample shows how to retrieve a list of accounts where the Name contains “Contoso”.  
  
 [!code-csharp[query#linqexamples1](../../snippets/csharp/CRMV8/query/cs/linqexamples1.cs#linqexamples1)]  
  
 The following sample shows how to retrieve a list of accounts where the Name contains “Contoso” and Address1_City is “Redmond”.  
  
 [!code-csharp[query#linqexamples2](../../snippets/csharp/CRMV8/query/cs/linqexamples2.cs#linqexamples2)]  
  
<a name="JoinandSimpleWhereClause"></a>   
## Join and simple Where clause  
 The following sample shows how to retrieve the account Name and the contact LastName where the account Name contains “Contoso” and the contact LastName contains “Smith” and the contact is the Primary Contact for the account.  
  
 [!code-csharp[query#linqexamples3](../../snippets/csharp/CRMV8/query/cs/linqexamples3.cs#linqexamples3)]  
  
<a name="UsingtheDistinctOperator"></a>   
## Use the Distinct Operator  
 The following sample shows how to retrieve a distinct list of contact last names. Although there may be duplicates, each name will be listed only once.  
  
 [!code-csharp[query#linqexamples4](../../snippets/csharp/CRMV8/query/cs/linqexamples4.cs#linqexamples4)]  
  
<a name="SimpleInnerJoin"></a>   
## Simple inner join  
 The following sample shows how to retrieve information about an account and the contact listed as the primary contact for the account.  
  
 [!code-csharp[query#linqexamples5](../../snippets/csharp/CRMV8/query/cs/linqexamples5.cs#linqexamples5)]  
  
<a name="SelfJoin"></a>   
## Self-join  
 The following sample shows how to retrieve information about accounts where an account is the parent account for an account.  
  
 [!code-csharp[query#linqexamples9](../../snippets/csharp/CRMV8/query/cs/linqexamples9.cs#linqexamples9)]  
  
<a name="DoubleJoin"></a>   
## Double and multiple joins  
 The following sample shows how to retrieve information from account, contact and lead where the contact is the primary contact for the account and the lead was the originating lead for the account.  
  
 [!code-csharp[query#linqexamples8](../../snippets/csharp/CRMV8/query/cs/linqexamples8.cs#linqexamples8)]  
  
 The following sample shows how to retrieve account and contact information where an account is the parent account for an account and the contact is the primary contact for the account.  
  
 [!code-csharp[query#linqexamples10](../../snippets/csharp/CRMV8/query/cs/linqexamples10.cs#linqexamples10)]  
  
<a name="JoinUsingEntityFields"></a>   
## Join using entity fields  
 The following sample shows how to retrieve information about accounts from a list  
  
 [!code-csharp[query#linqexamples11](../../snippets/csharp/CRMV8/query/cs/linqexamples11.cs#linqexamples11)]  
  
<a name="LeftJoin"></a>   
## Late-binding left join  
 The following sample shows a left join. A left join is designed to return parents with and without children from two sources. There is a correlation between parent and child, but no child may actually exist.  
  
 [!code-csharp[query#linqexamples12](../../snippets/csharp/CRMV8/query/cs/linqexamples12.cs#linqexamples12)] 
  
<a name="UsingtheEqualsOperator"></a>   
## Use the Equals operator  
 The following sample shows how to retrieve a list of contacts where the FirstName is “Colin”.  
  
 [!code-csharp[query#linqexamples14](../../snippets/csharp/CRMV8/query/cs/linqexamples14.cs#linqexamples14)] 
  
 The following sample shows how to retrieve a list of contacts where the FamilyStatusCode is 3. This corresponds to the **Marital Status** option of **Divorced**.  
  
 [!code-csharp[query#linqexamples15](../../snippets/csharp/CRMV8/query/cs/linqexamples15.cs#linqexamples15)] 
  
<a name="UsingtheNotEqualsOperator"></a>   
## Use the Not Equals operator  
 The following sample shows how to retrieve a list of contacts where the Address1_City is not “Redmond”.  
  
 [!code-csharp[query#linqexamples16](../../snippets/csharp/CRMV8/query/cs/linqexamples16.cs#linqexamples16)]  
  
 The following sample shows how to retrieve a list of contacts where the FirstName is not “Colin”.  
  
 [!code-csharp[query#linqexamples17](../../snippets/csharp/CRMV8/query/cs/linqexamples17.cs#linqexamples17)]  
  
<a name="BKMK_UsingMethodBasedLINQQueryWithWhereClause"></a>   
## Use a method-based LINQ query with a Where clause  
 The following sample shows how to retrieve a list of contacts where the LastName is “Smith” or contains “Smi”.  
  
 [!code-csharp[query#linqexamples18](../../snippets/csharp/CRMV8/query/cs/linqexamples18.cs#linqexamples18)] 
  
<a name="BKMK_UsingGreaterThanOperator"></a>   
## Use the Greater Than operator  
 The following sample shows how to retrieve a list of contacts with an Anniversary date later than February 5, 2010.  
  
 [!code-csharp[query#linqexamples20](../../snippets/csharp/CRMV8/query/cs/linqexamples20.cs#linqexamples20)] 
  
 The following sample shows how to retrieve contacts with a CreditLimit greater than $20,000.  
  
 [!code-csharp[query#linqexamples21](../../snippets/csharp/CRMV8/query/cs/linqexamples21.cs#linqexamples21)] 
  
<a name="BKMK_UsingGreaterThanOrEqualsAndLessThanOrEqualsOperators"></a>   
## Use the Greater Than or Equals and Less Than or Equals operators  
 The following sample shows how to retrieve contacts with a CreditLimit greater than $200 and less than $400.  
  
 [!code-csharp[query#linqexamples22](../../snippets/csharp/CRMV8/query/cs/linqexamples22.cs#linqexamples22)] 
  
<a name="BKMK_UsingContainsOperator"></a>   
## Use the Contains operator  
 The following sample shows how to retrieve contacts where the Description contains “Alpine”.  
  
 [!code-csharp[query#linqexamples23](../../snippets/csharp/CRMV8/query/cs/linqexamples23.cs#linqexamples23)] 
  
<a name="BKMK_UsingDoesNotContainOperator"></a>   
## Use the Does Not Contain operator  
 The following sample shows how to retrieve contacts where the Description does not contain “Coho”.  
  
 [!code-csharp[query#linqexamples24](../../snippets/csharp/CRMV8/query/cs/linqexamples24.cs#linqexamples24)]  
  
<a name="BKMK_UsingEndsWithOperator"></a>   
## Use the StartsWith and EndsWith operators  
 The following sample shows how to retrieve contacts where FirstName starts with “Bri”.  
  
 [!code-csharp[query#linqexamples26](../../snippets/csharp/CRMV8/query/cs/linqexamples26.cs#linqexamples26)]  

  
 The following sample shows how to retrieve contacts where LastName ends with “cox”.  
  
 [!code-csharp[query#linqexamples27](../../snippets/csharp/CRMV8/query/cs/linqexamples27.cs#linqexamples27)]  

  
<a name="BKMK_UsingAndOrOperators"></a>   
## Use the And and Or operators  
 The following sample shows how to retrieve contacts where Address1_City is “Redmond” or “Bellevue” and a CreditLimit that is greater than $200.  
  
 [!code-csharp[query#linqexamples28](../../snippets/csharp/CRMV8/query/cs/linqexamples28.cs#linqexamples28)]  

  
<a name="BKMKUsingOrderByOperator"></a>   
## Use the OrderBy operator  
 The following sample shows how to retrieve contacts ordered by CreditLimit in descending order.  
  
 [!code-csharp[query#linqexamples29](../../snippets/csharp/CRMV8/query/cs/linqexamples29.cs#linqexamples29)]  

  
 The following sample shows how to retrieve contacts ordered by LastName in descending order and FirstName in ascending order.  
  
 [!code-csharp[query#linqexamples30](../../snippets/csharp/CRMV8/query/cs/linqexamples30.cs#linqexamples30)]  

  
<a name="BKMK_UsingFirstAndSingleOperators"></a>   
## Use the First and Single operators  
 The following sample shows how to retrieve only the first contact record returned and retrieve only one contact record that matches the criterion.  
  
 [!code-csharp[query#linqexamples31](../../snippets/csharp/CRMV8/query/cs/linqexamples31.cs#linqexamples31)]  

  
<a name="BKMK_RetrievingFormattedValues"></a>   
## Retrieving formatted values  
 The following sample shows how to retrieve the label for an optionset option, in this case the value for the current record status.  
  
 [!code-csharp[query#linqexamples32](../../snippets/csharp/CRMV8/query/cs/linqexamples32.cs#linqexamples32)]  

  
<a name="BKMK_UsingTheSkipAndTakeOperatorsWithoutPaging"></a>   
## Use the Skip and Take operators without paging  
 The following sample shows how to retrieve just two records after skipping two records where the LastName is not “Parker” using the [Skip](https://msdn.microsoft.com/library/bb358985.aspx) and [Take](https://msdn.microsoft.com/library/bb503062.aspx)operators.  
  
 [!code-csharp[query#linqexamples33](../../snippets/csharp/CRMV8/query/cs/linqexamples33.cs#linqexamples33)]  

  
<a name="BKMK_UsingTheFirstOrDefaultAndSingleOrDefaultOperators"></a>   
## Use the FirstOrDefault and SingleOrDefault operators  
 The [FirstOrDefault](https://msdn.microsoft.com/library/system.linq.enumerable.firstordefault.aspx) operator returns the first element of a sequence, or a default value if no element is found. The [SingleOrDefault](https://msdn.microsoft.com/library/system.linq.enumerable.singleordefault.aspx) operator returns a single, specific element of a sequence, or a default value if that element is not found. The following sample shows how to use these operators.  
  
 [!code-csharp[query#linqexamples35](../../snippets/csharp/CRMV8/query/cs/linqexamples35.cs#linqexamples35)]  

  
<a name="BKMK_UsingASelfJoinWithConditionOnLinkedEntity"></a>   
## Use a self-join with a condition on the linked entity  
 The following sample shows how to retrieve the names of two accounts where one account is the parent account of the other.  
  
 [!code-csharp[query#linqexamples36](../../snippets/csharp/CRMV8/query/cs/linqexamples36.cs#linqexamples36)]  

  
<a name="BKMK_UsingTransformationInTheWhereClause"></a>   
## Use a transformation in the Where Clause  
 The following sample shows how to retrieve a specific contact where the anniversary date is later than January 1, 2010.  
  
 [!code-csharp[query#linqexamples37](../../snippets/csharp/CRMV8/query/cs/linqexamples37.cs#linqexamples37)]  

  
<a name="BKMK_UsingAPagingSort"></a>   
## Use a paging sort  
 The following sample shows a multi-column sort with an extra condition.  
  
 [!code-csharp[query#linqexamples41](../../snippets/csharp/CRMV8/query/cs/linqexamples41.cs#linqexamples41)]  

  
 The following sample shows a paging sort where the column being sorted is different from the column being retrieved.  
  
 [!code-csharp[query#linqexamples42](../../snippets/csharp/CRMV8/query/cs/linqexamples42.cs#linqexamples42)]  

  
 The following sample shows how to retrieve just the first 10 records.  
  
 [!code-csharp[query#linqexamples43](../../snippets/csharp/CRMV8/query/cs/linqexamples43.cs#linqexamples43)]  

  
<a name="BKMK_RetrievingRelatedEntityColumns"></a>   
## Retrieve related entity columns for 1 to N relationships  
 The following sample shows how to retrieve columns from related account and contact records.  
  
 [!code-csharp[query#linqexamples44](../../snippets/csharp/CRMV8/query/cs/linqexamples44.cs#linqexamples44)]  
  
<a name="BKMK_UsingValueToRetrieveTheValueOfAnAttribute"></a>   
## Use .value to retrieve the value of an attribute  
 The following sample shows usage of Value to access the value of an attribute.  
  
 [!code-csharp[query#linqexamples45](../../snippets/csharp/CRMV8/query/cs/linqexamples45.cs#linqexamples45)]  
  
<a name="BKMK_MultipleProjectionsNewDataTypeCastingToDifferentTypes"></a>   
## Multiple projections, new data type casting to different types  
 The following sample shows multiple projections and how to cast values to a different type.  
  
 [!code-csharp[query#linqexamples46](../../snippets/csharp/CRMV8/query/cs/linqexamples46.cs#linqexamples46)]  
  
<a name="BKMK_UsingTheGetAttributeValueMethod"></a>   
## Use the GetAttributeValue method  
 The following sample shows how to use the [String)](https://docs.microsoft.com/dotnet/api/microsoft.xrm.sdk.entity.getattributevalue``1\(system.string\)) method.  
  
 [!code-csharp[query#linqexamples47](../../snippets/csharp/CRMV8/query/cs/linqexamples47.cs#linqexamples47)]  
  
<a name="mathoperators"></a>   
## Use Math methods  
 The following sample shows how to use various [Math](https://msdn.microsoft.com/library/system.math.aspx) methods.  
  
 [!code-csharp[query#linqexamples48](../../snippets/csharp/CRMV8/query/cs/linqexamples48.cs#linqexamples48)]  
  
<a name="BKMK_UsingMultipleSelectAndWhereClauses"></a>   
## Use Multiple Select and Where clauses  
 The following sample shows multiple select and where clauses using a method-based query syntax.  
  
 [!code-csharp[query#linqexamples49](../../snippets/csharp/CRMV8/query/cs/linqexamples49.cs#linqexamples49)]  
  
<a name="BKMK_UsingSelectMany"></a>   
## Use SelectMany  
 The following sample shows how to use the [SelectMany Method](https://msdn.microsoft.com/library/system.linq.enumerable.selectmany.aspx).  
  
 [!code-csharp[query#linqexamples50](../../snippets/csharp/CRMV8/query/cs/linqexamples50.cs#linqexamples50)]  
  
<a name="BKMK_UsingStringOperations"></a>   
## Use string operations  
 The following sample shows how to use various String methods.  
  
 [!code-csharp[query#linqexamples51](../../snippets/csharp/CRMV8/query/cs/linqexamples51.cs#linqexamples51)] 
  
<a name="BKMK_UsingTwoWhereClauses"></a>   
## Use two Where clauses  
 The following sample shows how to use two Where clauses.  
  
 [!code-csharp[query#linqexamples52](../../snippets/csharp/CRMV8/query/cs/linqexamples52.cs#linqexamples52)] 
  
<a name="BKMK_UseLoadProperty"></a>   
## Use LoadProperty to retrieve related records  
 The following sample shows how to [Relationship)](https://docs.microsoft.com/dotnet/api/microsoft.xrm.sdk.client.organizationservicecontext.loadproperty\(microsoft.xrm.sdk.entity,microsoft.xrm.sdk.relationship\)) to access related records.  
  
 [!code-csharp[query#UseLinqQuery5](../../snippets/csharp/CRMV8/query/cs/uselinqquery5.cs#uselinqquery5)]  
  
### See also  
 [Build Queries with LINQ (.NET Language-Integrated Query)](build-queries-with-linq-net-language-integrated-query.md)   
 [Sample: Create a LINQ query](sample-create-linq-query.md)
