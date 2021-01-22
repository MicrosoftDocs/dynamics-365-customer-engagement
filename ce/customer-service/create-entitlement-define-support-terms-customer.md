---
title: Create entitlements to define the support terms for a customer (Dynamics 365 Customer Service) | MicrosoftDocs
description: See how to create entitlements to define the support terms for a customer in Dynamics 365 Customer Service
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 01/22/2021
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-customerservice
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---

# Create entitlements to define support terms

Define what kind of support your customers are eligible for by creating entitlements in Dynamics 365 Customer Service. With entitlements, you specify the support term based on number of hours or number of cases. The customer’s support level can vary based on the product or service that the customer has purchased. Customers who’ve purchased different products can be entitled to different support levels. This information helps the customer support agents verify what the customers are eligible for and create cases for them accordingly.  

> [!NOTE]
> With the latest release of Dynamics 365 Customer Service app, entitlements in service management are available in the Customer Service Hub. We recommend that you create and manage entitlements using the new experience.
  
## Create an entitlement
  
1. [!INCLUDE[proc_permissions_custsvcmgr_sysadmin_and_customizer](../includes/proc-permissions-custsvcmgr-sysadmin-and-customizer.md)] You can check your security permissions by following the steps in [View your user profile](../customerengagement/on-premises/basics/view-your-user-profile.md).

2. In the Customer Service Hub sitemap, go to **Service Management**, and select **Service Terms** > **Entitlements**.

   > [!NOTE]
   > In the Customer Service app, [!INCLUDE[proc_settings_service_management](../includes/proc-settings-service-management.md)] and [!INCLUDE[proc_click_or_tap_entitlements](../includes/proc-click-or-tap-entitlements.md)]
  
3. To create an entitlement from a template, select **New** > **From Template**. In the **Select Template** dialog box, select the entitlement template, and select **Select**.  
  
   To create an entitlement from scratch, select **New** > **Blank Entitlement**. 
  
4. [!INCLUDE[proc_handy_infotips](../includes/proc-handy-infotips.md)]  

   - In the **Information** section, specify the basic details:
  
     - **Name**. Give the entitlement a meaningful name.  
  
     - **Primary Customer**. Choose the customer you’re creating this entitlement for.  
  
     - **Start Date**. Choose the date from which the customer will be entitled for support.  
  
     - **End Date**. Choose the date after which the customer will no longer be entitled for support.  
  
     - **Restrict based on entitlement terms**. To make sure no cases are created when the entitlement term is over, select **Yes**. When you choose **Yes**, a customer service agent won’t be able to create a case when **Remaining Terms** is less than zero OR when the term remaining for a channel is less than zero.  
  
     - **SLA**. Choose a service level agreement (SLA) record to associate the service levels or key performance indicators for the support you’re providing with this entitlement.  
     - **Owner**. Specify the owner of the entitlement.
     - **Description**. Write a brief description of the entitlement.
  
   - In the **Entitlement Terms** section, specify the term details for the entitlement:  
  
     - **Allocation Type**. Choose whether the entitlement is for number of hours or number of cases.  
  
     - **Decrease Remaining On**. Choose whether to decrease the remaining term on case creation or resolution.  
  
        If you decrease the remaining term based on case creation:  
  
        - Creating or updating a case with the associated entitlement decreases entitlement terms  
  
        - Canceling a case with the associated entitlement increases entitlement terms  
  
        - Reactivating a canceled case with the associated entitlement decreases the entitlement terms  
  
          If you decrease the remaining term based on case resolution:  
  
       - Resolving a case with the associated entitlement decreases the entitlement terms  
  
       - Reactivating a resolved case with the associated entitlement increases the entitlement terms.  
  
     - **Total Term**. Specify the total amount of support the customer is entitled to with respect to the allocation type. For example, if the allocation type is number of cases and you specify 100 in **Total Term**, the customer is entitled to support up to 100 cases.  
  
     - The **Remaining Term** shows the total number of hours or cases remaining for the customer’s entitlement. The value decreases every time a case is created or resolved (depending on what you select in **Decrease Remaining On**) against the entitlement.  
  
5. Select **Save**.  

When you save the entitlement, additional sections are added for a new entitlement, such as Entitlement channel, Products, and Contacts.

![entitlements-csh](media/entitlement-csh.png)
  
