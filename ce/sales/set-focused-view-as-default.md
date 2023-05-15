---
title: Set focused view as the default view
description: Set the focused view as the default view for contact, account, lead, and opportunity entities in Dynamics 365 Sales.
author: udaykirang
ms.author: udag
ms.topic: how-to 
ms.date: 05/05/2023
ms.custom: bap-template 
---

# Set focused view as the default view

The focused view allows sellers to view and manage account, contact, lead, and opportunity records and their associated activities on one page.

>[!IMPORTANT]
>When you set the focused view as the default, users can't switch to list view. To allow users to use both views, make the list view the default.  

## Set as default view

By default, the **Read-only Grid view** is set as the default view for accounts, contacts, leads, and opportunities. As an administrator, you can set the focused view as the default, so sellers don't have to switch to it each time they access their respective entity list.  

>[!NOTE]
>In this procedure, we are using opportunity as example. 

1. From the Sales Hub app, select **Settings** > **Advanced Settings**.

1. From the **Settings** menu, select **Customizations** > **Customize the system**.

1. From the Power Apps Default Solution page, select **Entities** > **Opportunity**.

1. Select the **Controls** tab and select **Focused view** for web, phone, and tablet. 
    If you don't see the **Focused view** in the **Control** list, select **Add Control**. From the **Add Control** dialog, select **Focused view** and then select **Add**.

1. Save and publish the changes.  

    The focused view is now set as the default view for opportunities.

### See also

[View and manage records in focused view](focused-view.md)  
[Focused view FAQs](faq-sales.yml#focused-view)

