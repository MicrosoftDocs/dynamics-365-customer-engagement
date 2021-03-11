---
title: "New features in Dynamics 365 Customer Engagement (on-premises), version 9"
ms.date: "03/03/2021"
ms.topic: "topic"
ms.assetid: 676b68d9-2a7b-4924-a5cf-299163e8b5ea
author: mattp123
ms.author: matp
ms.prod: dynamicscrm-2016
---

# New features in Dynamics 365 Customer Engagement (on-premises), version 9.x

::: moniker range="op-9-1"

This section explains how to update to the Dynamics 365 Customer Engagement (on-premises), update 9.1. It also lists the features that included in the 9.1 update and are new to Dynamics 365 Customer Engagement (on-premises). The version 9.1 update introduces many feature enhancements designed to empower marketing, sales, and service teams.

## Update or upgrade to 9.1

# [Version 9.0 deployments](#tab/v90)

1.  Apply the Dynamics 365 Customer Engagement, version 9.1 update to all computers running Dynamics 365 Server and desktop applications in your deployment.

2.  Choose whether to:

    -   Import each organization into a new Dynamics 365 Customer Engagement (on-premises), version 9.1 server deployment. Each imported organization will be updated to Dynamics 365 Customer Engagement, version 9.1 during the import process.

    -   Update each organization in-place in the updated Dynamics 365 Customer Engagement, version 9.1 (on-premises) server deployment.

# [Version 8.2 deployments](#tab/v82)

1.  Upgrade all computers running Dynamics 365 Server and desktop applications in your deployment to Dynamics 365 Customer Engagement (on-premises), version 9.0.

2.  Apply the version 9.1 update to all computers running Dynamics 365 Server and desktop applications in your deployment.

3.  Next, update or import each organization.

---

For more information, see the following articles:

