---
title: "Sample: Convert an opportunity to a quote (early bound) (Dynamics 365 Sales)"
description: The sample demonstrates how to convert an opportunity that contains products from the product catalog and a write-in product to a quote. 
ms.date: 03/01/2023
ms.reviewer: lavanyakr
ms.topic: sample
applies_to: 
  - Dynamics 365 Sales
author: udaykirang
ms.author: udag
search.audienceType: 
  - developer
---
# Sample: Convert an opportunity to a quote (early bound)

This sample code is for Dynamics 365 Sales. [Download the business management samples](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/BusinessManagement).

## Prerequisites
[!INCLUDE[sdk-prerequisite](../../includes/sdk-prerequisite.md)]
   
## Requirements  
[!INCLUDE [sdk-seeconnectionhelper](../../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to convert an opportunity that contains products from the product catalog and a write-in product to a quote. It also illustrates how to overwrite a price of a product from the product catalog.  
  
## Example  
 [!code-csharp[BusinessManagement#ConvertOpportunityToQuote](../../snippets/csharp/CRMV8/businessmanagement/cs/convertopportunitytoquote.cs#convertopportunitytoquote)]  
  
### See also  
    
 [Opportunity Tables](opportunity-entities.md)   
 <xref:Microsoft.Crm.Sdk.Messages.GenerateQuoteFromOpportunityRequest>


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
