---
title: Create or edit leads
description: Learn how to create a lead in Dynamics 365 to track business prospects and add notes, activities, and related contacts.
ms.date: 09/16/2024
ms.topic: how-to
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
searchScope:
 - D365-App-msdynce_saleshub
 - D365-App-msdynce_salespro
 - D365-Entity-lead
 - D365-UI-*
 - Dynamics 365
 - Sales
ms.custom:
 - ai-gen-docs-bap
 - ai-gen-desc
 - ai-seo-date:08/30/2023
 - bap-template
---

# Create or edit leads

Create leads in Dynamics 365 to track potential new customers. A lead can be an existing client or someone you've never done business with before. You might get leads from many sources, such as advertising, networking, or email campaigns. You can add notes, activities, and related contacts to your leads.

[!INCLUDE [trial-cta-note](../includes/trial-cta-note.md)]

## Create or edit a lead

1. In the sitemap of your sales app, select **Leads**.

1. Select **New**.

1. Enter the information you have about the lead. Only the **Topic** and **Last name** are required. All other details are optional.

1. Select **Qualify** in the process bar and select or [create an account and contact](accounts-contacts.md).

    - If you select an account or a contact, the company name and contact address details are filled in for you if they were empty. If that information was already entered, your selection doesn't change the existing values.
    - If you create an account or a contact, Bing Maps can fill in the address details for you if your administrator has turned on address suggestions. Scroll down to the **Address** box and start typing the street address. Select an address from the list of suggestions provided by Bing Maps.
    - When you create a lead, you can select any values for **Existing Contact** and **Existing Account** until you save the lead. After you save the new lead, you can only select values that have been filtered to avoid duplicates.

1. Select or enter the remaining details in the **Qualify** step.

1. In the **Timeline** section, add any notes or [activities](manage-activities.md), like phone calls or tasks, that are related to the lead.

1. To add a contact as a stakeholder, scroll down to the **Stakeholders** section and select **New Connection**. Search for and select a contact to connect and assign the Stakeholder role. Or, select **New Contact** to create a contact, connect it, and assign it the Stakeholder role.

    - A *stakeholder* is a key contact at the account who's involved in making purchase decisions. If you associated a contact in the **Qualify** step and selected **mark complete** to identify the contact as the account's decision maker, then that contact is automatically connected as a stakeholder and assigned the Stakeholder role.
    - By default, the contact you connect is assigned the Stakeholder role. To select a different role, select the space to the left of the contact in the list, select **Edit**, and assign the correct role.
  
   > [!IMPORTANT]
   > If you don't see "New Connection", it means your organization is using a customized view of leads. In that case, select the **Connections** tab, and then select **Connect** to connect a stakeholder to the lead.

1. Select the **Details** tab and enter any other information you have about your lead, such as industry and preferred contact method.

1. Select **Save & Close**.

## Import leads from Excel, CSV, and XML Files

You can add leads by importing them from a Microsoft Excel, CSV, or XML file or from Microsoft Exchange. [Learn how to import data into Dynamics 365 Sales](import-data.md).

## Do more with leads

- [Nurture your leads through a marketing campaign](../sales-enterprise/get-started-app-marketing-sales.md)
- [Research leads through social media channels like LinkedIn](../insights-insideview/insights-powered-by-insideview.md)
- [Increase your marketing and sales effectiveness](../versium-predict/versium-predict.md) (applies to the Sales app only)

## Typical next steps

- [Qualify a lead and convert it to an opportunity](qualify-lead-convert-opportunity-sales.md)
- [Get introduced to the lead through who knows whom](who-knows-whom.md)
- [Learn about the sales process, nurturing sales from lead to order](nurture-sales-from-lead-order-sales.md)
- [View relationship analytics and KPIs for the lead](relationship-analytics.md)

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

## Related information

[Print quote, invoice, or other records](print-records.md)

[!INCLUDE [footer-include](../includes/footer-banner.md)]
