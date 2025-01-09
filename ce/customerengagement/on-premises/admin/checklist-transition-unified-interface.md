---
title: "Unified Interface transition checklist for Dynamics 365 Sales and Service"
description: "Use this checklist to ensure you're prepared for a transition from the legacy web client to Unified Interface for Dynamics 365 Sales and Service."
ms.custom: ""
ms.reviewer: matp

ms.topic: "article"
author: "Mattp123"
ms.author: "haybass"
search.audienceType: 
  - maker
---

# Checklist for Unified Interface transition

Follow the steps in this article to ensure that you're prepared for transition to Unified Interface. Readiness for transitioning to Unified Interface will depend on whether you are aiming for basic compatibility or redesigning to take full advantage of new capabilities.

The instructions apply to the following Dynamics 365 apps:

- Dynamics 365 Sales

- Dynamics 365 Customer Service

<!-- Dynamics 365 Project Service Automation  -->

## Run the Power Apps Solution Checker on your solutions

The [Power Apps solution checker module for PowerShell](/powershell/powerapps/get-started-powerapps-checker?view=pa-ps-latest&preserve-view=true) can be used to perform a rich static analysis check on your solutions against a set of best practice rules to quickly identify problematic patterns. After the check completes, you receive a detailed report that lists the issues identified, the components and code affected, and links to documentation that describes how to resolve each issue.

The solution checker analyzes these solution components:

-   Microsoft Dataverse plug-ins

-   Dataverse custom workflow activities

-   Dataverse web resources (HTML and JavaScript)

-   Dataverse configurations, such as SDK message steps

**Things to consider** 

-   Potential issues detected by the solution checker may not exclusively apply to Unified Interface. Be mindful of what will impact transition when reviewing results.

-   As in any automated code review, some issues can be false alarms and don’t mean that your application won’t run in Unified Interface.

-   Logic executed on the server side, such as plug-ins, custom workflow activities, and the configuration of SDK message steps shouldn’t impact the user interface and hence shouldn’t impact the transition to Unified Interface.

-   Even if the all issues aren’t directly associated with Unified Interface, we recommend that you spend time reviewing them to improve the overall health of your application.

For more information about Power Apps Checker, go to [Power Apps solution checker](/powerapps/maker/data-platform/use-powerapps-checker).

## Check third-party solutions compatibility with Unified Interface

Prior to transitioning to Unified Interface, it’s important that you make sure that any third-party solution that you use in your application works in Unified Interface.

