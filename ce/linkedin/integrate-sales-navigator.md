---
title: "Integrate LinkedIn Sales Navigator solutions for Dynamics 365 | Microsoft Docs"
description: "Learn how to integrate the Sales Navigator solutions with Dynamics 365."
keywords: "integration, sales navigator, linkedin, versions"
ms.date: 06/10/2018
ms.service: crm-online
ms.topic: article
applies_to:
  - "Dynamics 365 Version 9.x"
  - "Dynamics 365 (online)"
ms.assetid: e9258994-b84a-cefb-4d97-762f4bc3ca5a
author: m-hartmann
ms.author: mhart
manager: sakudes
---

# Integrate LinkedIn Sales Navigator solutions for Dynamics 365

Digital transformation is real. Across every industry vertical, companies are rethinking their business processes and entire segments are reorganizing. Enhance key application scenarios by connecting the system of record with the [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] data graph and insights. Build custom applications powered by [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Sales Navigator intelligence, enhancing business processes with data about people, organizations, and relationships. 

## Unified Interface apps: Sales Navigator Controls for Dynamics 365 Unified Interface 

Two [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Sales Navigator controls are [available through AppSource](install-sales-navigator.md) and [can be placed on any desktop Unified Interface application form](add-sales-navigator-controls-forms.md). 

The **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Sales Navigator Lead** control shows information about a [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] member profile. This control has the following sections, which you can choose to show or hide: 

- **Top Card**: shows information about the person like name, headline, and more. Additionally, provides capabilities to message or save the person as a lead in Sales Navigator. 

- **News (Icebreakers)**: shows the person’s highlights, activities, conversation starters, and more.

- **Connections (Get Introduced)**: shows the mutual connections and allows for an introduction to the person. 

- **Related Leads**: shows potential leads who are similar to the target person and might represent the relevant stakeholders around them. On a sales scenario, this insight is crucial to identify the potential decision makers for a deal. 

The **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Sales Navigator Account** control shows information about a [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] company profile. This control has four modules, which can be mixed and matched: 

- **Top Card**: shows information about the company like company name, industry, location, and more. Additionally, provides capabilities to view the related account and save it in Sales Navigator. 

- **News**: shows the latest news of this company. 

- **Connections**: shows relevant connections for this company that can establish a first contact. 

- **Recommended Leads**: shows the recommended potential leads in this company that may be opportunities open for the next deal. 

Both controls also provide an alternate version, which takes a lookup (entity reference) attribute instead of the attributes described above. 

- **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Sales Navigator Lead lookup** control: the name of the referenced entity is used as the member's first name and last name. The string is separated by white spaces and the first component is considered the first name while the remaining components are considered last names.

- **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Sales Navigator Account lookup** control: the name of the referenced entity is used as the company name.

The control binds to a field that is used to match the record with [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] member profile or company account. Once a match is found, subsequent loads are done through the record GUID association. If the control does not load the correct profile on the first match, users can resolve the issue by [finding the correct match](view-sales-navigator-forms.md) with the provided search interface. 


## Dynamics CRM 2016 and Dynamics 365: [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Sales Navigator for Microsoft Dynamics

Two [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Sales Navigator widgets are available to display on forms in [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)]. Please refer to the links below for more information and detailed steps for installing and setting up the solution. 

[Get the solution from AppSource](https://appsource.microsoft.com/product/dynamics-365/linkedin.0cb76fe0-d453-4edb-a68c-65fb9119493a?src=Retail&tab=Overview)

[Set up the LinkedIn Sales Navigator for Microsoft Dynamics integration](https://www.linkedin.com/help/sales-navigator/answer/82207)


### See also

[Install and configure LinkedIn Sales Navigator Controls](install-sales-navigator.md)     
[Customize forms to show Sales Navigator controls](add-sales-navigator-controls-forms.md)    
[Work with Sales Navigator controls on forms](view-sales-navigator-forms.md)
