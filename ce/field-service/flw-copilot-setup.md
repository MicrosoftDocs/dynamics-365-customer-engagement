---
title: Set up the Dynamics 365 Field Service Plugin for Microsoft Copilot (preview)
description: Learn how to set up the Dynamics 365 Field Service Plugin for Microsoft Copilot.
ms.date: 02/12/2024
ms.topic: how-to
author: KishorIoT
ms.author: nandab
ms.reviewer: v-wendysmith
ms.custom: bap-template
ms.subservice: m365-integrations
ms.collection: bap-ai-copilot 
---

# Set up the Dynamics 365 Field Service Plugin for Microsoft Copilot (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

As an admin, set up Microsoft Copilot for Field Service work orders for your users.

## Obtain licenses and set up the plugin

1. Log into the [Microsoft 365 admin center](https://admin.microsoft.com/).

1. Obtain the appropriate number of [Microsoft 365 Copilot licenses](/microsoft-365-copilot/microsoft-365-copilot-setup#manage-licenses-for-copilot).

1. [Set up the plugin](/microsoft-copilot-studio/copilot-plugins-overview#use-plugins-in-microsoft-copilot), including deploying the app and enabling the Microsoft Copilot setting.

1. Obtain access to the limited preview. Contact the [Microsoft Help Desk](https://aka.ms/TechWeb) to have them submit a Microsoft support ticket using the sentence "enable plugins for Copilot for Microsoft 365" within the ticket.

   <!--- Include a link once the section is updated (/microsoft-365-copilot/extensibility/prerequisites#requirements-for-plugin-development) --->

1. [Consent to moving data across regions](/power-platform/admin/geographical-availability-copilot#enable-data-movement-across-regions). For more information, see [How data movement across regions works](/power-platform/admin/geographical-availability-copilot#how-data-movement-across-regions-works).

## Verify the plugin and add plugin users

Once the support ticket is complete, perform the following steps.

1. Log into [Microsoft Copilot Studio](https://copilotstudio.microsoft.com/) and select **Plugins (preview)**.

1. Verify the Dynamics 365 Field Service plugin is listed.

   :::image type="content" source="media/fsp-copilot-studios-plugins.png" alt-text="Copilot Studio with Plugins (preview) and Dynamics 365 Field Service highlighted.":::

1. Log into the [Microsoft 365 admin center](https://admin.microsoft.com/) and select **Settings** > **Integrated apps**.

   :::image type="content" source="media/fsp-d365-copilot-app.png" alt-text="Microsoft 365 admin center showing the Dynamics 365 Copilot app.":::

1. Open **Dynamics 365 and Copilot Studio**, and then select the **Users** tab. [Add the users who will use the plugin](/microsoft-365/admin/manage/manage-plugins-for-copilot-in-integrated-apps#manage-how-users-can-install-plugins-for-copilot).

## Enable the Microsoft Copilot for Field Service work orders

[!INCLUDE [fsp-m365-copilot](../includes/fsp-m365-copilot.md)]

## Next steps

- [Overview of the Dynamics 365 Field Service Plugin for Microsoft Copilot (preview)](flw-m365-chat.md)
- [FAQ about Dynamics 365 Field Service Plugin for Microsoft Copilot (preview)](faqs-m365-chat.md)
- [Field Service Teams app for the frontline manager](flw-teams-manager.md)
- [Field Service Teams app for the frontline worker](flw-teams-worker.md)

[!INCLUDE [footer-include](../includes/footer-banner.md)]
