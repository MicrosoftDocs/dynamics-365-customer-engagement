---
title: Remove validation on contact and customer for cases in Customer Service | MicrosoftDocs
description: Learn how to remove validation on contact and customer for cases in Dynamics 365 Customer Service
ms.date: 08/25/2021
ms.topic: article
author: neeranelli
ms.author: nenellim
search.audienceType: 
  - admin
  - customizer
  - enduser
ms.custom: 
  - dyn365-customerservice
---

# Remove validation on contact and customer for cases in Customer Service

## Introduction

When you create or update a case record for a customer and contact, out of the box, the contact record must be associated with the customer record. However, based on your business requirements, you might need to select a contact record that doesn't belong to the customer organization. To meet your business needs, you can customize the case form to remove the form validation and thereby allow an unrelated contact be linked with the case.

## Remove the validation on contact and customer for a case

Perform the following steps to disable the validation on contacts and customers:

1. Go to the [Power Apps](https://make.powerapps.com) portal.
2. Select the required environment, select **Solutions** in the left pane.
3. On the **Solutions** page, select Default Solution.
4. On the top right, select All, and then select Environment variable in the list.
5. Select the ellipses for msdyn_IncidentShouldValidatePrimaryContact, and then select Edit.
6. On the flyout menu that appears, select **New value**, enter the number **0**, and select **Save**.

Now, when agents are creating or updating a case, they can select contacts who are not part of the customer organization.

### See also

[Overview of Customer Service workspace](csw-overview.md)  
[Create a case](customer-service-hub-user-guide-create-a-case.md)  
[Environment variables in Power Apps](/powerapps/maker/data-platform/environmentvariables)  

