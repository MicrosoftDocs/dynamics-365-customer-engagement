---
title: Create entitlements to define the support terms for a customer (Dynamics 365 for Customer Service) | MicrosoftDocs
description: See how to create entitlements to define the support terms for a customer in Dynamics 365 for Customer Service
keywords: Create an entitlement; Dynamics 365; Customer Service
author: anjgupta
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.author: anjgup
manager: sakudes
ms.date: 06/01/2018
ms.topic: article
ms.service: crm-online
ms.assetid: 9384cb0a-64ec-424d-bf73-7010997c4d4e
---

# Create entitlements to define the support terms for a customer

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Define what kind of support your customers are eligible for by creating entitlements in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)]. With entitlements, you specify the support term based on number of hours or number of cases. The customer’s support level can vary based on the product or service that the customer has purchased. Customers who’ve purchased different products can be entitled to different support levels. This information helps the customer support agents verify what the customers are eligible for and create cases for them. accordingly  
  
## Create an entitlement  
  
1. [!INCLUDE[proc_permissions_custsvcmgr_sysadmin_and_customizer](../includes/proc-permissions-custsvcmgr-sysadmin-and-customizer.md)]  
  
    #### Check your security role  
  
    - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  
  
    - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
2.  In the Customer Service Hub sitemap, go to **Service Management** > **Entitlements**.
    
    - The **All Entitlements** view is displayed. You can switch between multiple views using the drop-down. 
    - Select **Show Chart** in the command bar to see the chart view. <br>
  
3. To create a new entitlement from scratch, select **New** > **Blank Entitlement**.   
   
   To create a new entitlement from a template, select **New** > **From Template**. In the **Select Template** dialog box, click the entitlement template, and click **Select**. For more information about entitlement templates, see [Set up entitlements quickly with templates](set-up-entitlements-templates.md).
  
4. [!INCLUDE[proc_handy_infotips](../includes/proc-handy-infotips.md)]

    Under the **Information** section, specify the details for the entitlement:
  
    - **Name**. Give the entitlement a meaningful name.  
  
    - **Primary Customer**. Choose the customer you’re creating this entitlement for.  
  
    - **Start Date**. Choose the date from which the customer will be entitled for support.  
  
    - **End Date**. Choose the date after which the customer will no longer be entitled for support.  
  
    - **Restrict based on entitlement terms**. To make sure no cases are created when the entitlement term is over, click **Yes**. When you choose **Yes**, a customer service agent won’t be able to create a case when **Remaining Terms** is fewer than zero OR when the term remaining for a channel is less than zero.  
  
    - **SLA**. Choose a service level agreement (SLA) record to associate the service levels or key performance indicators for the support you’re providing with this entitlement. 
 
    - **Owner**. Provide the owner information. You can also use lookup to search for owner.

    - **Description**. Provide a description for the entitlement.

    - **Is Default**. Select the box if you want to make this entitlement as the default entitlement.

  
    Under **Entitlement Terms** section, specify the term details for the entitlement:  
  
    - **Allocation Type**. Choose whether the entitlement is for number of hours or number of cases.  
  
    - **Decrease Remaining On**. Choose whether to decrease the remaining term on case creation or resolution.  
  
         If you decrease the remaining term based on case creation:  
  
        -   Creating or updating a case with the associated entitlement decreases entitlement terms  
  
        -   Canceling a case with the associated entitlement increases entitlement terms  
  
        -   Reactivating a canceled case with the associated entitlement decreases the entitlement terms  
  
         If you decrease the remaining term based on case resolution:  
  
        -   Resolving a case with the associated entitlement decreases the entitlement terms  
  
        -   Reactivating a resolved case with the associated entitlement increases the entitlement terms.  
  
    - **Total Term**. Specify the total amount of support the customer is entitled for with respect to the allocation type. For example, if the allocation type is number of cases and you specify 100 in **Total Term**, the customer is entitled for support up to 100 cases.  
  
    -  **Remaining Terms** shows the total number of hours or cases remaining for the customer’s entitlement. The value decrements every time a case is created or resolved (depending on what you select in **Decrease Remaining On**) against the entitlement.  
  
6. [!INCLUDE[proc_click_or_tap_save](../includes/proc-click-or-tap-save.md)]  
  
