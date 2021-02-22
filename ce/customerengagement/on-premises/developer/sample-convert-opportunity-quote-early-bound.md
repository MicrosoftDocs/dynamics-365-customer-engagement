---
title: "Sample: Convert an opportunity to a quote (early bound) (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The sample demonstrates how to convert an opportunity that contains products from the product catalog and a write-in product to a quote."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - converting opportunities to quotes, Sample
  - sample for converting opportunities to quotes
  - sample for overwriting catalog prices when writing quotes
  - overwriting catalog prices when writing quotes, Sample
ms.assetid: ba6294de-18cc-4689-8a3c-f6317305ff88
caps.latest.revision: 15
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Sample: Convert an opportunity to a quote (early bound)

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. [Download the business management samples](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/BusinessManagement).

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
   
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to convert an opportunity that contains products from the product catalog and a write-in product to a quote. It also illustrates how to overwrite a price of a product from the product catalog.  
  
## Example  
 [!code-csharp[BusinessManagement#ConvertOpportunityToQuote](../snippets/csharp/CRMV8/businessmanagement/cs/convertopportunitytoquote.cs#convertopportunitytoquote)]  
  
### See also  
    
 [Opportunity Entities](opportunity-entities.md)   
 <xref:Microsoft.Crm.Sdk.Messages.GenerateQuoteFromOpportunityRequest>


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]