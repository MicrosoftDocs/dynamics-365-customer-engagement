---
title: Customizing the Microsoft 365 integration for Field Service (preview)
description: Learn how to tailor the Micorosoft 365 integrations for Dynamics 365 Field Service to your business
ms.date: 11/06/2023
ms.topic: how-to
author: matthidinger
ms.author: mahiding
ms.reviewer: v-wendysmith
ms.custom: bap-template
ms.subservice: m365-integrations
---

# Customizing the Microsoft 365 integration for Field Service (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

Help frontline managers and workers accomplish their tasks faster by filling in and retrieving the specific pieces of information they need, when they need it.

The primary goal of customization is to enable your users (frontline managers and frontline workers) to fill in and retrieve the most important data for the task at hand. We currently support customization of the **Work Orders** and **Bookable Resource Booking** experiences.

By configuring the **Work Order** experience you will help frontline managers quickly enter the most important information when creating and updating Work Orders from Outlook. Additionally, any fields which are added to the form will attempt to be populated from Copilot if there is relevant information provided in the email. 

:::image type="content" source="media/flw-customization-overview.png" alt-text="Field Service  customization overview":::

## TODO: Documentation image showing Outlook with customized fields, and maybe arrows showing which pieces of content are extracted from the email into the form

By configuring the **Booking** experience will determine what fields are available to frontline workers when updating their booking.

<Screenshot of Teams>

### Prerequisites

- Global admin or Exchange admin permissions in the Microsoft 365 Admin Center
- Environment is in a [supported geography, region, and language](flw-overview.md#supported-geographies-regions-and-languages)
- One of more of the Microsoft 365 integrations for Field Service have been deployed. See [this page](flw-admin.md) for those instructions.

### Overview

The general workflow is as follows:
[modify the schema itself](field-service-customize-columns-fields.md)


1. Install and navigate to the Dynamics 365 Field Service (Preview) app in Microsoft Teams
1. Navigate to the **Settings** page
1. Choose an existing **View** 



### Further reading

* [General customization best practices](field-service-customization-best-practices.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]