---
title: "Sample: Retrieve currency exchange rate (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The sample demonstrates how to create a new currency, and how to retrieve and display the currency exchange rate relative to the organization’s base currency."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: d071fe46-4d71-4fd1-95b8-069bd4a96f8d
caps.latest.revision: 13
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Retrieve currency exchange rate

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. Download the complete sample here [Business Management samples](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/BusinessManagement).  

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to create a new currency, and how to retrieve and display the currency exchange rate relative to the organization’s base currency.  
  
## Example  
 [!code-csharp[BusinessManagement#TransactionCurrencyExchangeRate](../snippets/csharp/CRMV8/businessmanagement/cs/transactioncurrencyexchangerate.cs#transactioncurrencyexchangerate)]  
  
### See also  
 [Transaction Currency (Currency) Entity](transaction-currency-currency-entity.md)   
 <xref:Microsoft.Crm.Sdk.Messages.RetrieveExchangeRateRequest>
