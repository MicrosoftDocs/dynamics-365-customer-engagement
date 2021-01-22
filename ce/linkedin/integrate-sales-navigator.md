---
title: "Integrate LinkedIn Sales Navigator solutions for Dynamics 365 Sales | Microsoft Docs"
description: "Learn how to integrate the Sales Navigator solutions with Dynamics 365 Sales."
keywords: integration, sales navigator, linkedin, versions
ms.date: 04/30/2019
ms.service: crm-online
ms.topic: article
applies_to: 
  - Dynamics 365 Sales
ms.assetid: e9258994-b84a-cefb-4d97-762f4bc3ca5a
author: shubhadaj
ms.author: shujoshi
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365LinkedIn
---

# Integrate LinkedIn Sales Navigator solutions for Dynamics 365 Sales

Digital transformation is real. Across every industry vertical, companies are rethinking their business processes and entire segments are reorganizing. Enhance key application scenarios by connecting the system of record with the [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] data graph and insights. Build custom applications powered by [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Sales Navigator intelligence, enhancing business processes with data about people, organizations, and relationships. 

>[!NOTE]
>The LinkedIn Sales Navigator solution is also available for Dynamics 365 Sales Professional.

## Unified Interface apps: Sales Navigator Controls for the unified interface 

Two flavors of [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Sales Navigator controls are available and [can be placed on any desktop Unified Interface application form](add-sales-navigator-controls-forms.md). You can configure your forms to show more than one control at the same time.  

The **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Sales Navigator Lead** control shows information about a [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] member profile. This control has the following sections, which you can choose to show or hide: 

- **Top Card**: shows information about the person like name, headline, and more. Additionally, it provides capabilities to message or save the person as a lead in Sales Navigator. 

- **News (Icebreakers)**: shows the person’s highlights, activities, conversation starters, and more.

- **Connections (Get Introduced)**: shows the mutual connections and allows for a warm introduction to the person. 

- **Related Leads**: shows potential Sales Navigator leads who are similar to the target person and might represent the relevant stakeholders around them. On a sales scenario, this insight is crucial to identify the potential decision-makers for a deal. 

The **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Sales Navigator Account** control shows information about a [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] company profile. This control has four modules, which you can choose to show or hide: 

- **Top Card**: shows information about the company like company name, industry, location, and more. Additionally, provides capabilities to view the related account and save it in Sales Navigator. 

- **News**: shows the latest news of this company. 

- **Connections**: shows relevant connections for this company that can establish a first contact. 

- **Recommended Leads**: shows the recommended potential leads in this company that may be opportunities open for the next deal. 

Both controls also provide an alternate version, which takes a lookup (entity reference) attribute instead of the attributes described above. 

- **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Sales Navigator Lead lookup** control: the name of the referenced entity is used as the member's first name and last name. The string is separated by white spaces and the first component is considered the first name while the remaining components are considered last names.

- **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Sales Navigator Account lookup** control: the name of the referenced entity is used as the company name.

The control binds to a field that is used to match the record with [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] member profile or company account. Once a match is found, subsequent loads are done through the record GUID association. If the control does not load the correct profile on the first match, users can resolve the issue by [finding the correct match](view-sales-navigator-forms.md#change-the-incorrect-matching) with the provided search interface. 


## Dynamics CRM 2016 and Dynamics 365 apps: [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Sales Navigator for Microsoft Dynamics

Two [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Sales Navigator widgets are available to display on forms in [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)]. Please refer to the link below for more information and detailed steps for installing and setting up the solution. 

> [!NOTE]
>Before April 2019, there were two separate solutions on AppSource. Now there is a single solution included out of box, however there is still some required setup to configure LinkedIn's CRM sync.

[Set up the LinkedIn Sales Navigator for Microsoft Dynamics integration](https://business.linkedin.com/sales-solutions/sales-navigator-customer-hub/resources/ms-dynamics-sync-activity-writeback)


### See also

[Install and enable LinkedIn Sales Navigator](install-sales-navigator.md)     
[Customize forms to show Sales Navigator controls](add-sales-navigator-controls-forms.md)    
[Work with Sales Navigator controls on forms](view-sales-navigator-forms.md)
