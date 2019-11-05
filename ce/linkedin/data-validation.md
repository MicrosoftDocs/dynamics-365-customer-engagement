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

This article describes the data validation capabilities of the LinkedIn Sales Navigator solution for Dynamics 365 Sales that helps you keep the organizational structure of your matched leads up-to-date. It uses information from LinkedIn to validate the infromation on records in Dynamics 365 Sales and enables you to check back on pending opportunities or have a useful icebreaker when getting in touch with a lead.

<!-- find places to link to from other topics -->

## Prerequisites

To ensure timely updates if a matched lead changes the role or the company, the following prerequisites must be met:

- The CRM sync capability in LinkedIn Sales Navigator is activated by an administrator

- The data validation capabilities in Sales Insights settings is turned on

## Access the data validation capabilities Dynamics 365 Sales

There are several ways to find out if a lead's organization or role has changed. 

- From the org chart on a company record: A red dot next to a person's name in the org chart indicates their role or organization has changed since you built the org chart. 

- From the contact card of a lead or opportunity that was matched with a LinkedIn Sales Navigator lead: You can change the values for the new company or hierarchy right in the side bar of the contact.

- From the Relationship Assistant card in the on the dashboard of Sales Insights. 

- From the **Opportunities** > **All Opportunities at Risk** view in Dynamics 365 Sales