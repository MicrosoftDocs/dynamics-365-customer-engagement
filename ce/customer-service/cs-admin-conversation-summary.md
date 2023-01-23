---
title: "Configure and customize the customer details and recent records | MicrosoftDocs"
description: "Learn about adding Customer360 and Recent Records cards to forms."
ms.date: 01/30/2023
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
---

# Configure and customize the customer details and recent records cards

The application displays the customer details and related records if the **Customer360** and **Recent Records** components are added to a form. For the Conversation form, the **Recent Cases** subgrid enables users to customize the related records that are displayed.

## Add the Customer360 and Recent Records components

Perform the following steps to add the Customer360 and Recent Records components:

1. In [Power Apps](https://make.preview.powerapps.com/), select the environment that contains your solution.
1. Select **Tables**, select the required table, and then select the **Forms** area.
1. Select the required entity.u
1. In the form designer, select **Components** from the left navigation, and then scroll down to the following: 
   - **Customer 360**: Drag and drop it into a section on the form. On the **Properties** panel:
        - Select the attributes from the table that must be displayed as fields on the form to the user. You can select up to seven columns and three composite attributes. 
        - Specify if the users can edit the fields in the card in the **Enable Editing** drop down. This field is set to **Yes** by default. 
   - **Recent records**: Drag and drop it into a section on the form. On the **Properties** panel: 
        - Specify the **Table** from which the records must be displayed. 
        -  Select the **Default view** and **Default chart**. The views and charts available in the table are displayed.
        - Specify the maximum number of rows to be displayed on the card, when the card loads. The default number of rows displayed is 4.

> [!NOTE]
> Select **Get more components** if you can't see these options in **Components**.

## Customize recent records on the Customer Summary form 

On the Conversation form, the **Recent Cases** component can be used to customize the related records to be displayed on the Customer Summary form. On the **Properties** panel: 
        - Specify the **Table** from which the records must be displayed. 
        -  Select the **Default view** and **Default chart**. The views and charts available in the table are displayed.
        - Specify the maximum number of rows to be displayed on the card, when the card loads. The default number of rows displayed is 4.

You can also choose to go back to the legacy recent cases experience in the Customer Summary form. To revert back to the legacy experience, perform the following steps:

1. In [Power Apps](https://make.preview.powerapps.com/), select the environment that contains your solution.
1. Select **Tables**, select the **Conversation** table, and then select the **Forms** area.
1. Select the **Customer Summary** form.
1. Select **Components** and then select **1- column section** . Drag and drop it into a section on the form.
1. Select **Quick view** and add it to the previously added **1- column section** on the form. Specify the following details:
    - **Lookup**: Customer
    - **Account**: Cases for Customer
    - **Contact**: Cases for Customer
1. Select **Save** and **Publish**.
