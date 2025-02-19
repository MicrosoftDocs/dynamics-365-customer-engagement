---
title: Configure email engagement
description: Configure email engagement to show alerts and reminders for sellers and sales managers to help build customer relationships.
ms.date: 02/20/2024
ms.topic: how-to
ms.assetid: 04db6801-020a-4a99-9ad3-907422524b6f
author: udaykirang
ms.author: udag
ms.reviewer: udag
ms.custom: bap-template

---
# Configure email engagement 

Configure email engagement to show sellers and sales managers the insights on customers' engagement with emails to help build customer relationships. Only the emails that are sent from Dynamics 365 are considered for email engagement analysis.

## To enable email engagement

To enable email engagement, do the following steps:
 
1. [Review the prerequisites](#prerequisites)
2. [Enable email engagement](#enable-email-engagement)

> [!NOTE]
> To benefit from the complete experience of email engagement, turn on the email engagement insight cards **[Email opened](action-cards-reference.md#EmailOpened)** and **[Email reminder](action-cards-reference.md#EmailReminder)**.

> [!IMPORTANT]
> By enabling this feature, you consent to share data about your customers' email activity with other Microsoft services. Data imported from external systems into Dynamics 365 is subject to our privacy statement.

## Prerequisites

Verify the following prerequisites before enabling email engagement for your organization:

- Enable standard Sales Insights features. More information: [Enable and configure standard Sales Insights features](intro-admin-guide-sales-insights.md#enable-and-configure-standard-sales-insights-features)

- To use followed email attachments:  
    - [!INCLUDE[pn_onedrive_for_business](../includes/pn-onedrive-for-business.md)] must be available to your Dynamics 365 Sales server. More information: [Enable OneDrive for Business](/power-platform/admin/enable-onedrive-for-business)  
    - Enable document management for email in Sales. More information:[Enable SharePoint document management for specific entities](/power-platform/admin/enable-sharepoint-document-management-specific-entities)  
    - Enable SharePoint to be shared externally to anonymous (unauthenticated) users to allow external email recipients to access file attachments. More information: [External sharing overview](/sharepoint/external-sharing-overview)  

- To enable delivery-time recommendations based on recipients' time zones, you must enable [!INCLUDE[pn_bing_maps](../includes/pn-bing-maps.md)] in Sales. More information: [System Settings dialog box - General tab](/dynamics365/customer-engagement/admin/system-settings-dialog-box-general-tab)  
- To count email replies, ensure that the settings within the **Tracking email conversations** section are properly configured in the Power Platform admin center. More information: [Manage email tracking settings](/power-platform/admin/settings-email-tracking).

## Enable email engagement

1. Sign in to Dynamics 365 Sales, and go to the Sales Hub app.

1. Go to **Change area** in the lower-left corner of the page, and select **Sales Insights settings**.

    :::image type="content" source="media/si-admin-change-area-sales-insights-settings.png" alt-text="Screenshot of select Sales Insights settings.":::

1. In the **Email engagement (standard)** section, select **Grant Permissions**.

    :::image type="content" source="media/si-admin-email-engagement-grant-permissions.png" alt-text="Screenshot of granting Email engagement permissions.":::

    A confirmation message is displayed in a tab. Close the tab and proceed to set up email engagement.

    > [!NOTE]
    > If you've already granted permissions, this step is skipped. You don't have to grant permissions to email engagement again.

1. In the **Email engagement** section, select **Set up** and then turn on the toggle.  

    :::image type="content" source="media/si-admin-email-engagement-enable.png" alt-text="Screenshot of Email engagement enabled.":::

Email engagement is enabled and ready to use in your organization. 

## Disable the enhanced attachment feature

When the enhanced attachment feature is enabled, users can't follow email attachments. By default, the enhanced attachment feature is enabled. After you disable the feature, verify that the [prerequisites](#prerequisites) are met.  
To disable the feature, do the following steps:  

1. In the sales app, go to **Settings** > **Advanced Settings**.

    :::image type="content" source="media/advanced-settings-option.png" alt-text="Screenshot of the Advanced Settings option on the Settings menu.":::

1. Go to **Customization** > **Customizations** > **Customize the System**.

1. Select **Tables**, expand the **Settings** table, and then select **Settings definitions**.

    >[!NOTE]
    >If you're using the classic view, under **Components**, expand **Entities**, and then select **Settings**.

1. In the **Settings definitions** list, search and open **Use new email attachment control**

1. In the **Edit Use new email attachment control** pane, go to the **Setting environment value** section, and select the value as **No**.  

1. Save and publish the changes.

    Now, the enhanced attachment feature is disabled and users can follow email attachments. Learn more about [email attachments](create-send-email-message.md#add-attachments-).

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]

## Related information

[Introduction to administer Sales Insights](intro-admin-guide-sales-insights.md)  
[View message interactions with email engagement](email-engagement.md)
