---
title: "Add custom validation rules to Dynamics 365 for Marketing | Microsoft Docs "
description: "How to add more rules for validating records before going live in Dynamics 365 for Marketing"
keywords: "customize;workflow;business process;validation"
ms.date: 10/01/2018
ms.service: 
  - dynamics-365-marketing
ms.custom: 
  - dyn365-cust
  - dyn365-marketing
ms.topic: article
applies_to: 
  - Dynamics 365 (online)
  - Dynamics 365 Version 9.x
ms.assetid: d8fb5ab9-654d-4bf0-9bdd-dc10eff5082b
author: kamaybac
ms.author: kamaybac
manager: shellyha
ms.reviewer:
topic-status: Drafting
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Add custom validation rules

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

A standard feature of [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]
 is its ability to check published content for errors before going live. You've probably seen this feature at work when designing email messages, customer journeys, forms, lead-scoring models, and other features that use the content designer interface. The validation (**Check for Errors**) feature works by checking for missing content (such as a required setting or a subscription-center link in a marketing email) and errors (such as illogical settings, syntax errors, or messages that won't compile). After the error check, [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] displays the results right on the page, including error messages that should help the user solve the issue.

![The check-for-errors button and notifications](media/email-validation-result.png "The Check for Errors button and notifications")

The validation feature works by implementing a validation pipeline with a series of rules that the content must pass. For each violation, an error or warning is added to the response and the content won't be allowed to go live. Customizers can extend the pipeline by adding a custom validation stage that implements the required custom checks. You might use this capability to, for example, scrub email text for obscenities or to ensure that a required disclaimer is always present. Custom validation rules require custom coding to create the actual validation logic. Your code must parse the incoming text and generate messages as needed.

## Add a custom action to a validation pipeline

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

## Test the customized validation pipeline

To test your validation pipeline, do the following:

1. Open a [!include[](../includes/tn-google-chrome.md)] console, and then execute the following code (where *&lt;YourDomain&gt;* is the domain where your system is running):  

    `$.ajax({type:"POST", url:"http://<YourDomain>/StarterPortal/api/data/v8.2/new_ValidationPipeline", data: JSON.stringify({ValidationContext: "val-ctx"}), contentType:"application/json", dataType:"json"})`

    ![Google Chrome console](media/custom-validation-test1.png "Google Chrome console")

2. The results will be visible on the **Network** tab.

    ![Google Chrome Network tab](media/custom-validation-test2.png "Google Chrome Network tab")
