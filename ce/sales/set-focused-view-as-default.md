---
title: Enable focused view and set it as the default view
description: Enable focused view manually for entities other than contact, account, lead, and opportunity and set it as the default view for any entity in Dynamics 365 Sales.
author: udaykirang
ms.author: udag
ms.topic: how-to 
ms.date: 01/12/2024
ms.custom: bap-template 
---

# Enable focused view and set it as default

In focused view, sellers can view and manage their CRM records and their associated activities on one page. This view makes it easier for sellers to stay focused on their tasks and reduces the need to navigate between multiple screens. It also allows sellers to better organize and prioritize their tasks.

> [!NOTE]
> - When you set focused view as the default view, users can't switch to list view. If users must be able to use both views, set list view as the default view.
> - Focused view is not available for the Activities entity.

## Enable focused view as default

> [!NOTE]
> To view the **Default view** option, ensure that you have opted in for early access features. More information: [Opt in to early access updates](/power-platform/admin/opt-in-early-access-updates)

Focused view can be set as the default view for the contact, lead, account, and opportunity record types for users. This eliminates the need for users to manually switch to the focused view each time they sign into the application.

As an administrator, you must configure the focused view to be default for lead, account, contact, and opportunity required record type grid for your entire organization.  

To configure focused view as default, follow these steps:

1. In the Sales Hub app, open the contact, lead, account, or opportunity grid.  
1. Change to focused view and in the work item section, select **Settings**.
1. On the **Settings** pane, select **Default view**.
1. Turn on the toggle to enable focused view as default for the required record types.  

    >[!NOTE]
    >By default, focused view is enabled for lead grid view.  

1. Save and close the settings pane.

   Focused view is now enabled and set as the default view for the required record types.  

## Enable focused view as default for custom and other record types

Focused view is available by default for contact, account, lead, and opportunity record types. However, you must enable it manually for all other record types. You can also set it as the default view for any entity so that sellers don't have to switch to focused view each time they access their entity list. 
  
Use the following steps to enable focused view or set it as the default:  

1. Sign in to the [Power Platform admin center](https://admin.powerplatform.microsoft.com/).
1. Select your environment.
1. Select **Settings** > **Product** > **Features**.
1. Under the **Grids and views** section, turn on the **Enable focused view for all records** toggle.  
1. Save and publish your changes.

   Focused view is now enabled and set as the default view for quotes.

### See also

[View and manage records in focused view](focused-view.md)  
[Focused view FAQs](faq-sales.yml#focused-view)
