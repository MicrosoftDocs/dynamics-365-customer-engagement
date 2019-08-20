---
title: "What's new in Dynamics 365 for Sales | MicrosoftDocs"
description: "Learn about what's new in the latest release of Dynamics 365 for Sales."
keywords: "what's new, Dynamics 365 for Sales"
ms.date: 08/20/2019
ms.service:
  - "crm-online"
ms.custom:
  - ""
ms.topic: article
ms.assetid: a87d5f37-892f-43a8-97b2-151037132f72
author: shubhadaj
ms.author: shujoshi
manager: annbe
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
---

# What's new in Dynamics 365 for Sales

Welcome to [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)]! Visit this page to see what’s added or updated recently. 


## Dynamics 365 for Sales, August 2019 release

Here are the list of features available with this release:

- **Customization of Opportunity Close form**: When closing an opportunity, organizations need to understand why the opportunity was lost or won to build upon past losses and successes or to try new strategies for improving win rates. The capability to customize the Opportunity Close form helps companies to capture close/win details based on their strategic sales initiatives. More information: [Customize Opportunity Close form](customize-opportunity-close-experience.md)

- **Enhancements to the adding or editing of Opportunity/Quote/Order/Invoice products experience**: The following enhancements are made to the experience of adding product line items to opportunity, quote, or invoice records:
    - Salespeople can add an existing product to an Opportunity, Quote, Order, and Invoice, with or without a price list. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Add products to an opportunity](add-products-opportunity.md), [Add products to a quote, order, or invoice](add-product-quote-order-invoice.md)
    - Administrators can choose whether to enforce the selection of a price list. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Make selection of price list optional](make-price-list-optional.md)
    - Salespeople can quickly view and edit properties for a product, even while editing Opportunity or Quote line items. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Add products to an opportunity](add-products-opportunity.md), [Add products to a quote, order, or invoice](add-product-quote-order-invoice.md)
    - Administrators can use additional customization options on the price list item entity.

- **Business card scanner**: The integrated business card scanner will help sales people to scan business cards via mobile or web. The scanner will analyze the card for relevant information and automatically update respective fields in Dynamics 365 for Sales. The feature also supports configuration, allowing users to select alternative fields to populate. More information: [Scan business cards](scan-business-cards.md)

- **Territory hierarchy**: A hierarchical relationship is available out-of-the-box on the Territory record type (entity). This will allow organizations to model and visualize their sales territories in a hierarchical format. More information: [Set up sales territories to organize business markets by geographical area](../admin/set-up-sales-territories-organize-business-markets-geographical-area.md)

- **Enhancements to lead management experience**: The following enhancements are made to the experience of managing leads in Dynamics 365 for Sales:
    - Contact and company-related fields are automatically filled in when a sales rep selects an existing contact or account while creating a new lead.
    - When a lead is qualified to an opportunity, notes and attachments captured by a sales rep are displayed in the opportunity record.
    - Sales reps get an option to create an opportnity, account, or contact when they qualify leads based on the organization-level settings configured by the admin for the lead creation experience.  

More information: [Define lead qualification experience](define-lead-qualification-experience.md)

> [!IMPORTANT]
> - The features listed in this section are preview features. [What are Preview features and how do I enable them?](../admin/what-are-preview-features-how-do-i-enable-them.md)
> - To learn about enabling preview features in the 2019 release wave 2, see [How do I enable the 2019 release wave 2 updates](/power-platform/admin/preview-october-2019-updates#when-will-the-2019-release-wave-2-features-be-enabled)

## Dynamics 365 for Sales, May 2019 release

With Dynamics 365 for Sales version 9.0.1905.2010 or later, users will be able to create a PDF and email it from a quote record. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Generate a PDF document from a quote record](create-quote-pdf.md), [Enable PDF generation from quotes](enable-pdf-generation-quote.md) 

## Dynamics 365 for Sales, April 2019 release

-  Dynamics 365 for Sales (build 9.1.0.4023) introduces forecasting, a new capability to help organizations to provide the necessary insights into how they can manage their workforce, cash flow, and resources.
Sales managers and sales people can use forecasting to project how much a sales team can sell or to estimate the revenue of the organization. Sales people can use forecasting to prevent deals from slipping away by spotting pipeline risks and tracking how they are performing against their targets.  [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Project accurate revenue with forecasting](project-accurate-revenue-sales-forecasting.md)

    > [!IMPORTANT]
    > This feature is currently in preview. 

- With Dynamics 365 for Sales (build 9.0.1903.4006), playbooks can be created for Account and Contact record types in the Sales Hub app (Unified Interface), in addition to the existing record types that are currently supported. Also, sales managers can associate necessary documents with playbook activities to provide additional contextual information to sales representatives working on a playbook.

- Dynamics 365 for Sales (build 9.0.1903.4007) allows users to discover the best of third-party Configure, Price and Quote (CPQ) solution providers from within the Sales application. It makes it easier to leverage partner applications to get an immersive and intuitive product configuration experience. For more information, see the blog: [Leverage partner apps for a seamless configure-price-quote (CPQ) experience](https://cloudblogs.microsoft.com/dynamics365/bdm/2019/04/09/leverage-partner-apps-for-a-seamless-configure-price-quote-cpq-experience/)


## Dynamics 365 for Sales, Fall 2018

-  Dynamics 365 for Sales introduces Playbook, a new capability to help organizations automate repeatable sales activities and respond to external events. It provides proactive and predictive event-driven guidance that can suggest the next best actions and surface relevant activities to successfully respond to external events. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Enforce best bractices with playbooks](enforce-best-practices-playbooks.md)

   > [!NOTE]
   > The Playbook capability is currently available only in the Sales Hub app For Dynamics 365 for Sales. It is being released with [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] application version 9.0.1810.4006 or later and the server version 9.1.0.0263 or later, as part of the weekly release of the product to individual geographies. 
   > To learn about updating an app solution, see [Install, update, or remove a preferred solution](../admin/install-remove-preferred-solution.md). 



## Dynamics 365 for Sales, Spring 2018 

-  **Sales admin settings**: With Dynamics 365 for Sales, Spring 2018, all the sales settings are now available in the Sales Hub app. An administrator doesn't have to use the web application to configure price lists, units, product catalog, and goal settings right from the Sales Hub app. 

-  **View hierarchical data**: With Dynamics 365 for Sales, Spring 2018, you can see how info is related or grouped by viewing accounts, products, or users in hierarchical charts in the Sales Hub app. You can click a tile in the chart to get the full details and then navigate to the info you’re interested in. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [See relationships in a hierarchical view](../basics/hierarchical-relationship.md)

-  **Sales app is built on the Unified Interface framework for consistent user experience**: The new Sales Hub app delivers a consistent, uniform user interface and follows responsive design principles for optimal viewing on any screen size or device. Entities used in the sales process, including products, goals, and sales literature, run on this responsive platform and conform to common data model standards. 


## Embedded intelligence

- **Preview: Assistant**: The new redesigned assistant administration helps the administrator or sales manager create custom insight cards, prioritize cards, optimize card ranking, and assign cards to user roles for your Dynamics 365 for Sales organization. 
[!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Preview: Manage insight cards](../sales-enterprise/manage-custom-cards-flow.md).
