---
title: "Publish your app on AppSource (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Publish your Dynamics 365 app with Microsoft AppSource so that subscribers can find it, try it, and buy it."
ms.custom: ""
ms.date: 12/15/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 711578f8-34d0-4615-b24f-b0db41c1f963
caps.latest.revision: 30
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# Publish your app on AppSource

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

Publish your app on [Microsoft AppSource](https://appsource.microsoft.com) so that [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] Customer Engagement subscribers can find it, try it, and buy it. 

## Before publishing your app 
  
Visit [https://appsource.microsoft.com/partners](https://appsource.microsoft.com/partners), and read the **App review guidelines** to understand whether your app is a good fit for AppSource.

## Preparing your app for publishing

Preparing an app for publishing on AppSource involves a series of steps such as such as registering on the Microsoft Partner Network (MPN) and then preparing your app-related files for submission. Use the following steps to prepare your app for submission:

> [Step 1: Register for Microsoft Partner Network account](register-microsoft-partner-network.md)

> [Step 2: Create a managed solution for your app](create-solution-app-appsource.md)

> [Step 3: Create an AppSource package for your app](create-package-app-appsource.md)

> [Step 4: Store your package on Azure Storage](store-appsource-package-azure-storage.md)

## Submitting your app on Cloud Partner Portal

Once your app is ready for submission, you use the [Cloud Partner Portal](https://cloudpartner.azure.com) to submit your app to be listed on the Microsoft AppSource.

Access to the Cloud Partner Portal and related documentation is available only to Microsoft Partner Network members.

More information: [Next steps: Submit your app on Cloud Partner Portal](next-steps-submit-app-cloud-partner-portal.md)
  
 <!--If your app is a good fit, please proceed to the next step to submit your app. The specific process for this may change over time, but at the time this was written the process consists of a form where you will let us know about your app and how to contact you. After that, someone will contact you and help lead you through the process of registering your app.  
  
   
  
 When potential customers click on the listing for your app on AppSource there are different experiences they may have depending on how your app is registered. There are three submission types: *hosted*, *partner-led* and *customer-led*.  
  
-   A *hosted trial* will display a link to allow an interested customer to try your application in a separate hosted environment.  
  
-   A *partner-led trial* is essentially a lead-referral program where the AppSource site will forward information to you about a someone who is interested in your app. A partner led trial is a good choice when your app has solutions with dependencies or is not installed as a [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] solution.  
  
-   A *customer-led trial* is where the customer will have the opportunity to install your application into their [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] organization.  
  
## Certification process for customer-led trial offer  
 The customer-led trial offer has the most rigorous certification process. For a customer-led trial you will need to create a [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] Package. A [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] package is a setup package for deploying [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] solutions, data and executing install and upgrade operations on an instance of [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)]. This allows for the automation of installation tasks to support deploying an application into the customer's [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] environment. Creating [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] packages is identical to creating packages for the [!INCLUDE[pn_package_deployer_long](../includes/pn-package-deployer-long.md)] with a few additional steps. More information: [Create packages for the CRM Package Deployer](create-packages-package-deployer.md)  
  
 When submitting a [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] Package for a customer-led trial please be aware of the following:  
  
-   Your [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] Package will be tested to make sure that it only uses supported extensibility methods as documented in the [!INCLUDE [pn-sdk](../includes/pn-sdk.md)].  
  
-   With your [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] Package you will need to provide a number of test cases and use cases which will be reviewed as part of the certification process.-->  
  
### See also  
[Video: Microsoft AppSource: find the right app for your business](https://youtu.be/hpq_Y9LuIB8)

[Package and distribute extensions using solutions](package-distribute-extensions-use-solutions.md) 
