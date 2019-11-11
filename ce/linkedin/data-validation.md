---
title: "Data validation capabilities for the LinkedIn Sales Navigator integration | Microsoft Docs"
description: "Data validation for LinkedIn Sales Navigator integration in Dynamics 365 Sales"
keywords: "installation, setup, sales navigator"
ms.date: 11/15/2019
ms.service: crm-online
ms.topic: article
applies_to: 
  - "Dynamics 365 Version 9.x"
  - "Dynamics 365 (online)"
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365LinkedIn
---

# Data validation

This article describes the data validation capabilities of the LinkedIn Sales Navigator solution for Dynamics 365 Sales that helps you keep the organizational structure of your matched leads up-to-date. It uses information from LinkedIn to validate the information on records in Dynamics 365 Sales and enables you to check back on pending opportunities or have a useful icebreaker when getting in touch with a lead.

## Prerequisites

To ensure timely updates if a matched lead changes the role or the company, the following prerequisites must be met:

- The CRM sync capability in LinkedIn Sales Navigator is activated by an administrator

- The data validation settings are turned on in **Settings** > **Business Management** > **Sales Navigator Integration Settings**

## Access the data validation capabilities Dynamics 365 Sales

There are several ways to find out if a person's organization or role has changed.

- From the org chart on an Account record: A red dot next to a person's name in the org chart indicates their role or organization has changed since you built the org chart.

- From the **Relationship Assistant** card in the on the **Sales Activity Social Dashboard**. To turn on the Relationship Assistant card, go to **Settings** > **Sales Insights** > **Insight cards**

- From the **Opportunities** > **All Opportunities at Risk - Contact left** view in Dynamics 365 Sales.

- From the **Contacts** > **All Contacts Not at Company** view in Dynamics 365 Sales.

## Update the contact details

To update the org chart for a specific person, perform the following steps in the **Verify Contact Details** pane.

![Side pane to verify contact details](media/sales-navigator-side-pane.png)

1. In Dynamics 365 Sales, open the **Verify Contact Details** pane as described in the section above.

2. Under the LinkedIn Sales Navigator widget, search for the new account of this person using the **Change Account** field.

3. Select **Update contact** to change the company information of the person.

## Ignore the contact details

To ignore a proposed update of an org chart, select **Ignore Update**  in the **Verify Contact Details** pane.