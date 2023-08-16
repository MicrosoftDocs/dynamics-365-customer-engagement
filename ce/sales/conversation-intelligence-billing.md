---
title: Upcoming changes to conversation intelligence pricing model
description: 
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: shujoshi
ms.topic: conceptual
ms.collection: get-started
ms.date: 08/16/2023
ms.custom: bap-template 
---

# Upcoming changes to conversation intelligence pricing model

This article describes the new conversation intelligence pricing model which will take effect starting October 1, 2023. Organizations will be able to use the current pricing model until December 1, 2023. After this date, sellers will not be able to record and analyze calls unless the admin configures the new pricing model. The details about the actual configuration will be available on this page on October 1, 2023.  

## License and role requirements

| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System administrator <br>  More information: [Primary sales roles](security-roles-for-sales.md#primary-sales-roles)|

## What's changing

The pricing model for conversation intelligence within Dynamics 365 Sales will be a meter-based, pay as you go model. This means that organizations are only required to pay for their actual monthly consumption of recorded and analyzed hours of conversation intelligence.  

The model uses an Azure subscription and resource for billing, and charges the resource once a month. The charges are based on the number of recorded and analyzed hours in the month.  

Admins can set up a monthly limit of hours. If this limit is reached, sellers will not be able to record and analyze additional calls until the end of the month, or until the admin increases or cancels the limit.  

The hourly rates will be updated in the licensing guide by October 1, 2023.    

## What you'll need to prepare for this change

To prepare better for this change, we recommend that you have the following in place:

- A valid Azure subscription. [Learn more](/azure/cost-management-billing/manage/create-enterprise-subscription). 

- A valid resource group within the subscription. [Learn more](/azure/azure-resource-manager/management/manage-resource-groups-portal#create-resource-groups). 

- A contributor or owner role of the Azure subscription assigned to the Dynamics 365 system administrator. [Learn more](/azure/cost-management-billing/manage/understand-mca-roles#subscription-billing-roles-and-tasks).  