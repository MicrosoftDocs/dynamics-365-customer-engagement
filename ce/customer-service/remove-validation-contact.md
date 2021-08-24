---
title: Remove association between contact and customer for cases in Customer Service | MicrosoftDocs
description: Learn how to remove validation on contact and customer for cases in Dynamics 365 Customer Service
ms.date: 08/24/2021
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
ms.custom: 
  - dyn365-customerservice
---

# Remove association between contact and customer for cases in Customer Service

## Introduction

When you create or update a case record for a customer and contact, out of the box, the contact record must be associated with the customer. However, based on your business requirements, you might need to select a contact record that is not associated with the customer record. You can customize the case form to remove the form validation to meet your business needs.

## Remove the association between contact and customer for a case

Perform the following steps to disable validation and remove the association between contacts and customers:

1. Go to the [Power Apps](https://make.powerapps.com) portal.
2. Select the required environment, select **Solutions** in the left pane.
3. On the **Solutions** page, select Default Solution.
4. On the top right, select All, and then select Environment variable in the list.
5. Select the ellipses for msdyn_IncidentShouldValidatePrimaryContact, and then select Edit.
6. On the flyout menu that appears, select **New value**, enter the number **0**, and select **Save**. Now, when creating or updating a case, the agents can select contacts who are not part of the customer organization.

### See also

[Overview of Customer Service workspace](csw-overview.md)  
[Create a case](customer-service-hub-user-guide-create-a-case.md)  
[Environment variables in Power Apps](/powerapps/maker/data-platform/environmentvariables)  