### Add an entitlement channel term  
 The **Entitlement Channel** section specifies the support channel through which the customer can reach the organization and seek support.  
  
 Use this section to define the channels your customers are entitled to, and track the customer support term for each channel. For example, you can add phone and email as the channels through which you’ll offer support. If you want to restrict support through the phone channel to 80 hours and email to 20 hours, create individual entitlement channel records and add their total terms.  
  
> [!NOTE]
>  You must save the entitlement record before you can add entitlement channels to an entitlement.  
  
1.  In the **Entitlement Channel** section, click **+**.  
  
2.  Specify the total terms that you want to allot to the particular channel.  
  
     The remaining term is auto-calculated and shows the total number of hours or cases remaining for the customer’s entitlement.  
  
### Associate a product with the entitlement  
 If you want the entitlement to apply to a specific product for a customer, associate the product to the entitlement.  
  
> [!NOTE]
>  If you don't add a product, the customer will be entitled to support for all the products.  
  
1.  While in the entitlement record, in the **Products** section, click **+**.  
  
2.  In the **Search** box, type the first few letters of the name of the product that you want to associate with the entitlement.  
  
     If a product isn’t available, click **+ New** to create a new one.  
  
### Associate a customer contact with the entitlement  
 To let only certain contacts of a customer claim the entitlement for a specific product, associate the contacts with the entitlement.  
  
> [!NOTE]
>  If you don’t add a contact, all the contacts for the specified primary customer will be entitled to support.  
  
1.  While in the entitlement record, in the **Contacts** section, click **+**.  
  
2.  In the **Search** box, type the first few letters of the contact that you want to associate with the entitlement. This contact record must belong to the account or contact specified in the **Customer** field.  
  
     If a contact isn’t available, click **+ New** to create a new contact record.  
  
 All active entitlements for a customer appear in the **Active Entitlements** section of the customer record.  
  
## Activate or deactivate an entitlement  
 Before you can start applying an entitlement to a case, you must activate it.  
  
1.  While in the entitlement record, on the command bar, click **Activate**.  
  
2.  In the **Confirm Activation** dialog box, click **Activate**.  
  
    > [!NOTE]
    >  If the start and end date of the entitlement fall in the future, the status of the entitlement is set to **Waiting**. On the start date, the status automatically changes to **Active**. If the end date is in the past, the entitlement is set to **Expired**.  
  
 When an entitlement is active, you can’t edit it. To deactivate an entitlement so you can edit it, on the command bar, click **Deactivate**.  
  
## Set as default entitlement  
 <!--If you’re on [!INCLUDE[pn_crm_online_2015_update_1](../includes/pn-crm-online-2015-update-1.md)] or later, y-->You can activate the entitlement and then set it as the default entitlement for a customer. The entitlement terms from the associated entitlement are automatically decremented. However, if you don’t want the entitlement terms to be decremented for a case, click **Do not decrement entitlement terms** on the command bar.  
  
1.  On the command bar, click **Set As Default**.  
  
2.  In the **Confirm set default** dialog box, click **OK**.  
  
 Now the default entitlement will automatically be applied when a case is created or when a case is updated depending on what you selected for default entitlements in the system settings area. For more information, see the **Automatically apply entitlement** section in  [System Settings dialog box - Service tab](../admin/system-settings-dialog-box-service-tab.md).  
  
## Associate entitlements to cases  
 In a case record, in the **Entitlement** field, click the **Lookup** button, and select an entitlement. The inline lookup shows only the active entitlement for the customer of the case.  
  
 The Entitlements section in the case record lists all the active entitlements for the customer. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)]: [Create a case (Customer Service Hub)](customer-service-hub-user-guide-case-sla.md)

  
## Cancel an entitlement  
 If the entitlement is no longer valid, you can cancel it. To cancel an active or waiting entitlement, open the entitlement, and on the command bar, click **Cancel**.  
  
## Renew an entitlement  
 To renew a canceled or expired entitlement, open the entitlement, and then on the command bar, click **Renew**.  
  
 The current entitlement will be set to **Closed** and a new entitlement will be created.  
  
 The start date of this new entitlement is set to the current date and the end date is set to the current date plus the number of days between the end date and start date. The data in other fields is copied from the old entitlement.  
  
### See also  

 [Set up entitlements quickly with templates](set-up-entitlements-templates.md) <br>

 [Define service level agreements](../customer-service/define-service-level-agreements.md)   <br>


