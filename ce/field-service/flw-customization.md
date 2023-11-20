---
title: Customize the Microsoft 365 integration for Field Service (preview)
description: Learn how to tailor the Micorosoft 365 integrations for Dynamics 365 Field Service to your business
ms.date: 11/06/2023
ms.topic: how-to
author: matthidinger
ms.author: mahiding
ms.reviewer: v-wendysmith
ms.custom: bap-template
ms.subservice: m365-integrations
---

# Customize the Microsoft 365 integration for Field Service (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

Customize the work order and booking experiences to help frontline managers and workers accomplish their tasks faster by filling in and retrieving the specific pieces of information they need, when they need it. As an admin, customize the work order form with the most important information for your organization. Any fields you add to the form are readily available to your users when creating and updating a work order in Outlook or Teams. In Outlook, Copilot will also attempt to populate those fields if there is relevant information provided in the email. Customize the booking experience with the key details for your organization so workers fill out that information when updating their bookings.

We currently support customization of the **Work Orders** and **Bookable Resource Booking** experiences.

:::image type="content" source="media/fsp-flw-customizate-overview.png" alt-text="Example of a customized work order form in Field Service using Outlook":::

<!--- TODO: Documentation image showing Outlook with customized fields, and maybe arrows showing which pieces of content are extracted from the email into the form --->

<Screenshot of Teams>

## Prerequisites

- Global admin or Exchange admin permissions in the Microsoft 365 Admin Center
- Environment is in a [supported geography, region, and language](flw-overview.md#supported-geographies-regions-and-languages)
- One of more of the Microsoft 365 integrations for Field Service have been deployed. See [this page](flw-admin.md) for those instructions.

## Create a custom view

1. In Microsoft Teams, select **Settings**, then **Customize views**.

1. Select the environment you want to customize.

1. Select **Edit views in Power Apps**. Power Apps automatically opens to the **Tables** page for the environment.

1. Select **All** and then search for **work order**.

1. Select the work order table.

1. Under **Data experiences**, select **Views** and then select **New view**. Enter a name and optional description and select Create. The **Work Order Number** column automatically displays.

1. Select View column and enter the following required columns and optionally add other columns:

   • Service Account
   • System Status
   • Work Order Type
   • Work Order Summary

1. Drag and drop the columns to customize the view. Then select Save & publish.

1. Return to Teams and select Refresh data. Select the new view and select Publish.

## Add or edit columns

See [modify the schema itself](field-service-customize-columns-fields.md)

### Further reading

* [General customization best practices](field-service-customization-best-practices.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]