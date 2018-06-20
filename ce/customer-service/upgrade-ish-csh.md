---
title: Upgrade from Interactive Service Hub to the Customer Service Hub | Microsoft Docs
description: Understand the upgrade path from Interactive Service Hub to the Customer Service Hub application
keywords: Customer Service Hub; Interactive service hub; upgrade
author: anjgupta
applies_to: Dynamics 365 (online) 
ms.author: anjgup
manager: shellyha
ms.date: 02/20/2017
ms.topic: article
ms.service: dynamics-365-customerservice
ms.assetid: a7f5cc83-80cc-1aad-aab5-fdd52a6891fe
ms.custom: dyn365-customerservice
---

# Upgrade from Interactive Service Hub to the Customer Service Hub in Microsoft Dynamics 365 (online) version 9.0

The Interactive Service Hub (ISH), a reimagined customer service module, was introduced with Microsoft Dynamics CRM Online 2016 Update 1 and Microsoft Dynamics CRM 2016. ISH offered a web-based client and was designed to simplify daily tasks for Customer Service Representatives and Managers. Under the hood, it had completely new components and page-types, like interactive dashboards, interactive forms, and reference panel control. Though the ISH intuitive interface combined vital information in one place and allowed Customer Service Representatives to prioritize work and be more productive, there were certain limitations in extending it. The new Customer Service Hub (CSH) offers even greater flexibility and improved controls and extensibility.

## Introduction to Customer Service Hub

With Dynamics 365 (online) version 9.0, CSH offers a focused, interactive interface that is an App Module running on Unified Interface. Unified Interface is designed with a *build once deploy everywhere* philosophy and features a new Custom Control Framework, responsive UI design, RTL support; and will soon be WCAG 2.0 compliant.

Compared to ISH, Unified Interface eliminates the prolonged initial metadata download and brings greater parity with Dynamics 365 web client in terms of supported entities, controls, and extensibility. And, because it is an App Module, CSH is completely role-based and metadata-driven, allowing greater customization flexibility. It makes it easy and intuitive for System Administrators to filter forms, dashboards, and other metadata components shown to business users, so that they can deliver tailored applications.

## Versions eligible for upgrade

