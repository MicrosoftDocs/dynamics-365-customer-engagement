---
title: "Customize Dynamics 365 for Marketing | Microsoft Docs "
description: "How to customize lists, forms, workflows, business processes, validations, and more in Dynamics 365 for Marketing"
keywords: "customize;workflow;business process;validation"
ms.date: 12/15/2017
ms.service: crm-online
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: a615251f-ce0e-45cf-8e73-3dc74657982a
author: kamaybac
ms.author: kamaybac
manager: sakudes
ms.reviewer: renwe
topic-status: Drafting
---

# Customize [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

## Customize [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)]

[!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] is built on the standard [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] infrastructure, which provides rich possibilities for customization without coding. Customizers can add new fields to existing entities, add or hide fields in list or form views, design custom business processes and workflows, and much more—all while working in their web browser. Other types of customization include installing custom solutions from [!INCLUDE[pn-microsoft-appsource](../includes/pn-microsoft-appsource.md)], such as a third-party SMS solution for [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)]. The system also provides APIs that enable developers to write code that implements even more advanced custom functionality and third-party integration.

The techniques for customizing the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] application are like those for customizing other [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] Customer Engagement applications—especially [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)]. You can make many of the most common types of customizations while working directly in the **Settings** work area of [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)], but even more types of customization settings are available in the [!include[](../includes/pn-custom-app-module.md)] app.

The [!include[pn-custom-app-module](../includes/pn-custom-app-module.md)] app is included with [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]. It combines features from many of the various [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] apps you have licensed into a single navigation structure (but most [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] end-user features aren’t included here). The custom app operates on the same database as [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)], so settings made in the custom app (including for customization, user administration, events, LinkedIn Lead Gen, [!INCLUDE[pn-voice-of-the-customer](../includes/pn-voice-of-the-customer.md)], and more) can affect the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] app.

To go to the customization settings in [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)], go to the **Settings** work area, choose **Advanced Settings**, and then work in the **Customization** section, where you can edit views and business and process flows. To go to the custom app, which provides access to these customization settings and more, choose **[!INCLUDE[pn-custom-app-module](../includes/pn-custom-app-module.md)]** from the app-selector menu, and then go to **Settings** > **Customization**. The following image shows how to use the app-selector menu to switch between the Marketing and custom apps.

![The app-selector menu](media/nav-apps-custom-ill.png "The app-selector menu")

For complete details about how to customize [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)], see the [Customization Guide for Dynamics 365 Customer Engagement](../customize/overview.md). That guide describes the interface as you see it in the [!include[](../includes/pn-custom-app-module.md)] app, but the customization features that are also provided in the **Settings** work area of [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] implement similar concepts, operate on the same database, and work similarly. For details about customizations that apply only to the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] app (but not other [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] apps), see the other sections in this topic.

For more information about writing code and developing for [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)], see the [Developer Guide for Dynamics 365 Customer Engagement](../developer/developer-guide.md).

## Add custom validation rules

A standard feature of [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]
 is its ability to check published content for errors before going live. You've probably seen this feature at work when designing email messages, customer journeys, forms, lead-scoring models, and other features that use the content designer interface. The validation (**Check for Errors**) feature works by checking for missing content (such as a required setting or a subscription-center link in a marketing email) and errors (such as illogical settings, syntax errors, or messages that won't compile). After the error check, [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] displays the results right on the page, including error messages that should help the user solve the issue.

![The check-for-errors button and notifications](media/email-validation-result.png "The Check for Errors button and notifications")

The validation feature works by implementing a validation pipeline with a series of rules that the content must pass. For each violation, an error or warning is added to the response and the content won't be allowed to go live. Customizers can extend the pipeline by adding a custom validation stage that implements the required custom checks. You might use this capability to, for example, scrub email text for obscenities or to ensure that a required disclaimer is always present. Custom validation rules require custom coding to create the actual validation logic. Your code must parse the incoming text and generate messages as needed.

### Add a custom action to a validation pipeline

Here's an example for how to add a custom validation step to a pipeline.

1. Each custom action must accept the results of the previous validation action from the **ValidationContext**, and set the cumulative results to the **ValidationResults** output variable. In the following screenshot, **ValidationPipeline** is the envelope custom action, which holds the entire pipeline. The child actions are similar, using the same interface, outputs, and registration.  
    ![Validation pipeline actions](media/custom-validation-actions.png "Validation pipeline actions")

    Note that after adding a new validation step to the pipeline, you must update the **SetResult** step of the **ValidationPipeline** action to take results from the previously called custom action—in the previous step, this is **Validator2**.

1. Arrange the stages in the validation pipeline as indicated in the following screenshot.  
    ![Validation pipeline stages](media/custom-validation-stages.png "Validation pipeline stages")

1. Set up the **Validator1** step as follows:  
    ![The Validator1 step](media/custom-validation-Validator1.png "The Validator1 step")

1. Set up the **Validator2** step as follows:  
    ![The Validator2 step](media/custom-validation-Validator2.png "The Validator2 step")

1. Set up the **SetResult** step as follows:  
    ![The SetResult step](media/custom-validation-SetResult.png "The SetResult step")

1. Set the custom action for **Validator1** as follows:  
    ![Custom action for Validator1](media/custom-validation-Validator1-action.png "Custom action for Validator1")

1. Set the plugin step for **Validator1** as follows:  
    ![Plugin step for Validator1](media/custom-validation-Validator1-plugin.png "Plugin step for Validator1")

1. Set the custom action for **Validator2** as follows:  
    ![Custom action for Validator2](media/custom-validation-Validator2-action.png "Custom action for Validator2")

1. Set the plugin step for **Validator2** as follows:  
    ![Plugin step for Validator2](media/custom-validation-Validator2-plugin.png "Plugin step for Validator2")

### Test the customized validation pipeline

To test your validation pipeline, do the following:
[/]: # (In step 1, "execute code such as" implies the user has several examples to choose from. If this sample code includes a placeholder that the user needs to replace with a specific value, you'll want to describe it that way. If the code will work as written, "execute the following code" is a better way to word it.)

1. Open a [!include[](../includes/tn-google-chrome.md)] console, and then execute the following code:  
**$.ajax({type:&quot;POST&quot;, url:&quot;http://10.166.153.50/StarterPortal/api/data/v8.2/new\_ValidationPipeline&quot;, data: JSON.stringify({ValidationContext: &quot;val-ctx&quot;}), contentType:&quot;application/json&quot;, dataType:&quot;json&quot;})**  
    ![Google Chrome console](media/custom-validation-test1.png "Google Chrome console")

1. The results will be visible on the **Network** tab.  
    ![Google Chrome Network tab](media/custom-validation-test2.png "Google Chrome Network tab")
