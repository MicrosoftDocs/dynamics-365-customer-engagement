---
title: Get started with Field Service in Outlook (frontline managers)
description: Learn how service managers and dispatchers can install and get started with the Dynamics 365 Field Service for Outlook add-in.
ms.date: 04/03/2024
ms.topic: how-to
author: jasonxian-msft
ms.author: jasonxian
ms.reviewer: v-wendysmith
ms.custom: bap-template
ms.subservice: m365-integrations
---

# Get started with Field Service in Outlook (frontline managers)

Dynamics 365 Field Service has an add-in for Outlook so frontline managers can manage their work orders. To get started using Field Service in Outlook, make sure the Field Service for Outlook add-in is installed, then sign-in and open the add-in.

## Install the Field Service for Outlook add-in

Your admin might have installed the add-in for your organization. If you see the Field Service icon in your email actions or **Field Service** in an email's **More actions** (**&hellip;**) menu, you can skip this step.

### Prerequisites

- You have either Outlook on the web or Outlook 2013 or later on Windows or macOS.
- You have a license for both Outlook and Dynamics 365 Field Service. If you don't have one, contact your organization's IT administrator.
- Your environment is in a [supported geography, region, and language](flw-overview.md#supported-geographies-regions-and-languages)
  > [!NOTE]
  > The supported language is based on your Outlook language. If you access Outlook from the web, the language is based on the web browser. If you access Outlook from Outlook Desktop, the language is based on Outlook Desktop's language.

### Install the Outlook Add-in

1. Go to [Microsoft AppSource](https://aka.ms/fieldserviceaddin) and select **Dynamics 365 Field Service for Outlook**.

   :::image type="content" source="media/fsp-outlook-add-in.png" alt-text="Screenshot of Field Service add-in card":::

1. Select **Add**, **Get it now**, or **Update** and confirm your information.

> [!NOTE]
> Changing themes (colors, fonts, or effects) in some versions of Outlook Web aren't supported in Outlook add-ins.

## Get started with the add-in

1. Open an email or view it in the Reading Pane, select **More actions (...)**, and then select **Field Service**.

   > [!TIP]
   > If you can't find the add-in, it may appear in a different location. See [Use an add-in in Outlook](https://support.microsoft.com/office/get-an-office-add-in-for-outlook-1ee261f9-49bf-4ba6-b3e2-2ba7bcab64c8).

   :::image type="content" source="media/fsp-outlook-sign-in.png" alt-text="Screenshot of the Outlook message More actions menu, with the menu button and Field Service highlighted." lightbox="media/fsp-outlook-sign-in.png":::

1. Select **Sign in to get started**.

1. Sign in to your Dynamics 365 account and select your environment. If you don’t know your environment, see [Find your environment and organization ID and name](/power-platform/admin/determine-org-id-name).

1. Select **Get started**.

To make the Field Service add-in easier to get to in Outlook on the web, add it to your custom message actions:

1. Select **View** > **View settings** > **Customize actions**.

1. Under **Message surface**, select **Field Service**.

1. Select **Save**.

   :::image type="content" source="media/fsp-email.png" alt-text="Screenshot of an email in Outlook on the web, with the Field Service icon highlighted.":::

## Open the Field Service add-in

Open an email or view it in the Reading Pane, and then select the Field Service icon in the message actions. If you didn't add Field Service to your message actions, select **More actions** (**&hellip;**), and then select **Field Service**.

> [!TIP]
> By default, the **Field Service** pane closes when you switch to a different email. To keep the pane open across all emails, select the **Pin** icon.

## View version number and session ID

[Open the Field Service add-in](#open-the-field-service-add-in) and select the ellipsis (**&hellip;**).

:::image type="content" source="media/fsp-outlook-about.png" alt-text="Screenshot of Field Service Outlook pane showing version number, session ID, and links to overview and privacy statement.":::

In addition to the viewing the version number and session ID, you can sign out, or select a link to view the Field Service in Outlook overview or Microsoft Privacy Statement.

## Next steps

- [Manage work orders with Field Service in Outlook](flw-outlook.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