Organizations using Dynamics versions CRM 2016, CRM Online 2016 Update 1, and Dynamics 365 (online and on-premises) Update 2.1 are eligible to upgrade to Dynamics 365 (online) version 9.0 during the [Customer Driven Update](https://blogs.msdn.microsoft.com/crm/2018/01/12/scheduling-your-dynamics-365-organization-for-microsoft-dynamics-365-online-version-9-0-update/) schedule. Upgrading from a version earlier than CRM 2016 is not supported. Support for the Interactive Service Hub client is limited to Dynamics 365 Update 2.1.

## Preparing for the upgrade

Before you upgrade, it is important to note that once you upgrade to CSH, there is no support to roll back to ISH. Please observe these best practices before upgrading any production organization.

- Read about known issues with CSH or Unified Interface at [Dynamics 365 Customer Engagement Readme / Known Issues](../admin/readme-9.md).
- The upgrade is designed to deliver a nearly seamless experience. However, there are certain changes that require manual intervention by a System Administrator. Be sure to read the steps outlined later in this document, [Manual post-upgrade configuration for System Administrators](#post-upgrade-configurations-for-system-administrators).
- Upgrade a test or sandbox environment with your customizations and data.
- Back up your customizations and data.
- Read about the [Customer Driven Update](https://blogs.msdn.microsoft.com/crm/2018/01/12/scheduling-your-dynamics-365-organization-for-microsoft-dynamics-365-online-version-9-0-update/) process and schedule a suitable time for the upgrade.

The following sections describe some notable upgrade-specific changes, as well as general customization and user experience changes in Dynamics 365 (online) version 9.0.

## Converting Interactive experience forms to Main forms
Like Dynamics 365 web client, the CSH app on Unified Interface uses Main forms. Any existing Interactive experience forms—both out-of-the-box and custom, will be modified and converted to Main forms when you upgrade to Dynamics 365 (online) version 9.0, and will import any solution into Dynamics 365 (online) version 9.0 and later. This change does not affect functionality; the form XML will largely remain the same except for a few changes in properties, shown below.

![Converting Interactive experience forms to Main forms](media/upgrade-Convert-Interactive-experience-forms-to-Main-forms.png)

The changes to Interactive experience forms include:

- The conversion process changes the form type, and no new forms are created. The name of the form will not change
- The segment of form XML representing form behavior and customization is unaffected. This conversion will not have an adverse impact on functionality
- **Form Type** would be changed from *Main – Interactive experience to Main*
- If the managed properties of the form are set to be customizable, the **Form State** will be changed to Inactive; otherwise it will be unchanged. As Main forms are supported in Unified Interface as well as in Dynamics 365 web client, deactivation is essential to avoid unintended access in Dynamics 365 web client. This behavior is limited to customizable forms, so the upgrade does not force any form to an unrecoverable Inactive state.
- After conversion to Main forms, Interactive experience forms will be ranked lower than other Main forms in the system, to avoid disruption to Dynamics 365 web client users. System Administrators can review the order and change it to suit the business needs. See [Assign form order](../customize/assign-form-order.md) for more information. 

## Support for Interactive experience forms

Unified Interface does not use Interactive experience forms, so they will no longer be used or supported in Dynamics 365 (online) version 9.0 and later. The configuration settings specific to these forms, like the ability to create or re-order Interactive Experience forms, would also be removed.

## Entity support and deprecation of EntityMetadata.IsInteractionCentricEnabled property

With Dynamics 365 (online) version 9.0, Unified Interface supports all ISH entities and many others. Interactive Dashboards, Card Forms, Main forms and any other components like Views, Charts, etc., can be created for any entity supported in Unified Interface and used in the CSH app. The **EntityMetadata.IsInteractionCentricEnabled** property, which indicates whether an entity can be enabled for interactive experience, is removed. The corresponding property in the customization interface, *Enable for interactive experience*, has been removed, and the *EntityMetadata.IsInteractionCentricEnabled* property will be removed from the future version of Dynamics 365 SDK for Customer Engagement.

## Unified Service Desk

CSH is not supported on Internet Explorer 11 in Dynamics 365 (online) version 9.0.1. And, since Unified Service Desk uses Internet Explorer 11, it does not support the CSH app. This support will be available in an upcoming version.

## User interface improvements in Dynamics 365 (online) version 9.0

- Launch the Customer Service Hub app from your Navigation or My Apps page

  From My Apps page:

  ![Launch the Customer Service Hub app from My Apps page](media/upgrade-Launch-Customer-Service-Hub-app-from-My-Apps.png)

  From Navigation page:

  ![Launch the Customer Service Hub app from Navigation](media/upgrade-Launch-Customer-Service-Hub-app-from-Navigation.png)

- Interactive Dashboards deliver improved discoverability and reflow behavior. Read more about dashboards in the [ Customer Service Hub user guide](customer-service-hub-user-guide-dashboard.md).

- The sitemap in Unified Interface is oriented vertically, to make it easy to use on smaller devices. In addition to layout changes, CSH has better support for Sitemap customization because its dedicated sitemap can be configured in any way without affecting other apps or Dynamics 365 web client. You can read more about editing sitemaps in the [Sitemap Designer documentation](../customize/create-site-map-app.md). (Please note, this change is not specific to this upgrade.)

  ![sitemap pre and post upgrade](media/upgrade-Sitemap-pre-and-post-update.png) 

## After the upgrade

Once you’ve upgraded to Dynamics 365 (online) version 9.0, CSH will be provisioned for your org and will be updated with your customizations from ISH.

> [!NOTE]
> System Administrators and customizers must perform the[ Post-upgrade configurations](#post-upgrade-configurations-for-system-administrators) described later in this document. It is advisable to review the CSH runtime experience and compare it with ISH before the app is released to business users for consumption.

## What to expect after the upgrade


- Existing ways to launch the application will continue to work via the sitemap and bookmarked links. The sitemap link in **Settings -> Application** will continue to be called *Interactive Service Hub*; however, it will redirect to CSH.
- ISH URLs */nga/engagementhub.aspx* or */engagementhub.aspx* will redirect to the equivalent page in CSH, and all query string parameters will be supported.
- All customizations done on ISH will be preserved by ensuring that the relevant components—both out-of-the-box and custom—are included in the CSH app module. ISH forms and dashboards will be added to the app, so that the CSH experience resembles ISH. Other components like views and entity dashboards will not be added, though all such components will be part of the runtime experience.
- All entities that were enabled for ISH will be added to the CSH app definition, along with any business process flows that were part of ISH.
- Users with Customer Service Representative, Customer Service Representative Manager, and Knowledge Manager roles will have access to CSH by default. System Administrators can manage access to other roles from the My Apps page, as shown here:

  ![Manage access roles](media/upgrade-Manage-roles-from-the-My-Apps-page.png)

## Post-upgrade configurations for System Administrators

As discussed earlier, most of the Main forms would be in *Inactive* state after the upgrade. If CSH does not have an Active form for any entity, users will be given *Fallback forms* when they access an entity record. A fallback form is the default form that is available to users whose security roles do not have any forms assigned to them (read more in [Control access to forms](../customize/control-access-forms.md)). To ensure that users have a seamless experience after upgrading, System Administrators must perform certain manual tasks, as listed in the table below.

 
As Main forms are supported in Unified Interface as well as in Dynamics 365 web client, activation would make them visible in Dynamics 365 web client as well. System Administrators are advised to assign appropriate security roles to avoid unintended access. See [Assign security roles to forms](../admin/assign-security-roles-form.md).

![Post upgrade configuration for system administrators](media/upgrade-post-upgrade-configurations-for-system-administrators.png)

## Working with solutions

- **Importing a solution with ISH components from Dynamics versions CRM 2016, CRM Online 2016 Update 1, and Dynamics 365 (online and on-premises) Update 2.1 into Dynamics 365 (online) version 9.0 or later** would not reflect changes to CSH, since CSH is an App Module and doesn’t show every component in the system. The import would proceed in the usual manner, and the components added in the system would need to be added to CSH. System Administrators can edit the CSH app definition in App Designer and include the solution components. This gives System Administrators greater control over the CSH app definition. Read more about editing app definition in [App Designer](../customize/create-edit-app.md) documentation.


- **Uninstalling older solutions after upgrading to Dynamics 365 (online) version 9.0 or later** may require manual updates to the CSH app in some cases. This typically occurs when the solution contains Business Process Flows. While upgrading, all Business Process Flows in the system (and their relevant entities) get added to CSH, which creates dependencies for CSH on the solution. A solution framework dependency error will appear whenever such solutions are uninstalled.

  ![Details link in the Error](media/upgrade-details-link-error.png)

  Clicking on the error details reveals the solution components that are referenced by other components in the system. Resolving these dependencies by editing CSH and removing the referenced components should allow you to uninstall the solution. If this issue persists, it is possible that dependencies still remain and repeating this process should help in identifying them. Read more about editing app definitions in [App Designer](../customize/create-edit-app.md) documentation.


### See Also

[Overview of Customer Service and the Customer Service Hub](overview.md)

[User Guide (Customer Service Hub)](user-guide-customer-service-hub.md)

[Create or edit a model-driven app by using the app designer](../customize/create-edit-app.md)