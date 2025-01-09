---
title: Set up entitlements quickly with templates
description: See how to set up entitlements quickly with templates in Dynamics 365 Customer Service.
ms.date: 06/21/2024
ms.topic: article
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
search.audienceType: 
  - admin
  - customizer
  - enduser
ms.custom: 
  - dyn365-customerservice
---

# Use entitlement templates to set up entitlements

Quickly create other entitlements prefilled with the basic information like the start and end date, service level agreement (SLA), allocation type, and total term by using an entitlement template in Dynamics 365 Customer Service. For example, create a template for a standard entitlement, and then apply this template for every standard customer in your organization.  

> [!NOTE]
> With the latest release of Dynamics 365 Customer Service app, entitlement templates in service terms are available in the Customer Service admin center app. We recommend that you create and manage entitlement templates using the new experience.

## Create an entitlement template  

You can create an entitlement template in the Customer Service admin center app.
  
1. [!INCLUDE[proc_permissions_custsvcmgr_sysadmin_and_customizer](../../includes/proc-permissions-custsvcmgr-sysadmin-and-customizer.md)]  
  
    #### Check your security role  
  
   - [!INCLUDE[proc_follow_steps_in_link](../../includes/proc-follow-steps-in-link.md)]  
  
   - [!INCLUDE[proc_dont_have_correct_permissions](../../includes/proc-dont-have-correct-permissions.md)]  

1. In the site map of Customer Service admin center, select **Service terms** in **Operations**. The **Service Terms** page appears.

1. In the **Entitlement Templates** section, select **Manage**. The **All Entitlement Templates** view is displayed. You can switch between various system views using the drop-down list.  

    > [!NOTE]
    > In the Customer Service app, [!INCLUDE[proc_settings_service_management](../../includes/proc-settings-service-management.md)] and select **Entitlement Templates**.
  
1. To create a new entitlement template, select **New** in the entitlement template search box.  
  
1. Add or edit information in the text boxes.  
  
   - **Entitlement Template Name**: Enter a name for the entitlement template.
  
   - **Start Date**: Select the date from when the entitlement will be valid.  
  
   - **End Date**: Select the date until when the entitlement will be valid.  
  
   - **Restrict based on entitlement terms**: To restrict creating case when the entitlement term is over, select Yes. Otherwise, select **No**.  
  
   - **SLA**: Select an SLA record to associate the service levels or key performance indicators for the support you are providing with this entitlement.  
  
     Under **Entitlement Terms**, specify the term details for the entitlement: 
  
     - **Allocation Type**: Select whether the entitlement is for number of hours or number of cases.  
  
     - **Decrease Remaining On**: Select whether to decrease the remaining term on case creation or resolution.  
  
     - **Total Term**: Specify the total amount of support the customer is entitled to with respect to the allocation type. For example, if the allocation type is number of cases and you specify 100 in Total term, then the customer is entitled to support up to 100 cases.  
  
6. Select **Save**. 
  
### Add entitlement channels

 Use the **Entitlement Channels** section to define the channels your customers are entitled to, and track the customer support term for each channel separately. For example, to use phone and email as support channels, and restrict them to 80 and 20 hours respectively, create an entitlement channel for each of them.  
  
> [!NOTE]
>  You must save the template record before you can add entitlement channels to the template.  
  
1.  In the **Entitlement Channel** section, select **...** and select **Add New Entitlement Template Channel**.  
  
2.  Specify the total terms that you want to allot to the particular channel.  
  
     The remaining term is auto-calculated and shows the total number of hours or cases remaining for the customer’s entitlement.  
  
### Associate a product with the entitlement template  
 If you want the entitlement template to be applicable to specific products for an individual customer, associate a product to the template.  
  
1. In the **Search for records** box, type the first few letters of the name of the product that you want to associate with the template.   
2. While in the template record, in the **Products** section, select **...** and select **Add Existing Product**. 

> [!NOTE]
> In the Customer Service app, you can also select to open the template form in the **Form Editor** in case you want to add additional sections to the form.
  
### Related information

 [Create an entitlement to define the support terms for a customer](create-entitlement-define-support-terms-customer.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
