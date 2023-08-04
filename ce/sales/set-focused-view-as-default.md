---
title: Enable focused view and set it as the default view
description: Set the focused view as the default view for contact, account, lead, and opportunity entities in Dynamics 365 Sales.
author: udaykirang
ms.author: udag
ms.topic: how-to 
ms.date: 08/04/2023
ms.custom: bap-template 
---

# Enable focused view and set it as the default view

In the focused view, sellers can view and manage their CRM records and their associated activities, on one page. 

> [!IMPORTANT]
> When you set the focused view as the default view, users can't switch to the list view. If users must be able to use both views, set the list view as the default view.

## Enable focused view for entities other than contact, account, lead, and opportunity

The focused view is enabled by default for contact, account, lead, and opportunity entities. However, you must enable it for all other entities.  

> [!NOTE]
> Focused view is not available for the Activities entity.

You can enable the view in the following ways:

- To enable the focused view for all entities and to add the **Focused view** button on the command bar, reach out to Microsoft Support.
- To enable the focused view for specific entities, add the **Focused view** control as explained in the next section and set it as a default if you'd like.

## Set focused view as the default view

As an administrator, you can set the focused view as the default view so that sellers don't have to switch to the focused view each time they access their entity list. The focused view control view is available by default for contact, account, lead, and opportunity entities. You can manually add the control for other entities.

This procedure uses opportunities as an example.  

1. In the Sales Hub app, select **Settings** > **Advanced Settings**.
1. On the **Settings** menu, select **Customizations** > **Customize the system**.
1. On the Power Apps Default Solution page, select **Entities** > **Opportunity**.
1. On the **Controls** tab, select **Focused view** for web, phone, and tablet. 

    If **Focused view** doesn't appear in the **Control** list, select **Add Control**. In the **Add Control** dialog box, select **Focused view**, and then select **Add**.

1. Save and publish your changes.

    The focused view is now set as the default view for opportunities.

### See also

[View and manage records in focused view](focused-view.md)  
[Focused view FAQs](faq-sales.yml#focused-view)
