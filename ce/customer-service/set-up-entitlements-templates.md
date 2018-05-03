---
title: Set up entitlements quickly with templates (Dynamics 365 for Customer Service) | MicrosoftDocs
description: See how to set up entitlements quickly with templates in Dynamics 365 for Customer Service
keywords: Set up entitlements with templates; Dynamics 365; Customer Service
author: anjgupta
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.author: anjgup
manager: sakudes
ms.date: 06/01/2018
ms.topic: article
ms.service: crm-online
ms.assetid: dadea8f7-c931-4cdc-8815-32f8c0f89b51
---

# Set up entitlements quickly with templates

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Quickly create other entitlements prefilled with the basic information like the start and end date, service level agreement (SLA), allocation type, and total term by using an entitlement template in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)]. For example, create a template for a standard entitlement, and then apply this template for every standard customer in your organization.  

  
## Create an entitlement template  
  
1. [!INCLUDE[proc_permissions_custsvcmgr_sysadmin_and_customizer](../includes/proc-permissions-custsvcmgr-sysadmin-and-customizer.md)]  
  
    #### Check your security role  
  
    - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  
  
    - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
2. In the Customer Service Hub sitemap, go to **Service Management** >   **Entitlement Templates**.  
   
    - The **All Entitlement Templates** view is displayed. You can switch between multiple views using the drop-down. 
    - Select **Show Chart** in the command bar to see the chart view. <br>
  
4.  To create a new entitlement template, select **New**.  
  
     -OR-  
  
     To edit an entitlement template, in the list of records, select the template, and on the command bar, choose **Edit**.  
  
5.  Type or modify information in the text boxes.  
  
     Hovertips provide hints about what to enter.  

    In the **Information** section:
  
    - **Entitlement Template Name**  
  
    - **Start Date**. Select the date from which the entitlement will be valid.  
  
    - **End Date**. Select the date until which the entitlement will be valid.  
  
    - **Restrict based on entitlement terms**. To restrict creating case when the entitlement term is over, select Yes. Otherwise, Select **No**.  
  
    - **SLA**. Select an SLA record to associate the service levels or key performance indicators for the support you are providing with this entitlement.  
  
     Under **Entitlement Terms**, specify the term details for the entitlement: 
  
    - **Allocation Type**. Select whether the entitlement is for number of hours or number of cases.  
  
    - **Decrease Remaining On**. Select whether to decrease the remaining term on case creation or resolution.  
  
    - **Total Term**. Specify the total amount of support the customer is entitled for with respect to the allocation type. For example, if the allocation type is number of cases and you specify 100 in Total term, then the customer is entitled for support up to 100 cases.  
  
6. [!INCLUDE[proc_click_or_tap_save](../includes/proc-click-or-tap-save.md)]  
  
### Add entitlement channels  
 Use the **Entitlement Channels** section to define the channels your customers are entitled to, and track the customer support term for each channel separately. For example, to use phone and email as support channels, and restrict them to 80 and 20 hours respectively, create an entitlement channel for each of them.  
  
> [!NOTE]
>  You must save the template record before you can add entitlement channels to the template.  
  
1.  In the **Entitlement Channel** section, choose **+**.  
  
2.  Specify the total terms that you want to allot to the particular channel.  
  
     The remaining term is auto-calculated and shows the total number of hours or cases remaining for the customer’s entitlement.  
  
### Associate a product with the entitlement template  
 If you want the entitlement template to be applicable to specific products for an individual customer, associate a product to the template.  
  
1.  While in the template record, in the **Products** section, choose **+**.  
2.  In the **search** box, type the first few letters of the name of the product that you want to associate with the template.  
  
     If a product isn’t available, choose **New** to create a new product record.  

> [!NOTE]
> You can also choose to open the template form in the **Form Editor** in case you want to add additional sections to the form.
  
### See also  
 [Create an entitlement to define the support terms for a customer](create-entitlement-define-support-terms-customer.md)
