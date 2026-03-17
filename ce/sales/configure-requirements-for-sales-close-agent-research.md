---
title: Configure requirements for Sales Close Agent - Research
description: Configure the prerequisites for the Sales Close Agent in Dynamics 365 Sales.
ms.date: 03/19/2026
ms.topic: how-to
ms.service: dynamics-365-sales
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-description
  - ai-seo-date:08/04/2025
author: udaykirang
ms.author: udag
ms.reviewer: udag
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Configure requirements for Sales Close Agent - Research

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

Before you configure the Sales Close Agent - Research, ensure that the following prerequisites are configured in your Dynamics 365 Sales environment.

| Prerequisite | Description |
|--------------|-------------|
| Bing search | Required for the agent to find and retrieve answers from your data sources. |
| Microsoft 365 Services | Required if you want the agent to read emails directly from sellers' Microsoft 365 mailboxes. |

## Configure the prerequisites

1. [Open the Sales Close Agent - Research settings page](open-sales-close-agent-research-settings.md).  
1. On the **Scenario** page, go to the **Prerequites** section and configure the following:
   - **Bing search**: Select **Accept terms** to open the Power Platform admin center and accept the terms for Bing search. learn more in [Turn on data movement, Bing search, and Microsoft 365 services for Copilots and generative AI features](/power-platform/admin/geographical-availability-copilot?tabs=new#turn-on-data-movement-bing-search-and-microsoft-365-services-for-copilots-and-generative-ai-features)
   - **Microsoft 365 Services**: (Optional) To allow the agent to read emails directly from the sellers' Microsoft 365 mailboxes, select **Mark as done** and then select **Apply changes**. Sellers are also prompted to provide consent when they first access the Opportunity research page. If you want to [use server-side synchronization](#configure-server-side-synchronization) for reading emails, don't select the checkbox.

     To configure and use Microsoft 365 Services, you need:
     - At least *ONE* of the following roles: Global administrator, Dynamics 365 administrator, or tenant administrator.
     - At least *ONE* of the following licenses: Microsoft 365/Office 365, Power Automate Premium, or Dynamics 365 Sales Enterprise Edition.

     > [!NOTE]
     > The agent reads emails of the opportunity owner to generate insights. However, the insights are visible to all users who can access the opportunity.

1. Select **Continue** to proceed to the agent configuration page.

   :::image type="content" source="media/opportunity-research-agent-settings.png" alt-text="Screenshot of the Sales Close Agent - Research settings page.":::

## Configure server-side synchronization

If you want the agent to access only the emails and meetings synced to Dynamics 365 Sales, configure server-side synchronization for seller mailboxes. Alternatively, you can enable Microsoft 365 Services for the agent to read emails directly from the sellers' Microsoft 365 mailboxes.

If both server-side synchronization and Microsoft 365 Services are enabled, the agent reads emails from both sources and generates insights accordingly.

1. [Create an email server profile for Exchange Online](/power-platform/admin/connect-exchange-online?tabs=new#create-an-email-server-profile-for-exchange-online).

1. [Configure default email processing and synchronization](/power-platform/admin/connect-exchange-online?tabs=new#configure-default-email-processing-and-synchronization).
1. [Configure mailboxes](/power-platform/admin/connect-exchange-online?tabs=new#configure-mailboxes) of sellers who own the opportunities and [approve their mailboxes](/power-platform/admin/connect-exchange-online?tabs=new#approve-mailboxes). When the configuration is successful, the **Incoming Email Status** and **Outgoing Email Status** for the mailbox are set to **Success**.
    :::image type="content" source="mailbox-status.png" alt-text="Screenshot of a user mailbox in Dynamics 365 Sales with status indicators.":::

1. Make sure that the personalization option for email tracking is set to an appropriate value to allow the agent to access emails and meetings from the sellers' mailboxes. You can choose an option that best suits your organization's privacy policies. Perform *ONE* of the following actions:

    - Notify the sellers to set the tracking option in the Sales Hub app from **Settings** > **Personalization settings** > **Emails**  > **Track**.
      :::image type="content" source="media/email-track-personal-options.png" alt-text="Screenshot of the Personalization settings page in Dynamics 365 Sales with the All email messages option selected.":::

    - Use the **User Settings Utility** in [XRMToolBox](/power-apps/developer/data-platform/community-tools) to select multiple sellers and set the `Track email messages` setting to an appropriate tracking option.

      :::image type="content" source="media/xrmtoolbox-email-tracking.png" alt-text="Screenshot of the User Settings Utility in XRMToolBox with the Track email messages option set to All email messages.":::

## Next step

[Configure the agent profile for Sales Close Agent](configure-sales-close-agent-profile.md)

## Related information

[Set up and configure the Sales Close Agent (preview)](configure-sales-close-agent.md)