### Add an entitlement channel

The **Entitlement Channel** section specifies the support channel through which the customer can reach the organization and seek support.  
  
Use this section to define the channels your customers are entitled to and track the customer support term for each channel. For example, you can add phone and email as the channels through which you’ll offer support. If you want to restrict support through the phone channel to 80 hours and email to 20 hours, create individual entitlement channel records and add their total terms.  
  
> [!NOTE]
> You must save the entitlement record before you can add entitlement channels to an entitlement.  
  
1. In the **Entitlement Channel** section, select **...**  and select **Add New Entitlement Channel** to add a new entitlement channel.  
  
2. Specify the **Name** of the channel and **Total Terms** that you want to allot to the channel.  
  
     The remaining term is auto-calculated and shows the total number of hours or cases remaining for the customer’s entitlement.  
  
### Associate a product with the entitlement

 If you want the entitlement to apply to a specific product for a customer, associate the product to the entitlement.  
  
> [!NOTE]
> If you don't add a product, the customer will be entitled to support for all the products.  
  
1. While in the entitlement record, in the **Products** section, select **...** and select **Add New Product** to add associate an existing product.  
  
2. In the **Search** box, enter the first few letters of the name of the product that you want to associate with the entitlement.  
  
     If a product isn’t available, select **New** to create one.  
  
### Associate a customer contact with the entitlement

 To let only certain contacts of a customer claim the entitlement for a specific product, associate the contacts with the entitlement.  
  
> [!NOTE]
> If you don’t add a contact, all the contacts for the specified primary customer will be entitled to support.  
  
1. While in the entitlement record, in the **Contacts** section, select **...** and select **Add Existing Contact** to associate an existing contact.  
  
2. In the **Search** box, enter the first few letters of the contact that you want to associate with the entitlement. This contact record must belong to the account or contact specified in the **Customer** field.  
  
   If a contact isn’t available, select **New** to create a contact record.  
  
   All active entitlements for a customer appear in the **Active Entitlements** section of the customer record.  
  
## Activate or deactivate an entitlement

 Before you can start applying an entitlement to a case, you must activate it.  
  
1. While in the entitlement record, on the command bar, select **Activate**.  
  
2. In the **Confirm Activation** dialog box, select **Activate**.  
  
   > [!NOTE]
   > If the start and end date of the entitlement fall in the future, the status of the entitlement is set to **Waiting**. On the start date, the status automatically changes to **Active**. If the end date is in the past, the entitlement is set to **Expired**.  
  
   When an entitlement is active, you can’t edit it. To deactivate an entitlement so you can edit it, on the command bar, select **Deactivate**.  
  
## Set an entitlement as default entitlement

You can activate the entitlement and then set it as the default entitlement for a customer. The entitlement terms from the associated entitlement are automatically reduced. However, if you don’t want the entitlement terms to be reduced for a case, select **Do not decrement entitlement terms** on the command bar.  
  
1. On the command bar, select **Set As Default**.  
  
2. In the **Confirm set default** dialog box, select **OK**.  
  
   Now the default entitlement will automatically be applied when a case is created or when a case is updated depending on what you selected for default entitlements in the system settings area. For more information, see the **Automatically apply entitlement** section in step 4 here, [System Settings dialog box - Service tab](../admin/system-settings-dialog-box-service-tab.md).  
  
## Associate entitlements to cases

In a case record, in the **Entitlement** field, select the **Lookup** button,and select an entitlement. The inline lookup shows only the active entitlement for the customer of the case.  
  
The Entitlements section in the case record lists all the active entitlements for the customer. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)]: [See recent cases and entitlements](customer-service-hub-user-guide-basics.md#related-section)

## Cancel an entitlement

If the entitlement is no longer valid, you can cancel it. To cancel an active or waiting entitlement, open the entitlement, and on the command bar, select **Cancel**.  
  
## Renew an entitlement

To renew a canceled or expired entitlement, open the entitlement, and then on the command bar, select **Renew**. A new entitlement will be created, while the canceled or expired entitlement will remain as is. The start date of the new entitlement will be set to the current date and the end date will be set to the current date plus the number of days between the end date and start date. The data in other fields is copied as is from the old entitlement.

### See also  

 [Set up entitlements quickly with templates](set-up-entitlements-templates.md)  
