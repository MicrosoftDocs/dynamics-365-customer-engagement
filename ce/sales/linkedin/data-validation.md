---
title: Data validation capabilities of LinkedIn Sales Navigator
description: Learn how to access and use the data validation capabilities of LinkedIn Sales Navigator. The solution uses LinkedIn information to validate contact records.
ms.date: 09/06/2024
ms.topic: how-to
author: udaykirang
ms.author: udag
keywords: "installation, setup, sales navigator"
search.audienceType: 
  - admin
  - customizer
  - enduser
applies_to: 
  - "Dynamics 365 Version 9.x"
  - "Dynamics 365 (online)"
---

# Data validation capabilities of LinkedIn Sales Navigator

This article describes the data validation capabilities of the LinkedIn Sales Navigator solution for Dynamics 365 Sales that helps you keep the organizational structure of your matched contacts up to date. It uses the LinkedIn information to validate the contact records in Dynamics 365 Sales and enables you to check back on pending opportunities or have a useful icebreaker when getting in touch with a contact.

## Prerequisites

To ensure timely updates if a matched contact changes the company, the following prerequisites must be met:

- The CRM sync capability in LinkedIn Sales Navigator is activated by an administrator. To learn more, see [CRM Sync & Activity Writeback for Dynamics 365](https://business.linkedin.com/sales-solutions/sales-navigator-customer-hub/resources/ms-dynamics-sync-activity-writeback).

- The data validation LinkedIn in Sales Navigator is enabled by an administrator. To learn more, see [Sales Navigator Data Validation for Dynamics 365](https://business.linkedin.com/sales-solutions/sales-navigator-customer-hub/resources/data-validation-dynamics).

- You must have a Microsoft Relationship Sales solution Plus license. To learn more, see the **Dynamics 365 Sales** section from the [Microsoft Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/?LinkId=866544).

- The data validation settings are turned on in **Settings** > **Business Management** > **LinkedIn sales navigator**. When the data validation feature is turned on for the first time, you get updates about the company change status for the past two years. Afterwards, the updates come are sent to the system on daily basis, every 24 hours.

## Access the data validation capabilities Dynamics 365 Sales

There are several ways to find out if a contact's company has changed.

- From the org chart on an Account record: A red dot next to a contact's name in the org chart indicates that their company has changed since you built the org chart.

- From the **Relationship Assistant** card in the **Sales Activity Social Dashboard**. To turn on the Relationship Assistant card, go to **Settings** > **Sales Insights** > **Insight cards**

- From the **Opportunities** > **All Opportunities at Risk - Contact left** view in Dynamics 365 Sales.

- From the **Contacts** > **All Contacts Not at Company** view in Dynamics 365 Sales.

## Update the contact details

To update the org chart for a specific contact, perform the following steps in the **Verify Contact Details** pane.

:::image type="content" source="media/sales-navigator-side-pane.png" alt-text="Screenshot of side pane to verify contact details.":::

1. In Dynamics 365 Sales, open the **Verify Contact Details** pane as described in the section above.

1. Under the **LinkedIn Sales Navigator** widget, search for the new account of this contact using the **Change Account** field.

1. Select **Update contact** to change the company information of the contact.

## Ignore the proposed update to a contact

>[!NOTE]
>Your administrator must enable the **Personnel and employment changes** setting in the **Sales Navigator Integration Settings** to ignore a contact's company change. To know more about the setting, see [Enable LinkedIn Sales Navigator](install-sales-navigator.md#enable-linkedin-sales-navigator).  

To ignore a proposed update of an org chart, select **Ignore Update** in the **Verify Contact Details** pane. This option ignores only the current update. If the contact has changes in the future, you are notified again.  

When your administrator enables the **Hide employment notification** setting in the **Sales Navigator Integration Settings**, selecting **Ignore Updates** ignore all current and future updates for the contact.  

## Related information

[Integrate LinkedIn Sales Navigator solutions for Dynamics 365 Sales](integrate-sales-navigator.md)
