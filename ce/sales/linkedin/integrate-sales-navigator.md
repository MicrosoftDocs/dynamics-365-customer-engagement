---
title: Integrate LinkedIn Sales Navigator with Dynamics 365 Sales
description: Learn how to integrate the Sales Navigator solutions with Dynamics 365 Sales to enhance your business processes with data about people and organizations.
ms.date: 08/20/2024
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
keywords: integration, sales navigator, linkedin, versions
search.audienceType: 
  - admin
  - customizer
  - enduser
applies_to: 
  - Dynamics 365 Sales
ms.assetid: e9258994-b84a-cefb-4d97-762f4bc3ca5a
---

# Integrate LinkedIn Sales Navigator solutions for Dynamics 365 Sales

Digital transformation is real. Across every industry vertical, companies are rethinking their business processes and reorganizing their segments. Use LinkedIn Sales Navigator to enhance key application scenarios by connecting the system of record with the [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] data graph and insights. You can also build custom applications by using [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Sales Navigator to enhance business processes with data about people, organizations, and relationships. 

>[!NOTE]
>The LinkedIn Sales Navigator solution is also available for Dynamics 365 Sales Professional.

## Unified Interface apps: Sales Navigator Controls for Unified Interface 

Two flavors of [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Sales Navigator controls are available and [can be placed on any desktop Unified Interface application form](add-sales-navigator-controls-forms.md). You can configure your forms to show more than one control at the same time.  

The **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Sales Navigator Lead** control shows information about a [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] member profile. This control has the following sections, which you can choose to show or hide: 

- **Top Card**: Shows information about the person like name, headline, and more. Additionally, it provides capabilities to message or save the person as a lead in Sales Navigator. 

- **News (Icebreakers)**: Shows the person’s highlights, activities, conversation starters, and more.

- **Connections (Get Introduced)**: Shows the mutual connections and allows for a warm introduction to the person. 

- **Related Leads**: Shows potential Sales Navigator leads who are similar to the target person and might represent the relevant stakeholders around them. On a sales scenario, this insight is crucial to identify the potential decision-makers for a deal. 

The **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Sales Navigator Account** control shows information about a [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] company profile. This control has four modules, which you can choose to show or hide: 

- **Top Card**: Shows information about the company like company name, industry, location, and more. Additionally, provides capabilities to view the related account and save it in Sales Navigator. 

- **News**: Shows the latest news of this company. 

- **Connections**: Shows relevant connections for this company that can establish a first contact.

- **Account IQ**: Stay on top of your accounts with AI-generated insights. Understand your customer's strategic priorities, challenges, financials, and what their employees are talking about on LinkedIn.

  :::image type="content" source="media/account-iq.png" alt-text="Screenshot of the Account IQ in Sales Navigator.":::

  Learn more about the Account IQ feature in [LinkedIn Sales Navigator documentation](https://www.linkedin.com/help/sales-navigator/answer/a6270076).

- **Find Key People**: Shows the recommended leads or contacts in the company who can help you connect with the customer and establish a relationship. With the LinkedIn Sales Navigator Advanced Plus license, you can uncover leads that closely match your selected target buyer's persona and access more insights about the leads. For Sales Navigator Advanced users, this control shows only lead recommendations without the ability to search based on buyer persona. For more information about integrating this control, see [Account module reference](/linkedin/sales/display-services/accounts-screenshots_full#find-people). The following image shows the enhanced insights, such as TeamLink and mutual connection details, available with the Advanced Plus license.

    :::image type="content" source="media/find-people-linkedin.png" alt-text="Screenshot of Find People section in the LinkedIn Sales Navigator control" lightbox="media/find-people-linkedin.png":::
  
    > [!NOTE]
    > Features that connect to the CRM such as Add to CRM require [CRM sync to be enabled](https://business.linkedin.com/sales-solutions/sales-navigator-customer-hub/resources/ms-dynamics-sync-activity-writeback).

Both **Sales Navigator Lead** and **Sales Navigator Account** controls also provide an alternate version, which takes a lookup (entity reference) attribute that allow users to search for LinkedIn profiles.

- **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Sales Navigator Lead lookup** control: the name of the referenced entity is used as the member's first name and last name. The string is separated by white spaces and the first component is considered the first name while the remaining components are considered last names.

- **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Sales Navigator Account lookup** control: the name of the referenced entity is used as the company name.

The control binds to a field that is used to match the record with [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] member profile or company account. Once a match is found, subsequent loads are done through the record GUID association. If the control does not load the correct profile on the first match, users can resolve the issue by [finding the correct match](view-sales-navigator-forms.md#change-the-incorrect-matching) with the provided search interface. 

## Dynamics CRM 2016 and Dynamics 365 apps: [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Sales Navigator for Microsoft Dynamics

Two [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Sales Navigator widgets are available to display on forms in [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)]. Please refer to the link below for more information and detailed steps for installing and setting up the solution. 

> [!NOTE]
>Before April 2019, there were two separate solutions on AppSource. Now there is a single solution included out of box, however there is still some required setup to configure LinkedIn's CRM sync.

[Set up the LinkedIn Sales Navigator for Microsoft Dynamics integration](https://business.linkedin.com/sales-solutions/sales-navigator-customer-hub/resources/ms-dynamics-sync-activity-writeback)


## Related information

[Install and enable LinkedIn Sales Navigator](install-sales-navigator.md)     
[Customize forms to show Sales Navigator controls](add-sales-navigator-controls-forms.md)    
[Work with Sales Navigator controls on forms](view-sales-navigator-forms.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]