-   If you have installed ISV (Independent Software Vendor) add-ins through [AppSource](https://appsource.microsoft.com), check if upgrades are available. <!-- in the [Power Platform Admin center](https://admin.powerplatform.microsoft.com) by selecting **Environments** > [environment_name] > **Manage Solutions**. -->

-   If you are using third-party solutions that were provided outside of AppSource, contact the provider (Partner or ISV) to get a new version that updates the apps to Unified Interface.

> [!NOTE]
> If there are no plans for your third-party solutions to be updated to a version compatible with Unified Interface, it is important to identify a path to replace these features with either native platform capabilities or alternative solutions that are compatible.

## Identify replacements for deprecated features

Based on the outputs of the **Power Apps Solution Checker** and the information contained in [Important changes (deprecations) coming](/power-platform/important-changes-coming) on deprecated client APIs and features, you should have a good understanding of the customizations and features that either need to be corrected or replaced in your Unified Interface project.

Here are some of the most common areas needing attention:

-   **Client API**: Recommended replacement methods are documented [here](/power-platform/important-changes-coming#some-client-apis-are-deprecated).

-   **Process dialogs**: Replace dialogs with business process flows. More information: [Business process flows overview](../customize/business-process-flows-overview.md)

-   **Task flows**: Consider using business process flows to replace task flows. More information: [Business process flows overview](../customize/business-process-flows-overview.md)

-   **Dynamics 365 for Outlook (COM Add-in)**: Consider replacing the [deprecated](/power-platform/important-changes-coming#dynamic-365-for-outlook-is-deprecated) Dynamics 365 for Outlook (COM Add-in) with the modern, lightweight [Dynamics 365 App for Outlook](/dynamics365/outlook-app/overview).

- **Dynamics 365 Customer Service**:
    -   Service scheduling: Consider using [Universal Resource Scheduling](/dynamics365/common-scheduler/schedule-anything-with-universal-resource-scheduling) instead of legacy service scheduling.
    - [Deprecated knowledge management tables](/previous-versions/dynamicscrm-2016/administering-dynamics-365/dn265924(v=crm.8)#some-knowledge-management-entities-are-deprecated): See this topic to work with the latest knowledge management tables: [Work with knowledge articles](/dynamics365/customer-service/work-knowledge-articles).
    - [Deprecated contract tables](/power-platform/important-changes-coming#contracts-contract-line-items-and-contract-templates-entities-are-deprecated): See this topic to migrate to entitlements: [Contracts to entitlements migration strategy](/dynamics365/customer-service/contract-to-entitlement-migration). 

## Test your application in Unified Interface

One of the easiest ways to test your application in Unified Interface is to turn on the **Use the Unified Interface only** option in the **System Settings** on a copy of your production organization. After Unified Interface is enabled, you should be able to access your application using the **Dynamics 365 – Custom** app and test the use cases relevant to your context.

### Test your business and technical scenarios

Focus on what could potentially be impacted:

-   **Business processes** such as business process flows, business rules

-   **Customizations** such as forms, views, command bar buttons, web resources, and charts

> [!TIP]
> Challenge the user experience at the same time as doing these early tests: is everything meaningful and adding value? What should be removed/improved/added? For example, are the current list of views relevant? Or are my users forced to create their own views?

### Identify gaps

-   Any potential regressions that weren’t already spotted by the <!-- solution checker and -->third-party solution updates.

-   User pain points that could lead to optimizations (such as new form rendering by reorganizing sections and tabs) or specific training.

-   Any other dependencies on the legacy web client such as the use of the legacy Outlook COM Add-in instead of the lightweight Dynamics 365 App for Outlook.

## Define your app strategy and settings

Instead of using the **Dynamics 365 – Custom** app, which isn't optimized for Unified Interface but rather runs in compatibility mode, we suggest that you leverage either first-party apps made by Microsoft or create your owns apps.

The Dynamics 365 apps that have already been optimized for Unified Interface are the following:

- Dynamics 365 Sales Hub

- Dynamics 365 Customer Service Hub

### What are Dynamics 365 custom business apps?

**Dynamics 365 custom business apps** are a type of app you can create using the app designer that helps you provide tailored experience to your users depending on their role in the organization. For example, a salesperson can have a completely different experience than a customer service representative through different Dynamics 365 custom business apps even though they are using data from the same environment. Multiple Dynamics 365 custom business apps can be created in a Dynamics 365 Customer Engagement organization. More information: [About Unified Interface in Dynamics 365 Customer Engagement (on-premises)](about-unified-interface.md) and [Create or edit an app by using the app designer](../customize/create-edit-app.md)

The Dynamics 365 apps listed earlier are examples of Dynamics 365 business apps.

### How to define your app strategy?

Ask yourself the following questions:

1.  Can you split your users into multiple groups with specific business processes?

2.  Do these groups have different requirements for what they should see and do?

3.  Are you finding it difficult to have different user experiences without using apps?

If you have answered "Yes" to these questions then consider having multiple apps.

This is the opportunity to rethink the experience in the context of business processes for each group or role.

### Out-of-the-box apps (for example, Sales Hub) or customized apps?

-   It depends how tailored you’d like the experience to be.

-   If you have few customizations or want to benefit from first-party app updates, then consider using native apps.

-   If you want more control over the experience and updates of standard apps and customizations, then create your own app.

### Once you have defined your app strategy, what should be the next steps?

1.  Customize your target apps and only include what users will need. Less is better. Reduce the clutter to enable users to work efficiently.

2.  Dissociate security roles from unused apps.

## Review your apps settings and user experience fundamentals

### App settings

-   Include all required entities in your app, even if they are not in the sitemap.  
    
-   Provide the **Read** privilege for **Model-driven app** in the **Customization** tab in the **Security Role** dialog box.

-   Enable the **Enable only the Unified Interface** mode if your users don’t need to use the legacy web client. When **Enable only the Unified Interface**is on, all legacy Dynamics 365 Customer Engagement apps such as Dynamics 365 - custom, open in Unified Interface.  Notice that system administrators can still access administration features by selecting **Settings** > **Advanced Settings**.
   :::image type="content" source="media/use-only-unified.png" alt-text="Enable only the Unified Interface system setting.":::

-   Create a simpler app URL. For example: https://\*.crm.contoso.com/apps/MyApp*

-   Try to limit the number of apps a user can access.  
    
    > [!TIP]
    > When **Enable only the Unified Interface** is set to **Yes** and when users only have access to one app, they are automatically redirected to the app when they access the root URL (https://\*.crm.contoso.com)*

### Optimize navigation (sitemap)

-   Define one main **area** with the most used **sub-areas** (dashboard, entities, etc.) organized in **groups**.

-   Create one or more additional areas for less-used features (configuration, settings, etc.). The idea is to help your users focus only on what’s important to do their work.

### Update icons

-   Transitioning to Unified Interface is a good opportunity to refresh icons.

-   We recommend **SVG** format as they render well regardless of screen resolution.

    > [!TIP]
    > Example of SVG icon format:  
    > Width​ and height: 16 px; Padding: 0 px; Background: transparent; Icon color: \#FF000000  
    > To avoid rendering issues, open the SVG file with an editor (for example, Notepad) and remove fill="\#000000"

## Enrich your app with Unified Interface exclusive features

-   Create a **Welcome Page** that users see when they access each of your app. This is a great opportunity to guide users in their first steps.

-   Use existing **Custom Controls** to improve the usability of most column types, especially on mobile. For example, replace a 0 to 5 column rating with stars, replace a view of appointments with a calendar view, replace a sub-grid view with card forms. More information: [Use custom controls for data visualizations](../customize/use-custom-controls-data-visualizations.md)

-   Leverage **Reference Panels** on forms to bundle multiple views, quick views, and KB search feature in a single place. More information: [Section properties](../customize/section-properties-legacy.md)

<!--   Leverage the [Power Apps Component Framework](https://learn.microsoft.com/powerapps/developer/component-framework/overview) to add even more custom controls. You can get some from the community or from partners and ISVs. 

-   Embed [canvas apps](https://learn.microsoft.com/powerapps/maker/canvas-apps/getting-started) in your forms to easily extend your application. No-code or low-code extension of your app without the need to develop custom HTML/JS web resources. 

-   Embed **Power BI** reports and tiles in forms: consolidate data across multiple systems in a single view. -->

-  Consider leveraging **Interactive Dashboards** to configure a one-stop workplace that allows global filtering across dashboard components. More information: [Configure interactive experience dashboards](../customize/configure-interactive-dashboards.md)

- Configure **Custom Help Panes and Guided Tasks** so that users quickly get help and guidance. More information: [Create guided help for your Unified Interface app](/powerapps/maker/data-platform/create-custom-help-pages)

## Conduct user acceptance testing

It is very important that your applications, business scenarios, and technical scenarios are tested by your business users in Unified Interface in conditions that are similar to your production environment. These users can act as business champions to help scale knowledge across the business.

Testing will help identify remaining items to be addressed before transitioning all of your users to Unified Interface.

## Update user training materials

Conduct a review of your existing and planned training materials to ensure they have the latest screenshots and reflect any changes you have made to the user flow.

<!--## Check your transition date

On December 1, 2020, [the legacy web client will no longer be available](https://learn.microsoft.com/power-platform/important-changes-coming#legacy-web-client-is-deprecated). Be sure to migrate well in advance to ensure there’s time for any issues to be addressed. -->

### See also
[About Unified Interface in Dynamics 365 Customer Engagement (on-premises)](about-unified-interface.md) <br />
[Approaching a user experience and Unified Interface transition](approaching-unified-interface.md)
