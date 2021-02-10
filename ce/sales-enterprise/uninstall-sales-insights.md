---
title: "Understand how to uninstall Sales Insights | MicrosoftDocs"
description: "Uninstall Sales Insights"
ms.date: 11/24/2020
ms.service: crm-online
ms.custom: 
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---

# Uninstall Sales Insights

You can uninstall the Sales Insights Add-in for Dynamics 365 Sales if you don't want to use it in your organization.
  
1.	As an administrator, sign in to your Dynamics 365 organization.
2.	Go to **Advanced settings**, and then select **Settings** > **Customization** > **Solutions**.  
3.	On the **Solutions** page, select each of the following solutions one at a time, and then select **Delete**.  
    -	msdyn_acceleratedsalessettings
    -   msdyn_acceleratedsalessitemap  
    -	msdyn_acceleratedsales  
    -	msdyn_connectiongraph  
    -	msdyn_Conversationlntelligence  
    -	msdyn_PredictiveScoringCommon 
    -   msdyn_sequence  
    -	msdynce_RelationshipAssistantAddOn  
    -	PredictiveForecast  
    -	PredictiveLeadScoring  
    -	PredictiveOpportunityScoring  
    -	RelationshipAnalytics  
    -	SalesInsightsAddOn  
    -	SalesInsightsMDLConfig 

Although you've deleted the solutions, your organization data might still be written to Azure Data Lake Storage. To completely remove data and reclaim the data storage, contact Dynamics 365 support.  

## What happens to data

After you uninstall Sales Insights, Dynamics 365 won't keep any Sales Insights data for your organization in the storage locations where it's hosted.

### See also

[Introduction](../sales/intro-admin-guide-sales-insights.md)
