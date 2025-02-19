---
title: FAQ about Sales Qualification Agent
description: 
ms.date: 02/19/2025
ms.topic: overview
ms.service: dynamics-365-sales
content_well_notification:
  - AI-contribution
ms.custom:
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/04/2023
  - bap-template
  - ai-gen-description
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# FAQ about Sales Qualification Agent

This FAQ provides answers to common questions about the Sales Qualification Agent in Dynamics 365 Sales.

<a name="icp"></a>
## What is ideal customer profile?

An ideal customer profile (ICP) is a detailed description of a target customer who would benefit the most from your company's products or services. Your ideal customer profile (ICP) might include characteristics like product type, industry, company size, and location. For instance, if your company sells advanced CRM software, your ICP might include:

- **Industry**: Technology, Financial Services, Healthcare

- **Company Size**: Mid to large-sized enterprises with 500+ employees

- **Geographic Location**: North America, Europe

- **Pain Points**: Need for improved customer relationship management, desire to streamline sales processes, requirement for robust data analytics

- **Decision Makers**: Chief Information Officer (CIO), Chief Technology Officer (CTO), Head of Sales

By focusing on leads that match this profile, you can tailor your approach to address specific needs and challenges, thereby increasing the likelihood of a successful sale.

<a name="handraiser"></a>
## What is hand-raiser criteria?

Hand-raiser criteria allow you to define specific conditions that qualify a lead as a "hand-raiser." Hand-raisers are leads who have shown explicit interest in your product or service, indicating a higher likelihood of conversion. By establishing clear hand-raiser criteria, you can quickly identify and prioritize these high-potential leads.

Common hand-raiser criteria include:

- **Form Submissions**: Leads who fill out contact forms, request demos, or download gated content.

- **Email Engagement**: Leads who frequently open emails, click on links, or respond to outreach.

- **Website Behavior**: Leads who visit key pages on your website, such as pricing, product details, or case studies.

- **Event Participation**: Leads who attend webinars, trade shows, or other company-hosted events.

## Why am I not seeing the carousel component in my grid?

The carousel component is displayed only when the following conditions are met:

-   The agent is activated in your environment.

-   You have the [necessary permissions to access the agent.](#admin-enable-and-configure-the-sales-qualification-agent) Even if you're a system administrator, you must add your role to the Team access list.

-   You are using Read Only Grid view.

-   You have [provided consent to the agent](#provide-consent-to-agent).

-   You are using the [new look and feel](https://learn.microsoft.com/power-apps/user/modern-fluent-design#enabling-the-modern-look-for-my-app-and-removing-the-toggle) for the Sales Hub app.

-   You have leads that are open and were created in the last 14 days.

## Why are there no suggested actions in my carousel?

If there are no suggested actions in the carousel, it could be due to the following reasons:

-   The agent hasn't processed the leads in your environment yet.

-   The agent hasn't found any prioritized insights about the leads.

## Why don't I see the new notification bar in the lead form?

The notification bar appears only for leads that have been researched and prioritized by the agent. Learn more about the [selection criteria](#selectioncriteria).

##  Is it mandatory to enable server-side synchronization and sync emails to Dynamics?

Server-side synchronization is recommended but not mandatory. If server-side synchronization is enabled in your organization, selecting **Send email** for email-based actions will send the email directly. Otherwise, the email opens in Outlook for you to send manually.

