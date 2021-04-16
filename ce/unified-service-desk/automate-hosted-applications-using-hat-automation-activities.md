---
title: "Automate hosted applications using HAT automation activities | MicrosoftDocs"
description: "Learn about the Hosted Application Toolkit (HAT) Software Factory that provides a set of workflow activities to drive automations that help you to automate hosted applications."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/23/2017
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-USD
search.audienceType: 
  - customizer
  - developer
search.app: 
  - D365CE
  - D365USD
---
# Automate hosted applications using HAT automation activities
[!INCLUDE[pn_Windows_Workflow_Foundation](../includes/pn-windows-workflow-foundation.md)] (WF) allows you to implement business rules and procedures through a unique process of designing a workflow or automation model composed of multiple elements (called *activities*) that describe the business process. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Windows Workflow Foundation](https://msdn.microsoft.com/library/dd489441\(v=vs.100\).aspx)

 In [!INCLUDE[pn_user_inteface_integration_uii](../includes/pn-user-interface-integration-uii.md)], you can use the WF workflows or automations to describe the business logic that drives the hosted applications. Automations in [!INCLUDE[pn_uii_acronym](../includes/pn-uii-acronym.md)] are WF assemblies or XAML that are executed by the [!INCLUDE[pn_uii_acronym](../includes/pn-uii-acronym.md)] Automation Manager. Automations drive hosted applications independent of their type.

 The [!INCLUDE[pn_hosted_application_toolkit_hat](../includes/pn-hosted-application-toolkit-hat.md)] Software Factory provides a set of workflow activities to drive automations that help you to automate hosted applications. The activities cover [!INCLUDE[pn_uii_acronym](../includes/pn-uii-acronym.md)] action, such as `DoAction` and `SetContext`, as well as the original WF activities to drive applications hosted via data-driven adapters (DDAs). If the automation activities provided by [!INCLUDE[pn_hat](../includes/pn-hat.md)] don’t meet your development needs, you can extend them to fit your requirements.

## In This Section
 [Use HAT automation activities](../unified-service-desk/use-hat-automation-activities.md)

 [Types of HAT automation activities](../unified-service-desk/types-of-hat-automation-activities.md)

 [Create a HAT automation](../unified-service-desk/create-hat-automation.md)

## Related Sections
 [Work with HAT Software Factory](../unified-service-desk/work-with-hat-software-factory.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]