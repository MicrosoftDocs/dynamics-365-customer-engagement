---
title: "Overview of guidance content | MicrosoftDocs"
description: "Technical guidance for developers created by the Microsoft Dynamics 365 Customer Engagement team based on common issues and problems reported by customers. The guidance in these topics includes guidance regarding usage, design, performance, security, upgrade readiness, online migration, maintainability, and supportability. This content describes common symptoms, problematic patterns, and the potential impact of common problems as well as guidance about how to avoid them."
ms.date: 02/05/2018
ms.service: "crm-online"
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: c2f2ce17-2dc0-43fa-8b44-d71c9cdaa6ac
author: "mhuguet"
ms.author: "michu"
manager: "austinj"
---
# Overview of guidance content

**Applies to**:

- [!include[](../includes/pn-crm-9-0-0-online.md)]
- [!include[](../includes/pn-crm-2016.md)]
- [!include[](../includes/pn-crm-8-1-0-both.md)]
- [!include[](../includes/pn-crm-2015.md)]
- [!include[](../includes/pn-crmv6.md)]
- [!include[](../includes/pn-crm-2011.md)]

We have identified common issues that can occur if best practices are not followed when you are customizing, extending, or integrating with the platform. This section provides you a centralized location to learn about the issues we have identified, their impact, and understand the guidance to resolve them. You will have some background about why things should be done in a certain way and avoid potential problems in the future. This can benefit the usability, supportability, and performance of your environment.  The guidance documentation supports the existing information within the SDK and the Developer and Administration guides.

<a name='custtypes'></a>

## Targeted customization types

The documentation targets the following customization types:

- Configuration changes through a [!include[](../includes/pn-dynamics-crm.md)] designer or administrative console
- Client scripts
- Custom workflow activities and plug-ins
- Integrations through the [!include[](../includes/pn-dynamics-crm.md)] SDK, the various [!include[](../includes/pn-dynamics-crm.md)] web based services, [!include[](../includes/pn-azure-shortest.md)], [!include[](../includes/pn-flow.md)], and PowerApps.

<a name='sections'></a>

## Sections

Each guidance article includes most or all of the following sections:

- *Title* - description of the guidance
- *Applies to* - supported versions of the product in which the guidance applies
- *Category* - one or more areas impacted by not following the guidance
- *Impact potential* - the level of risk (high, medium, or low) of affecting the environment by not following the guidance
- *Symptoms* - possible indications that the guidance has not been followed
- *Guidance* - recommendations that may also include examples
- *Problematic patterns* - description or examples of not following the guidance
- *Additional information* - supporting details for a more extensive view
- *See also* - references to learn more about something mentioned in the article

## Categories

Each guidance article is classified with one or more of the following categories:

- *Usage* – improper usage of a particular API, pattern, or configuration
- *Design* – design flaws in a customization
- *Performance* – customization or pattern that may produce a negative effect on performance in areas such as memory management, CPU utilization, network traffic, or user experience
- *Security* – potential vulnerabilities in a customization that could be exploited in a runtime environment
- *Upgrade Readiness* - customization or pattern that may increase risk of having an unsuccessful version upgrade
- *Online Migration* - customization or pattern that may increase risk of having an unsuccessful online migration
- *Maintainability* – customization that unnecessarily increases the amount of developer effort required to make changes, the frequency of required changes, or the chance of introducing regressions
- *Supportability* – customization or pattern that falls outside the boundaries of published supportability statements, including usage of removed APIs or implementation of forbidden techniques