---
title: Configure and customize the customer details and recent records | MicrosoftDocs 
description: Learn about adding Customer360 and Recent Records cards to forms
author: gandhamm 
ms.author: mgandham
ms.reviewer: neeranelli
ms.service: dynamics-365 
ms.topic: how-to 
ms.date: 01/30/2023 
ms.custom: bap-template 
---

# Configure and customize customer details and recent cases on forms

 The **Customer360** and **Recent records** components, when added to a form, display the customer details and related records on the corresponding application page. The **Recent records** component is now available on the Conversation form as **Recent cases** out of the box. Use **Recent Cases** to customize the related cases card that's displayed on the Customer Summary page.

## Add the Customer360 and Recent records components

Perform the following steps to add the Customer360 and Recent Records components:

1. In [Power Apps](https://make.preview.powerapps.com/), select the environment that contains your solution.
1. Select **Tables**, select the required table, and then select the **Forms** area.
1. Select the required entity.
1. In the form designer, select **Components** from the left navigation, and then scroll down to the following: 
   - **Customer 360**: Drag and drop it into a section on the form. On the **Properties** panel:
        - Select the attributes from the table that must be displayed as fields on the form to the user. You can select up to seven simple and three composite attributes. 
        - Specify if the users can edit the fields in the card in the **Enable Editing** drop down. This field is set to **Yes** by default. 
          :::image type="content" source="media/powerapps-customer360.png" alt-text="Customer details" lightbox="media/powerapps-customer360.png":::
   - **Recent records**: Drag and drop it into a section on the form. On the **Properties** panel: 
        - Specify the **Table** from which the records must be displayed. 
        -  Select the **Default view** and **Default chart**. The views and charts available in the table are displayed.
        - Specify the maximum number of rows to be displayed on the card, when the card loads. The default number of rows displayed is 4.
           :::image type="content" source="media/powerapps-recent-records.png" alt-text="Default minimal resolve case" lightbox="media/powerapps-recent-records.png":::

> [!NOTE]
> Select **Get more components** if you can't see these options in **Components**.

## Customize recent cases on the Customer Summary form 

 Perform the following steps to customize the related cases displayed on the Customer Summary form:

1. In [Power Apps](https://make.preview.powerapps.com/), select the environment that contains your solution.
1. Select **Tables**, select **Conversation**, and then select the **Customer Summary** form.
1. Select **Recent cases** on the **Form** area.
1. On **Properties**: 
   - Specify the **Table** from which the records must be displayed. 
   - Select the **Default view** and **Default chart**. The views and charts available in the table are displayed.
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

     | Current experience | Previous experience |
     | ------------ | ------------- |  
     |  :::image type="content" source="media/customer-summary-recent-case.png" alt-text="Recent cases new control experience on UI" lightbox="media/customer-summary-recent-case.png"::: | :::image type="content" source="media/recent-cases-legacy.png" alt-text="Recent cases legacy control experience on UI" lightbox="media/recent-cases-legacy.png"::: |

### See also

[Learn the basics of the Customer Service Hub](customer-service-hub-user-guide-basics.md)

[Use the Main form and its components](../customerengagement/on-premises/customize/use-main-form-and-components.md)
  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
