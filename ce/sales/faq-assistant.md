---
title: Assistant FAQs
description: Get answers to frequently asked questions about the assistant.
ms.date: 3/15/2024
ms.topic: troubleshooting
author: udaykirang
ms.author: udag
ms.reviewer: udag
ms.owner: shujoshi
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:03/11/2024
---

# Assistant FAQs

This article answers frequently asked questions about the assistant in Dynamics 365 Sales and Sales premium.

## Why am I getting an "insufficient permissions" alert while using an insight card?

If you see an alert about having insufficient permissions to use an Insight card, take these steps:  

1. Go to **Settings** > **Security** > **Security Roles**.  
2. Choose the user role viewing the insight cards.  
3. Select the **Core Records** tab.  
4. Set the privileges to Read and Write access for **Action card** and **Action card User Settings**.  

   :::image type="content" source="media/action-card-permissions600.png" alt-text="Screenshot of the insight card security role privilege.":::

## Why am I getting a "contact administrator" error while authenticating credentials in assistant studio?

Your organization's policies are restricting third-party tools to access user information. To resolve the issue, use the [Azure portal](https://portal.azure.com) to provide consent for yourself for third-party tools to access your data. To provide consent for the entire organization, contact your tenant administrator. Select the enterprise application as **Dynamics 365 Sales Insights** in Azure portal while providing the consent. [Learn how to grant admin consent in Enterprise apps](/azure/active-directory/manage-apps/grant-admin-consent#grant-admin-consent-in-enterprise-apps).

