---
title: "Transaction Currency (currency) entity (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Learn about transaction curreny, which is a multicurrency feature enabling users to perform financial transactions in multiple currencies. Multiple records in different transaction currencies can be aggregated, compared, or analyzed with regard to a single currency using the base currency."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - transaction currency (currency) entity, associating currency to specific records
  - transaction currency properties, actions you can perform
  - transaction currency, definition
  - transaction currency (currency) entity, transaction currency
  - transaction currency (currency) entity, multicurrency system
  - transaction currency (currency) entity, supported entities
  - multicurrency system, definition
  - exchange rate, definition
  - transaction currency (currency) entity, decimal precision
  - multicurrency system, transaction currency (currency) entity
  - transaction currency (currency) entity, introduction
  - associating currency to specific records, transaction currency (currency) entity
  - base currency, definition
ms.assetid: 9439baba-166c-4779-be3c-2c52833e01b0
caps.latest.revision: 16
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Transaction Currency (currency) entity

[!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] is a multicurrency system, in which each record can be associated with its own currency. This currency is called the *transaction* currency. The multicurrency features enable users to perform financial transactions like opportunities, quotes, orders, and invoices in multiple currencies. This feature also provides a currency choice to the end user when a financial transaction occurs.  
  
 Multiple records in different transaction currencies can be aggregated, compared, or analyzed with regard to a single currency, by using an exchange rate. This is known as the *base currency*. You first define a base currency for the organization and then define exchange rates to associate the base currency with transaction currencies. The base currency is the currency in which other currencies are quoted. The exchange rate is the value of a transaction currency equal to one base currency.  
  
 By using the transaction currency properties you can do the following:  
  
- Select the currency in which you want to define and transact opportunities, quotes, orders, and invoices.  
  
- Define currency exchange rates relative to the base currency.  
  
- Define transaction currencies and define an exchange rate to associate the base currency with the transaction currency.  
  
- Capture the value of the transaction in the base currency and the transaction currency in all financial transactions.  
  
- Define product pricelists for each currency.  
  
  To use multiple currencies, the base currency must be defined for an organization during server installation and organization setup. After the base currency is set for an organization, it cannot be changed. This value is stored in the `Organization.BaseCurrencyID` attribute.  
  
  Transaction currencies are defined as a part of the system settings. An unlimited number of transaction currencies can be defined. Transaction currencies are related to the base currency with the definition of a currency exchange rate.  
  
  After the definition of base and transaction currencies, pricelists must be defined. An organization can have multiple pricelists, which are also typically defined for a target geographical market in the local currency.  
  
  All entities that are involved in financial transactions support transaction currency. The currency is typically inherited from the account, opportunity, and so on, but can be changed as needed.  
  
  You can specify the decimal precision for the transaction currency by using the `TransactionCurrency.CurrencyPrecision` attribute. To specify the source of the precision for the attributes of type Money, use the <xref:Microsoft.Xrm.Sdk.Metadata.MoneyAttributeMetadata>.<xref:Microsoft.Xrm.Sdk.Metadata.MoneyAttributeMetadata.PrecisionSource> attribute.  
  
  All money properties in a record share the same transaction currency, for example, see the `Account.CreditLimit` attribute. For each money attribute in an entity, [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] automatically creates a corresponding read-only, system calculated, money attribute that is called the "base". This is a money attribute that stores the value of the corresponding attribute in a base currency equivalent, for example, see the `Account.CreditLimit_Base` attribute.  
  
  The following formula is used to calculate the base value:  
  
```csharp  
creditlimit_base = creditlimit / exchangerate  
```  
  
 The following are the entities for which the transaction currency can be defined.  
  
-   Account  
  
-   AnnualFiscalCalendar  
  
-   Campaign  
  
-   CampaignActivity  
  
-   Competitor  
  
-   Contact  
  
-   Contract  
  
-   ContractDetail  
  
-   Discount  
  
-   DiscountType  
  
-   FixedMonthlyFiscalCalendar  
  
-   Invoice  
  
-   InvoiceDetail  
  
-   Lead  
  
-   List  
  
-   MonthlyFiscalCalendar  
  
-   Opportunity  
  
-   OpportunityClose  
  
-   OpportunityProduct  
  
-   PriceLevel  
  
-   Product  
  
-   ProductPriceLevel  
  
-   QuarterlyFiscalCalendar  
  
-   Quote  
  
-   QuoteDetail  
  
-   SalesOrder  
  
-   SalesOrderDetail  
  
-   SemiAnnualFiscalCalendar  
  
-   UserSettings  
  
### See also  
 [TransactionCurrency Entity](entities/transactioncurrency.md)   
 [Sample: Retrieve Currency Exchange Rate](sample-retrieve-currency-exchange-rate.md)   
 [Business Management Entities](business-management-entities.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]