---
title: Add the Knowledge Base Search control
description: Learn how to add the Knowledge Base Search control to the work order form in Dynamics 365 Field Service.
ms.date: 10/22/2024
ms.topic: how-to
author: jshotts
ms.author: jasonshotts
ms.custom: bap-template
---

# Add the Knowledge Base Search control

Add a Knowledge Base Search control to the work order form to make it easy for users in your organization to find knowledge articles. A dispatcher or frontline worker can search for an article and then link it to the work order. The Knowledge Base Search control can be customized and can also be added to any form enabled for knowledge management.

## Prerequisites  

- [Set up knowledge management](/dynamics365/customer-service/administer/set-up-knowledge-management-embedded-knowledge-search.md)
  
- Select the entity/table you want to enable knowledge management on while setting up knowledge management. For example, work order.

## Add the control to the form

1. Sign in to [Power Apps](https://make.powerapps.com/) and select your environment.

1. Select **Tables** and then select **All**.

1. Search for and select **Work Order**.

1. Under **Data experiences**, select **Forms**. Open the form where you want to add the Knowledge Base Search control.

1. Navigate to the tab where you want to add the control and add a new section.

1. Select **Component** and search for **Knowledge Search**.

   > [!Note]
   > If the option to add Knowledge Base Search is disabled, it could be because knowledge management isn't set up or isn't enabled for the entity for which you're adding the search control.

1. In the **Knowledge** panel, set the properties you want. Learn more: [Property descriptions](/dynamics365/customer-service/administer/add-knowledge-base-search-control-forms#power-apps-experience).

1. Select **Save and Publish**.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
