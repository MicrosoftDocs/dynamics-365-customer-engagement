---
title: "Support for modernized business units (Dynamics 365 Marketing) | Microsoft Docs"
description: "Support for modernized business units in Dynamics 365 Marketing."
ms.date: 01/30/2023
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
search.audienceType: 
  - admin
  - customizer
  - enduser
---

# Support for modernized business units

Sometimes, users need access to data across multiple business units. For example, a marketer responsible for leading the marketing initiatives across both US and European subdivisions of a company, both represented by business units in Dataverse, needs access to data from both the business units. With [modernized business units](/power-platform-release-plan/2021wave2/data-platform/modernize-business-units), Dataverse now allows users to have security roles from different business units at the same time.

When modernized business units are [turned on](/power-platform/admin/wp-security-cds#enable-the-matrix-data-access-structure) for an environment that has business unit scoping enabled already, users need a way to specify which business unit they're creating an artifact for. For most of the entities, the default value of a business unit is set to the user’s business unit. However, journeys and emails have special behaviors:

- **Emails**: If the user selects a template, the email’s business unit is set to the business unit of the template. If the user skips template selection, then the email’s business unit is set to the user’s business unit.
- **Journeys**:
    - For a trigger-based journey, the business unit is set to the user’s business unit
    - For a segment-based journey, the business unit is set to the segment’s business unit

## Journeys

To modify business unit of a journey:

1. Go to **Journey settings** > **Edit** > **Business Unit**.
1. Select the **Business Unit** value from the lookup.

> [!NOTE]
> Changing the business unit of a journey renders the existing selections within the journey invalid and the user would need to modify them.

## Segments

To modify business unit of a segment:

1. Go to **Settings > Business Unit**.
1. Select the **Business Unit** value from the lookup.

> [!NOTE]
> Changing the business unit of a segment changes the business unit against which the segment is evaluated.

## Emails

To modify business unit of an email:

1. Go to **Email header** > **Email Settings** > **Business Unit**.
1. Select the **Business Unit** value from the lookup.

> [!NOTE]
> Changing the business unit of an email results in a complete reset of the email content.

## Templates

To modify business unit of a template:

1. Go to **Email header** > **Email Settings** > **Business Unit**.
1. Select the **Business Unit** value from the lookup.

> [!NOTE]
> Changing the business unit of a template results in a complete reset of the content.

## Content blocks

To modify business unit of a content block:

1. Go to **Settings** > **Business Unit**.
1. Select the **Business Unit** value from the lookup.

## Asset library

To modify business unit of an image:

1. Go to **General information** > **Business Unit**.
1. Select the **Business Unit** value from the lookup.

## Push notifications

To modify business unit of a push notification:

1. Go to **Edit** > **Business Unit**.
1. Select the **Business Unit** value from the lookup.

## Text messages

To modify business unit of a text message:

1. Go to **Edit** > **Business Unit**.
1. Select the **Business Unit** value from the lookup.

## Forms

To modify business unit of a form:

1. Go to **Edit** > **Form Settings** > **Business Unit**.
1. Select the **Business Unit** value from the lookup.

## Brand profiles

Given that brand profiles are selected and included in an email, Dynamics 365 Marketing doesn't support changing the business unit of an existing brand profile. However, users that have permissions for more than one business unit can select the specific business unit for which they want to create the brand profile.

[!INCLUDE[footer-include](../includes/footer-banner.md)]