-   [Dynamics 365 Customer Engagement (on-premises) application updates](deploy/update-microsoft-dynamics-crm#microsoft-dynamics-365-customer-engagement-on-premises-application-updates)

-   [Deployment Manager: Update an organization](deploy/update-an-organization)

-   [PowerShell: Update-CrmOrganization](/powershell/module/microsoft.crm.powershell/update-crmorganization?view=dynamics365ce-ps)

-   [Upgrading Dynamics 365 Server](deploy/upgrading-microsoft-dynamics-365-server)

> [!NOTE]
> By default, when you apply the Dynamics 365 Server, version 9.1 update, all organization databases that are enabled in the deployment will be updated to Dynamics 365 Customer Engagement, version 9.1. Administrators can control which organization databases are upgraded in either of the following ways:
> 
> -   Disable the organizations you don't want upgraded. Notice that all organizations must remain disabled until all the servers in a multi-server deployment are updated. More information: [Deployment Manager: Disable or enable an organization](deploy/disable-or-enable-an-organization) and [PowerShell: Disable-CrmOrganization](/powershell/module/microsoft.crm.powershell/disable-crmorganization?view=dynamics365ce-ps).
> 
> - Configure the AutomaticallyInstallDatabaseUpdates deployment setting to false.
> 
>     `Add-PSSnapin Microsoft.Crm.PowerShell`
>     `set-crmadvancedsetting -configurationentityname Deployment -setting AutomaticallyInstallDatabaseUpdates -value $false`

### Apply the update

1.  Copy or download the appropriate update package to the computer where a Dynamics 365, v9.0 (on-premises) application, such as Dynamics 365 Server, v9.0 (on-premises) or Dynamics 365 Reporting Extensions is running.

2.  To start the update installation, right-click the update package, and then select **Run as administrator**.

## What's new?

### Enterprise Sales usability enhancements

To make Dynamics 365 Sales better, we're continually introducing usability enhancements within the application that reduce friction and make features easier to use.

### Familiar, modern email experience for agents

**Description**

Agents spend a significant amount of time using email to communicate with customers. Simple and intuitive email experiences help improve agent productivity and quality of service to customers. Email is also one of the core communications channels that sellers regularly use while interacting with customers and prospects. With the enhanced email (pop-up) experience available from the timeline, sellers will have a streamlined experience and greater flexibility, allowing them to respond to and view email correspondences without losing the current context. Additionally, sellers can be more productive with an improved file attachment experience that allows them to easily add and remove files to an email.

**Feature Details**

Agents spend a significant amount of time using email to communicate with customers. Simple and intuitive email experiences help improve agent productivity and quality of service to customers. In this release, we are bringing the following modern email capabilities to the agent experience:

-   Author emails using a complete rich text experience, including the ability to send, receive, and manage images inline.

-   Use a modern toolbar and can cut and paste formatted content from Office documents such as Word and Excel, while maintaining formatting.

-   Preview email templates prior to applying them to email.

-   Compose email in a pop-up, non-blocking window, with the ability to write an email with context of the current record, navigate between records, and have multiple active draft emails open simultaneously.

-   Inline file attachment experience with the ability to manage multiple files.

-   Quick preview for files.

-   Ability to select and manage multiple attached files.

### Familiar, modern email template experience for agents and administrators

**Description**

Agents spend a significant amount of time using email to communicate with customers. They often need to communicate the same information to all customers at different stages in the support life cycle such as a welcome email, refund instructions, or a personalized signature. Email templates make these processes efficient and standardized across the support team by providing the ability to create once and use it any number of times.

**Feature Details**

Email templates enable scale, efficiency, and consistency of email communication between agents and customers for support centers. In this release, we are bringing the following template-authoring capabilities to the agent and administrator experience:

-   Create templates with an intuitive and easy-to-understand experience.

-   Author templates using a complete rich text experience, including the ability to manage images inline.

-   Use a modern toolbar and can cut and paste formatted content from Office documents such as Word and Excel, while maintaining formatting.

-   Personalize the message with dynamic customer or entity data.

### Simplify your document workflows with enhanced PDF capabilities

**Description**

Organizations prefer creating and sharing offers or sales contracts in the form of non-editable PDF files to simplify and standardize the sales process and make it less error prone. To make it even easier to collaborate on these generated PDF files, Dynamics 365 Sales Hub optimizes the PDF generation experience further and extends the capability to custom entities.

**Feature Details**

-   Enable the seller to save and share standardized PDF files for custom entities based on standardized Word templates.

-   Enhanced PDF generation experience for the seller with simplified navigation, easy document template selection, PDF preview, and an intuitive PDF export and email options, with minimal clicks.

-   Automate workflows by generating standardized PDF files programmatically using APIs.

-   Conveniently manage entities for enabling/disabling PDF document generation.

### Get improved data management experience with simplified duplicate detection and merge capabilities

**Description**

Data quality not only affects business performance but has a direct effect on a user's experience and productivity, due to effort wasted on searching and reconciling data. Duplicate detection and merge capabilities play a significant role in keeping data clean. To enable organizations to maintain data hygiene, we're optimizing the duplicate detection and merge user experiences, which would help users to make an informed decision and avoid duplicate data entry.

**Feature Details**

-   Enable users to view more information contextually to help determine why a record is being flagged as a duplicate when they're adding or updating a record.

-   Enable users to merge the record being added or updated (account, contact, or lead) from the Duplicate warning prompt without navigating away, by using the enhanced Merge dialog box. The enhanced experience replaces the legacy web client hybrid dialog box with a fully enabled Unified Interface experience.

-   Enable sellers to easily view and identify matched accounts, contacts, and records when qualifying a lead, with an improved cross-entity duplicate detection dialog box.

-   Enable the improved duplicate detection and merge experiences with a configurable Administration flag.

### Usability enhancements for timeline

**Description**

The timeline control provides an easy and immersive experience to view a customer's history across cases, accounts, or contacts. This experience gives agents a better understanding of the customer's history, which helps them deliver more personalized service in an efficient and effective manner.

**Feature details**

Enhancements to the timeline control include the ability to:

-   View more details on an activity without the need to scroll.

-   Filter by activity type, set multiple filters simultaneously, and visually determine whether a list is filtered.

-   Find and highlight matching text with the search filter.

-   Show only user or system records with the **Post by** filter.

-   Visually identify closed or completed activities.

-   Expand or collapse all records.

-   Provide email-specific actions for email records.
 
More information: [Set up the timeline control](/powerapps/maker/model-driven-apps/set-up-timeline-control)

### Agent productivity enhancements to knowledge capabilities

**Description**

The ability to quickly find and share knowledge articles is a key asset that agents can use to help customers resolve questions and issues. By referring customers to knowledge articles that address common issues, agents can improve their efficiency and focus on resolving more complex or unique issues.

**Feature Details**

-   Use an improved layout of knowledge search results to simplify scanning, reading, and action.

-   Review knowledge articles in a separate, full screen.

-   Search the knowledge base outside the context of a customer case; knowledge search is now available in the Customer Service Hub app navigation for anytime access.

-   Use a modern toolbar with more font choices and the ability to cut and paste formatted content from Office documents such as Word and Excel while maintaining formatting. Meanwhile, use the enhanced inline table capabilities that allow quick tables and adding or deleting rows and columns.

### Configurable case resolution page

**Description**

When resolving a case, businesses often need to capture additional details that help characterize the case and resolution approach taken, which in turn, drive trend reports and service analytics. By supporting customization of the Case Resolution dialog box, Dynamics 365 Customer Service helps managers identify recurring issues and proven resolution patterns to inform other incident responses.

**Feature Details**

Administrators can perform the following customizations in the case resolution dialog box:

-   Add fields, such as resolution type in the form or dialog box for case resolution.

-   Introduce new client-side business validations or remove existing ones.

-   Customize the case resolution entity.

### Enhancements in the queue page

**Description**

Agents must constantly navigate between queue grids and record forms that results in too many click actions and context switching. With the enhancements made to the queue page, agents can now save time with fewer click actions and resolve customer issues quicker than before.

**Feature Details**

In this release, the user experience has been enhanced for agents to manage their queues. The agents can now select an item in the queue and view its details on the same page without having to switch contexts. They can also go through the list of items in the queue without the need to navigate away from the page.

### New work hour calendar in service scheduling

**Description**

Scheduling resources quickly and accurately is a key part of optimizing service for a business. This enhanced user experience makes scheduling easier and introduces flexibility to customize the experience for how the business operates to enhance scheduling efficiency.

**Feature Details**

Administrators currently navigate several screens to access a resource's calendar and update work hours and time off. With this release, we are delivering a new experience using an accessible Power Control Framework (PCF) calendar control in Unified Interface. Organizations will have flexibility to design new experiences (for example, using canvas apps) that modify resources' working hours from outside entity forms and views.

### Support for Site entity in Unified Interface

**Description**

As businesses migrate to the new Unified Interface, they require continuity of access to administrative configurations and settings.

**Feature Details**

To provide business continuity during transition to Unified Interface, this release delivers support for administrator configuration and interaction with the Site entity that is used to define customer service locations. 

More information: [Use sites to manage your service locations](/dynamics365/customer-service/uci-create-sites)

### Unified Interface enablement of case routing rules

**Description**

Routing of cases to the right queue, user, or team as quickly as possible ensures customers get service quickly and without having to be transferred between agents.

**Feature Details**

Case routing rules help trigger automatic or manual routing of cases to the right support resources. This release provides a new experience built on Unified Interface that enables easy configuration of routing rules and brings feature parity with the legacy web client.

### Enable silent, seamless migration from legacy to Unified Interface service scheduling experience

**Description**

This feature automatically migrates remaining customers who are using the legacy scheduling experience to the new Unified Interface-compliant service scheduling experience. The automated migration happens silently and has no impact on the customer's experience. Leveraging the latest experience ensures customers receive the best and most performant versions of Dynamics 365 applications.

**Feature Details**

The following entities will be automatically migrated from legacy to the latest Unified Interface service scheduling experience:

-   Site

-   Facility/equipment

-   Resource group

-   Service

-   Service activity

-   Service calendar

-   Search availability

### Insert knowledge articles into an email

**Description**

Email is a critical communication channel and a vehicle for sharing knowledge articles that support agents use to communicate with customers. This feature provides agents on Unified Interface with an easy way to insert one or more knowledge articles while working on an email.

**Feature Details**

The legacy web client allows agents working on emails to search for knowledge articles and insert them into the email without losing context. This feature brings this capability into the Unified Interface client. While working on an email, an agent can search and select a knowledge article to include in the email.

### Main form dialog editing experience for queue item

**Description**

The enhanced queue item experience provides immersive information to agents when they view the queue item details and update "Worked by" information.

**Feature Details**

Usability enhancements have been made for queue items. Agents can do the following actions in an immersive experience:

-   View the following details that are available in the context of the parent record:

    -   The queue to which the item belongs.

    -   Current assignee.

    -   Time it entered the queue.

    -   When it was last modified.

<!-- -->

-   Modify who is working on the queue item.

### In-app navigation enhancements for Dynamics 365 for phones and tablets

**Description**

The Unified Interface provides a common set of features when you run an app in a web browser and or on Dynamics 365 for phones and tablets app for iOS and Android. The enhanced site map and app navigation makes finding the right entity or page more intuitive on your mobile device.

**Feature details**

Enhancements include:

-   The layout of the sitemap is optimized to move away from horizontal scroll bars and carousels to vertical pick lists for area switcher.

-   Recently accessed and pinned records are easier to find – so users can be more productive on the go.

-   Commonly used commands have been moved from the bottom bar to the top corner of the screen for easy access. Less common features like settings and profile information are tucked away for users to access them when needed.

### Hybrid dialog experiences

**Description**

Some of the features that are not yet on Unified Interface can now be accessed using the hybrid experience.

**Feature details**

The following features are not yet present on Unified Interface, but these are enabled for display as legacy dialogs on Unified Interface through the hybrid experience.

-   [Advanced Find](https://docs.microsoft.com/en-us/powerapps/user/advanced-find)

-   Bulk edit

-   [Merge records](https://docs.microsoft.com/en-us/powerapps/user/merge-duplicate-records)

-   [Record sharing](https://docs.microsoft.com/en-us/powerapps/user/assign-or-share-records)

-   [Audit History](https://docs.microsoft.com/en-us/powerapps/developer/common-data-service/auditing-overview)

-   All options under Set Personal Options ()

-   Reports

<!-- I believe this won't be the case with the public preview release
## Known issues and limitations 

## **Organization database updates must be manually applied**

Organization database updates must be manually applied after you complete the version 9.1 update for all Dynamics 365 Server computers in the deployment. To apply the update, use [deployment manager](https://docs.microsoft.com/en-us/dynamics365/customerengagement/on-premises/deploy/update-an-organization) or [Power Shell](https://docs.microsoft.com/en-us/powershell/module/microsoft.crm.powershell/update-crmorganization?view=dynamics365ce-ps)**.** -->

::: moniker-end

::: moniker range="op-9-0"

This section lists new features that are available with Dynamics 365 Customer Engagement (on-premises), version 9.

> [!NOTE]
> The customer engagement apps (Dynamics 365 Sales, Dynamics 365 Customer Service, Dynamics 365 Marketing, Dynamics 365 Field Service, and Dynamics 365 Project Service Automation) already have these features. More information: [Dynamics 365 Documentation](https://docs.microsoft.com/dynamics365). 

|Feature  
|---------|  
|[Task-based experiences for mobile](/dynamics365/customer-engagement/customize/create-mobile-task-flow)   |  
|[Dynamics 365 for Field Service](/dynamics365/customer-engagement/field-service/overview)    | 
|[Enterprise Sales with the Unified Interface framework](https://docs.microsoft.com/dynamics365/customer-engagement/sales-enterprise/help-hub)   |  
|[Enterprise Sales classic web app user interface refresh](https://docs.microsoft.com/dynamics365/customer-engagement/sales-enterprise/help-hub)   |  
|[Enterprise Service with the Unified Interface framework](https://docs.microsoft.com/dynamics365/customer-engagement/customer-service/user-guide-customer-service-hub)      | 
| [Enterprise Service classic web app user interface refresh](https://docs.microsoft.com/dynamics365/customer-engagement/customer-service/help-hub)       | 
| Run on-demand workflows from apps based on the Unified Interface framework  |
| [App design enhancements](https://docs.microsoft.com/dynamics365/customerengagement/on-premises/customize/create-edit-app)   |
| [The assistant with standard cards](/dynamics365/customer-engagement/sales-enterprise/action-cards-reference)   |  
|  [Virtual entities](customize/create-edit-virtual-entities.md)  |
|  [Security enhancements: User session and access management](/dynamics365/customerengagement/on-premises/admin/user-session-management)   |

> [!NOTE]
> The offline capability in Dynamics 365 for Outlook, version 9.0 isn't available in Dynamics 365 Customer Engagement (on-premises), version 9.x. However, the offline capability in Dynamics 365 for Outlook, version 9.0 will continue to be supported in [Dataverse](/powerapps/maker/common-data-service/data-platform-intro).

::: moniker-end

[!INCLUDE[footer-include](../../includes/footer-banner.md)]