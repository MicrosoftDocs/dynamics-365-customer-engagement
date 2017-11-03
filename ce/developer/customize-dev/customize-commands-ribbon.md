---
title: "Customize commands and the ribbon (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Dynamics 365 Customer Engagement displays commands in different ways depending on the entity and the client. In most places in the web application you will see a command bar instead of a ribbon. Dynamics 365 for tablets also uses data defined as ribbons to control what commands are available using a command bar that is optimized for touch. "
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
helpviewer_keywords: 
  - "ribbon"
  - "customize, ribbon"
ms.assetid: c688a24a-ef2d-4c0b-951b-e6db22382686
caps.latest.revision: 38
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Customize commands and the ribbon

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] Customer Engagement displays commands in different ways depending on the entity and the client. In most places in the web application you will see a *command bar* instead of a ribbon. [!INCLUDE[pn_moca_short](../../includes/pn-moca-short.md)] also uses data defined as ribbons to control what commands are available using a command bar that is optimized for touch.  
  
 The command bar provides better performance. The ribbon is still displayed in the web application for certain entity forms and it is still used for list views in [!INCLUDE[pn_crm_2016_outlook](../../includes/pn-crm-2016-outlook.md)].  
  
 Both the command bar and the ribbon use the same underlying XML data to define what commands to display, when the commands are enabled, and what the commands do.  
  
 The topics in this section introduce you to key concepts that you must understand, and common tasks you perform when you customize the command bar or the ribbon.  
  
> [!NOTE]
>  Because the underlying XML schema was designed to display commands as ribbons, the term *ribbon* will continue to be used in the documentation.  
  
 The SDK describes the process of editing the ribbon by editing the customization.xml file directly. Several people have created ribbon editors that provide a user interface to make editing the ribbon easier. Currently the following projects are available on [!INCLUDE[pn_codeplex](../../includes/pn-codeplex.md)] and other locations:  
  
-   [Ribbon Workbench](http://www.develop1.net/public/rwb/ribbonworkbench.aspx)  
  
-   [MS CRM 2011 : Pragma Toolkit : Ribbon, Site Map Editor](http://pragmatoolkit.codeplex.com/)  
  
-   [CRM 2011 Visual Ribbon Editor](http://crmvisualribbonedit.codeplex.com/)  
  
 To obtain support or help to use these programs, contact the program publisher.  
  
## In This Section  
 [Ribbons Available in Microsoft Dynamics 365](ribbons-available-microsoft-dynamics-365.md)  
  
 [Export Ribbon Definitions](export-ribbon-definitions.md)  
  
 [Exporting, Preparing to Edit, and Importing the Ribbon](export-prepare-edit-import-ribbon.md)  
  
 [Use Localized Labels with Ribbons](use-localized-labels-ribbons.md)  
  
 [Define Ribbon Commands](define-ribbon-commands.md)  
  
 [Define Ribbon Enable Rules](define-ribbon-enable-rules.md)  
  
 [Define Ribbon Display Rules](define-ribbon-display-rules.md)  
  
 [Define Ribbon Actions](define-ribbon-actions.md)  
  
 [Pass Microsoft Dynamics 365 data from a page as a parameter to Ribbon Actions](pass-dynamics-365-data-page-parameter-ribbon-actions.md)  
  
 [Define Custom Actions to Modify the Ribbon](define-custom-actions-modify-ribbon.md)  
  
 [Define how Ribbon Elements are Re-sized Based on the Space Available](define-scaling-ribbon-elements.md)  
  
 [Define Ribbon Tab Display Rules](define-ribbon-tab-display-rules.md)  
  
 [Passing Parameters to a URL By Using the Ribbon](pass-parameters-url-by-using-ribbon.md)  
  
 [Sample: Export Ribbon Definitions](sample-export-ribbon-definitions.md)  
  
  
 [Ribbon Core Schema](ribbon-core-schema.md)  
  
 [Ribbon Types Schema](ribbon-types-schema.md)  
  
 [Ribbon WSS Schema](ribbon-wss-schema.md)  
  
## Related Sections  
 [Extend the metadata model](../org-service/use-organization-service-metadata.md)  
  
 [Customize visualizations and dashboards](customize-visualizations-dashboards.md)  
  
 [Customize Entity Views](customize-entity-views.md)  
  
 [Customize global option sets](../org-service/customize-global-option-sets.md)  
  
 [Service Calendar Appearance Configuration for Microsoft Dynamics 365](service-calendar-appearance-configuration.md)  
  
 [Publish customizations](publish-customizations.md)  
  
 [When to edit the customizations file](when-edit-customization-file.md)  
  
 [Customize Microsoft Dynamics 365 applications](customize-applications.md)  
  
 [Change Application Navigation using the SiteMap](../developer/customize-dev/change-application-navigation-using-sitemap.md)  
  
 [Customize Forms in Microsoft Dynamics 365](customize-entity-forms.md)  
  
 [Web Resources for Microsoft Dynamics 365](../web-resources.md)  
  
 [Client scripting in Customer Engagement using JavaScript](../clientapi/client-scripting.md)
